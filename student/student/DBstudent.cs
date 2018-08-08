using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace student
{
    class DBstudent
    {
        private static string tablename = "student";

        private int id;
        private string firstname;
        private string lastname;
        private string middlename;

        public int Id
        {
            get{ return id; }
            set { id = value; }
        }

        public string firstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string lastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string middleName
        {
            get { return middlename; }
            set { middlename = value; }
        }

         public DBstudent()
        {

        }
         public DBstudent(string firstname,string lastname, string middlename)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.middlename = middlename;
        }

        public static List<DBstudent> GetData()
         {
             List<DBstudent> data = new List<DBstudent>();

            MySqlConnection con = DBConnection.ConnectDatabase();

             try
             {
                 MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename, con);
                 MySqlDataReader reader = cmd.ExecuteReader();

                 if (reader.HasRows)
                 {
                     while (reader.Read())
                     {
                         DBstudent rawData = new DBstudent();
                         rawData.Id = reader.GetInt32(0);
                         rawData.firstName = reader.GetString(1);
                         rawData.lastName = reader.GetString(2);
                         rawData.middleName = reader.GetString(3);

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

         public void Add()
         {
             string cmdText = "INSERT INTO " + tablename + " VALUES(0,@firstname,@lastname,@middlename)";
             MySqlConnection con = DBConnection.ConnectDatabase();

             try
             {
                 MySqlCommand cmd = new MySqlCommand(cmdText, con);
                 cmd.Parameters.AddWithValue("@firstname", this.firstName);
                 cmd.Parameters.AddWithValue("@lastname", this.lastName);
                 cmd.Parameters.AddWithValue("@middlename", this.middleName);

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
    }
}
