using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    // add this using directive for access to the sqlServer


namespace MyLoginForm
{
    class clsUserProfileDBH : clsDatabaseHandler
    {
        clsUser objUser;
        public clsUserProfileDBH() : base()
        {

        }
        //constructor that takes a user as an object...
        public clsUserProfileDBH(clsUser user) : base()
        {
            objUser = user;
        }

        public override void fetchRowData(int key, int type)
        {
            string[] data = new string[10];
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT UserID,Role, PhoneNumber, Address, FirstName, LastName," +
                    "MiddleName, State,City,Zip FROM dbo.userProfile WHERE UserID = @UID";

                cmd.Parameters.AddWithValue("@UID", key);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                // populating the data array
                // The two values that are not strings
                data[0] = dr.GetInt32(0).ToString();
                data[2] = dr.GetInt64(2).ToString();
                data[9] = dr.GetInt32(9).ToString();
                // Filling the rest of strings
                for (int i = 1; i < 10 - 1; i++)
                {
                    if (i == 2)
                        continue;
                    else
                        data[i] = dr.GetString(i);
                }

                // Closing data reader
                dr.Close();
                setData(data);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error fetching data!");
            }
            finally
            {
                cn.Close();
            }
        }
        private void setData(string[] data)
        {
            objUser.Role = data[1];
            if (data[2] == "0" || data[2] == null)
            {
                objUser.phone = "";
            }
            else
            {
                objUser.phone = data[2];
            }
            objUser.address = data[3];
            objUser.firstName = data[4];
            objUser.lastName = data[5];
            objUser.middleName = data[6];
            objUser.state = data[7];
            objUser.city = data[8];
            if (data[9] == "0" || data[9] == null)
            {
                objUser.zip = data[9];
            }
            else
            {
                objUser.zip = data[9];
            }
        }

        public override void insertIntoTable(string[] data)
        {
            try
            {
                // Clearing the parameters to be safe
                cmd.Parameters.Clear();
                cn.Open();
                // Inserting the new user profile from given string of data information parsed to appropriate data type in SQL database
                cmd.CommandText = "INSERT INTO dbo.userProfile " +
                    "VALUES (@1,@2,@3,@4,@5,@6,@7,@8,@9,@L)";
                cmd.Parameters.AddWithValue("@1", int.Parse(data[0]));      //User ID
                cmd.Parameters.AddWithValue("@2", data[1]);                 //Role
                cmd.Parameters.AddWithValue("@3", long.Parse(data[2]));     //Phone Number
                cmd.Parameters.AddWithValue("@4", data[3]);                 //Address
                cmd.Parameters.AddWithValue("@5", data[4]);                 //First Name
                cmd.Parameters.AddWithValue("@6", data[5]);                 //Last Name
                cmd.Parameters.AddWithValue("@7", data[6]);                 //Middle Name
                cmd.Parameters.AddWithValue("@8", data[7]);                 //State
                cmd.Parameters.AddWithValue("@9", data[8]);                 //City
                cmd.Parameters.AddWithValue("@L", int.Parse(data[9]));      //Zip

                // Executing the querry
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message,"Local one");
            }
            finally
            {
                cn.Close();
            }
            
        }

        public override void updateTable(string[] data) // Right now cannot update email and doesn't touch role
        {
            try
            {
                // Update the table based on inserted information (in the array)
                cmd.Parameters.Clear();
                cn.Open();
                cmd.CommandText = "UPDATE dbo.userProfile " +
                    "SET PhoneNumber = @ph, Address = @adr, State = @s, City = @c, Zip = @z," +
                    "FirstName = @fn, LastName = @ln, MiddleName = @mn " +
                    "WHERE UserID = @UID";

                cmd.Parameters.AddWithValue("@UID", int.Parse(data[0]));
                cmd.Parameters.AddWithValue("@ph", Convert.ToInt64(data[1]));
                cmd.Parameters.AddWithValue("@adr", data[2]);
                cmd.Parameters.AddWithValue("@s", data[3]);
                cmd.Parameters.AddWithValue("@c", data[4]);
                cmd.Parameters.AddWithValue("@z", int.Parse(data[5]));
                cmd.Parameters.AddWithValue("@fn", data[6]);
                cmd.Parameters.AddWithValue("@ln", data[7]);
                cmd.Parameters.AddWithValue("@mn", data[8]);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Please ensure that all fields are completed correctly.");
                //MessageBox.Show(err.Message, "Error updating user info");
            }
            finally
            {
                //MessageBox.Show("You have successfully updated your personal information");
                cn.Close();
            }

        }

        // Used to insert a new row of information into a table
        public void addNewUser(string fn, string ln, string e, string p)
        {
            int UserIDRead;
            string r = "CL";
            string[] data;
            try
            {
                // Command to update the table
                cmd.CommandText = "INSERT INTO dbo.loginCredentials(Email, Password) VALUES( @e ,@p )";
                // Adding email and password variables into querry
                cmd.Parameters.AddWithValue("@e", e);
                cmd.Parameters.AddWithValue("@p", p);

                // Opening the connection
                cn.Open();

                // Updating the database
                cmd.ExecuteNonQuery();

                // Command to get the user ID for insertion into userProfile table
                cmd.CommandText = "SELECT UserID FROM dbo.loginCredentials WHERE Email = @e2 AND Password = @p2";
                // Adding email and password parameters into querry. 2 added to avoid issues with variable renaming
                cmd.Parameters.AddWithValue("@e2", e);
                cmd.Parameters.AddWithValue("@p2", p);

                // Getting and saving the created user ID from loginCredentials
                dr = cmd.ExecuteReader();
                dr.Read();
                UserIDRead = dr.GetInt32(0);
                dr.Close();
                cn.Close();

                data = new String[] { UserIDRead.ToString(),r,"0","",fn,ln,"","","","0"};

                // Updating the userProfile Table
                this.insertIntoTable(data);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error updating the database");
            }

        }
    }
}
