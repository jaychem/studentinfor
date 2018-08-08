using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace studentinfor
{
    class DBstuinfo
    {
        private static string tablename = "studentinfo";

        private int id;
        private string firstName;
        private string lastName;
        private string middleName;
        private string course;
        private int year;
        private string address;

        public int Id
        {
            get{ return id; }
            set { id = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        public string Course
        {
            get { return course; }
            set { course = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

         public DBstuinfo()
        {

        }

         public DBstuinfo(string firstName, string lastName, string middleName, string course, int year, string address)
        {

            this.firstName = firstName;
            this.lastName = lastName;
            this.middleName = middleName;
            this.course = course;
            this.year = year;
            this.address = address;
        }

        public void Add()
        {
            string cmdText = "INSERT INTO " + tablename + " VALUES(0,@firstName,@lastName,@middleName,@course,@year,@address)";
            MySqlConnection con = stuinfocon.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@firstName",this.FirstName);
                cmd.Parameters.AddWithValue("@lastName", this.LastName);
                cmd.Parameters.AddWithValue("@middleName", this.MiddleName);
                cmd.Parameters.AddWithValue("@course", this.Course);
                cmd.Parameters.AddWithValue("@year",this.Year);
                cmd.Parameters.AddWithValue("@address", this.Address);
               
                cmd.ExecuteNonQuery(); //execute the mysql command
                
                MessageBox.Show("Insert Successfully !");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void Update()
        {
            string cmdText = "UPDATE " + tablename + " SET  firstName = @firstName, lastName=@lastName, middleName=@middleName, course=@course, year=@year, address=@address WHERE id=@id";
            MySqlConnection con = stuinfocon.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@id", this.Id);
                cmd.Parameters.AddWithValue("@firstName", this.FirstName);
                cmd.Parameters.AddWithValue("@lastName", this.LastName);
                cmd.Parameters.AddWithValue("@middleName", this.MiddleName);
                cmd.Parameters.AddWithValue("@course", this.Course);
                cmd.Parameters.AddWithValue("@year", this.Year);
                cmd.Parameters.AddWithValue("@address", this.Address);


                cmd.ExecuteNonQuery(); //execute the mysql command
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void Delete()
        {
            MySqlConnection con = stuinfocon.ConnectDatabase();
            string command = "DELETE FROM " + tablename + " WHERE id=@id";

            try
            {
                MySqlCommand cmd = new MySqlCommand(command, con);
                cmd.Parameters.AddWithValue("@id", this.Id);

                cmd.ExecuteNonQuery(); //execute the mysql command

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void Delete(string id)
        {
            MySqlConnection con = stuinfocon.ConnectDatabase();
            string command = "DELETE FROM " + tablename + " WHERE id=@id";

            try
            {
                MySqlCommand cmd = new MySqlCommand(command, con);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery(); //execute the mysql command

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static List<DBstuinfo> GetData()
        {
            List<DBstuinfo> data = new List<DBstuinfo>();

            MySqlConnection con = stuinfocon.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBstuinfo rawData = new DBstuinfo();
                        rawData.Id = reader.GetInt32(0);
                        rawData.FirstName = reader.GetString(1);
                        rawData.LastName = reader.GetString(2);
                        rawData.MiddleName = reader.GetString(3);
                        rawData.Course = reader.GetString(4);
                        rawData.Year = reader.GetInt32(5);
                        rawData.Address = reader.GetString(6);

                        data.Add(rawData);
                    }
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return data;
        }

        public static DBstuinfo GetDataID(int id)
        {
            DBstuinfo data = null;

            MySqlConnection con = stuinfocon.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE id="+id,con);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    reader.Read();

                    data = new DBstuinfo();
                    data.Id = reader.GetInt32(0);
                    data.FirstName = reader.GetString(1);
                    data.LastName = reader.GetString(2);
                    data.MiddleName = reader.GetString(3);
                    data.Course = reader.GetString(4);
                    data.Year = reader.GetInt32(5);
                    data.Address = reader.GetString(6);
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return data;

        }
    
    }
}
