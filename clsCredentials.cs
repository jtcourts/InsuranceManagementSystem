using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;    // Used to have direct access to the database
using System.Windows.Forms;

namespace MyLoginForm
{
    class clsCredentials
    {
        public clsCredentials(string user, string pass)
        {
            username = user;
            password = pass;
        }

        public string username;
        public string password;

        public Boolean checkPassword()
        {
            //declare all necessary variables to read data from sql server
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                // Setting up connection to DB and querry
                cn.ConnectionString = "Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";
                cmd.CommandText = "SELECT Password FROM dbo.loginCredentials WHERE Email = @email";
                cmd.Parameters.AddWithValue("@email", username);
                cmd.Connection = cn;

                // Opening the connection
                cn.Open();

                // Reading the value
                dr = cmd.ExecuteReader();

                //Read record from the reader
                dr.Read();

                // determining the return value
                if (dr.GetString(0) == password)
                    return true;            // True if passwords match
                else
                    return false;            // false if passwords do not match
            }
            catch (Exception err)
            {
                // Handling misc errors
                MessageBox.Show(err.Message, "Warning");
                return false;
            }
            finally
            {
                // Terminating connection
                cn.Close();
            }
        }
    }
}
