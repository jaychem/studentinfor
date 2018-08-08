using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace studentinfor
{
    class stuinfocon
    {
        public static MySqlConnection ConnectDatabase()
        {
            MySqlConnection con = null;
            String connectionStr = @"server=localhost; database=studentinfo; userid=root; password=; Convert Zero Datetime=True;";

            try
            {
                con = new MySqlConnection(connectionStr);
                con.Open(); //open the connection
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return con;
        }
    }
}
