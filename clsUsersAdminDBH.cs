using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLoginForm
{
    class clsUsersAdminDBH //: clsDatabaseHandler
    {
        public SqlConnection cn { get; set; }
        public SqlCommand cmd;

        public clsUsersAdminDBH(string connection) //clsUser user) : base()
        {
            try
            {

                cn = new SqlConnection();
                cmd = new SqlCommand();
                cn.ConnectionString = connection; 
                cmd.Connection = cn;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Something went wrong with the DB connection");
            }
        }
        
        public List<clsUser> LoadDataFromDb()
        {
            //declare a list of Employee objects
            List<clsUser> users;

            users = new List<clsUser>(); //instantiate the employees list

            try //error handling
            {

                clsUser tempUser;

                cn.Open();

                SqlCommand sqlCommand = new SqlCommand("SELECT FirstName, LastName, UserID, Role FROM dbo.userProfile", cn);

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {

                    string userFirstName = (string)reader["FirstName"];
                    string userLastName = (string)reader["LastName"];
                    int userUserID = (int)reader["UserID"];
                    string userRole = (string)reader["Role"];

                    tempUser = new clsUser(userFirstName, userLastName, userUserID, userRole);

                    users.Add(tempUser);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Something went wrong with loading data from the database!");

            }
            finally
            {
                cn.Close();

            }

            return users;

        }
    }
}
