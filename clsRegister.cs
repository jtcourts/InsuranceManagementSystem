using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;    // Used to have direct access to the database
using System.Windows.Forms;

namespace MyLoginForm
{
    class clsRegister
    {
        // This class is used to register new users
        
        // Constructor for the class; takes in no parameters

        public clsRegister()
        {
            firstName = "";
            lastName = "";
            email = "";
            password = "";
        }
        
        // Second constructor for the class; takes in the first name, last name, email, and
        // the password that was inputed
        public clsRegister(string fn, string ln, string e, string p)
        {
            firstName = fn;
            lastName = ln;
            email = e;
            password = p;
        }

        // Setting the first name, last name, email, and password as variables
        private string firstName;
        private string lastName;
        private string email;
        private string password;
        
        // Method used to register the user
        public Boolean registerUser()
        {
            try
            {
                // Checking to see if user exists
                if (this.userExists(email)==true)
                {
                    MessageBox.Show("A user with this email already exists!", "Warning!");
                    return false;
                }
                else
                {
                    // Updating the proper tables
                    this.updateTables(firstName, lastName, email, password);
                    return true;
                }
            }
            catch (Exception err)
            {
                // Handling any errors above
                MessageBox.Show(err.Message, "Warning! Registration process failed");
                return false;
            }
        }

        // Helper function for register user, used to check if the user exists or not
        private Boolean userExists(string e)
        {
            //declare all necessary variables to read data from sql server
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                // Setting up connection to DB and querry
                cn.ConnectionString = "Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";
                cmd.CommandText = "SELECT COUNT(Email) FROM dbo.loginCredentials WHERE Email = @email";
                cmd.Parameters.AddWithValue("@email", e);
                cmd.Connection = cn;

                // Opening the connection
                cn.Open();

                // Reading the value
                dr = cmd.ExecuteReader();

                //Read record from the reader
                dr.Read();

                // determining the return value
                if (dr.GetInt32(0) == 0)
                    return false;           // False if the user does not exist
                else
                    return true;            // True if the user does exist in the table
            }
            catch (Exception err)
            {
                // Handling misc errors
                MessageBox.Show(err.Message, "Error with checking for user");
                return false;
            }
            finally
            {
                // Terminating connection
                cn.Close();
            }
        }

        // Helper function to update the tables when registering
        private void updateTables(string fn, string ln, string e, string p)
        {
            //declare all necessary variables to read data from sql server
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            int UserIDRead;
            string r = "CL";
            try
            {
                cn.ConnectionString = "Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";

                // Command to update the table
                cmd.CommandText = "INSERT INTO dbo.loginCredentials(Email, Password) VALUES( @e ,@p )";
                // Adding email and password variables into querry
                cmd.Parameters.AddWithValue("@e", e);
                cmd.Parameters.AddWithValue("@p", p);
                cmd.Connection = cn;

                // Opening the connection
                cn.Open();

                // Updating the database
                cmd.ExecuteNonQuery();

                cn.Close();


                cn.ConnectionString = "Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";

                // Command to get the user ID for insertion into userProfile table
                cmd.CommandText = "SELECT UserID FROM dbo.loginCredentials WHERE Email = @e2 AND Password = @p2";
                // Adding email and password parameters into querry. 2 added to avoid issues with variable renaming
                cmd.Parameters.AddWithValue("@e2", e);
                cmd.Parameters.AddWithValue("@p2", p);
                cmd.Connection = cn;

                // Opening the connection
                cn.Open();

                // Getting and saving the created user ID from loginCredentials
                dr = cmd.ExecuteReader();
                dr.Read();
                UserIDRead = dr.GetInt32(0);

                cn.Close();

                cn.ConnectionString = "Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";

                

                // Updating the userProfile Table
                cmd.CommandText = "INSERT INTO dbo.userProfile (UserID,Role,[First Name],[Last Name]) " +
                    "VALUES (@u,@r, @fn, @ln)";
                cmd.Parameters.AddWithValue("@u", UserIDRead);
                cmd.Parameters.AddWithValue("@fn", fn);
                cmd.Parameters.AddWithValue("@ln", ln);
                cmd.Parameters.AddWithValue("@r", r);
                cmd.Connection = cn;

                // Opening the connection
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error on updating the database");
            }
            finally
            {
                cn.Close();
            }
            
        }
    }
}
