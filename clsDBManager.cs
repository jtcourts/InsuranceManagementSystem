using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLoginForm
{
    public class clsDBManager
    {
        //declare a SqlConnection automatic property
        public SqlConnection cn { get; set; }
        public clsDBManager(string connection) //constructor
        {
            //error handling
            try
            {

                cn = new SqlConnection(); //create an instance of a new SqlConnection

                cn.ConnectionString = connection;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Something went wrong with the DB connection");
            }

        }

        //method takes a list of Employee objects and saves them to a sqlServer database table
        public void InsertDataToDb(List<clsUser> users)
        {
            try
            {
                cn.Open();

                SqlCommand cmd =
                    new SqlCommand(
                        "INSERT INTO dbo.userProfile (firstName, lastName, UserID, Role) " +
                        " VALUES (@userfirstName, @userlastName, @useruserId, @userrole)");

                cmd.Connection = cn;

                //traverse the list of employees
                foreach (var user in users)
                {
                    cmd.Parameters.Clear(); //clear previous parameter values

                    //populate the query parameters with actual values taken from each Employee object
                    cmd.Parameters.AddWithValue("@userfirstName", user.firstName);
                    cmd.Parameters.AddWithValue("@userlastName", user.lastName);
                    cmd.Parameters.AddWithValue("@useruserId", user.userId);
                    cmd.Parameters.AddWithValue("@userrole", user.Role);

                    cmd.ExecuteNonQuery();

                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Something went wrong with inserting data to the database!");

            }
            finally
            {
                cn.Close();
            }
        }

        
        //method to load data from a database table into a list of Employee objects
        public List<clsUser> LoadDataFromDb()
        {
            //declare a list of Employee objects
            List<clsUser> users;
            users = new List<clsUser>(); //instantiate the employees list

            try //error handling
            {
                clsUser tempUser;

                cn.Open();

                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM userProfile", cn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    string userusername = (string)reader["firstName"];
                    string userfirstName = (string)reader["firstName"];
                    string userlastName = (string)reader["lastName"];
                    int useruserId = (int)reader["userId"];
                    string userrole = (string)reader["role"];

                    tempUser = new clsUser(userfirstName, userlastName, useruserId, userrole);

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

        public List<clsUser> ClientLoadDataFromDb()
        {
            //declare a list of Employee objects
            List<clsUser> users;
            users = new List<clsUser>(); //instantiate the employees list

            try //error handling
            {
                clsUser tempUser;

                cn.Open();

                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM userProfile WHERE Role <> 'CL'", cn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    string userusername = (string)reader["firstName"];
                    string userfirstName = (string)reader["firstName"];
                    string userlastName = (string)reader["lastName"];
                    int useruserId = (int)reader["userId"];
                    string userrole = (string)reader["role"];

                    tempUser = new clsUser(userfirstName, userlastName, useruserId, userrole);

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

        public List<clsUser> LoadClientsFromDb()
        {
            //declare a list of Employee objects
            List<clsUser> users;
            users = new List<clsUser>(); //instantiate the employees list

            try //error handling
            {
                clsUser tempUser;

                cn.Open();

                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM userProfile WHERE Role = 'CL'", cn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    string userfirstName = (string)reader["firstName"];
                    string userlastName = (string)reader["lastName"];
                    int useruserId = (int)reader["userId"];
                    string userrole = (string)reader["role"];

                    tempUser = new clsUser(userfirstName, userlastName, useruserId, userrole);

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

        public List<clsUser> LoadUsersFromDb()
        {
            //declare a list of Employee objects
            List<clsUser> users;
            users = new List<clsUser>(); //instantiate the employees list

            try //error handling
            {
                clsUser tempUser;

                cn.Open();

                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM userProfile", cn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    string userfirstName = (string)reader["firstName"];
                    string userlastName = (string)reader["lastName"];
                    int useruserId = (int)reader["userId"];
                    string userrole = (string)reader["role"];

                    tempUser = new clsUser(userfirstName, userlastName, useruserId, userrole);

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
