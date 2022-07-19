using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;    // add this using directive for access to the sqlServer
using System.Windows.Forms;


namespace MyLoginForm
{
    public class clsUser
    {
        //include default constructor 
        public clsUser(string firstName, string lastName, int userId, string role /*, int p, string a, string mn, string s, int z, string c */)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.userId = userId;
            this.Role = role;
            // Setting up the database connection
            cn.ConnectionString = "Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";
            cmd.Connection = cn;
        }

        public clsUser()
        {
            cn.ConnectionString = "Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";
            cmd.Connection = cn;
        }

        public clsUser(string user, string pass)
        {
            username = user;
            password = pass;

            // Setting up the databse connection
            cn.ConnectionString = "Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";
            cmd.Connection = cn;
            //this.getProfileInformation(); we don't want to do this here in case user isn't in DB
        }

        //constructor to help with registration 
        public clsUser(string fn, string ln, string e, string p)
        {
            userInformation[4] = fn;
            userInformation[5] = ln;
            username = e;
            password = p;

            // Setting up the databse connection
            cn.ConnectionString = "Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";
            cmd.Connection = cn;
        }

        //constructor to help with checking if a user is in the DB 
        //specifically so we can send a message to that user
        public clsUser(string fn, string ln, int reason)
        {
            firstName = fn;
            lastName = ln;
            cn.ConnectionString = "Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";
            cmd.Connection = cn;
        }

        public clsUser(int id) //this is so we can get user info when we just have id...
        {
            userId = id;
            cn.ConnectionString = "Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";
            cmd.Connection = cn;
        }

        public clsUser(int id, string user)
        {
            userId = id;
            username = user;

            // Setting up the databse connection
            cn.ConnectionString = "Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";
            cmd.Connection = cn;
            //this.getProfileInformation(); we don't want to do this here in case user isn't in DB
        }

        //get the username and password from login 
        public string password { get; set; }//automatic property -- a gateway to the data and authorization
        public string username { get; set; }

        public int userId { get; set; }
        public string Role { get; set; }

        //User information retrieved from user profile
        public string firstName { get; set; }
        public string lastName { get; set; }


        public string phone { get; set; }
        public string email { get; set; }
        public string role { get; set; }
        public string address { get; set; }
        public string middleName { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string zip { get; set; }

        //settings form
        public string secQuest1 { get; set; }
        public string secQuest2 { get; set; }
        public string secAnswer1 { get; set; }

        public string secAnswer2 { get; set; }
        public string ccn { get; set; }
        public string pin { get; set; }
        public string exp { get; set; }
        public string cardName { get; set; }

        public override string ToString()
        {
            return string.Format("{1} {2}, User ID: {0}, Role: {3}", userId, firstName, lastName, Role);
        }


        // ARRAY OF USER INFORMATION. THE ORDER FOR THE ARRAY IS:
        // UserID(0), Role (1), phone number(2), address, first name, last name, middle name, state, city, zip
        public string [] userInformation = new string [6];
        public string[] settingsInformation = new string[6];

        //declare all necessary variables to read data from sql server
        private SqlConnection cn = new SqlConnection();
        private SqlCommand cmd = new SqlCommand();
        private SqlDataReader dr;

        private clsUserProfileDBH objUserProfileDBH;

        //methods
        public string getEmail()
        {
            //return LoginForm.Email
            return username;
            //string email = LoginForm.Email
        }
        public string getPassword()
        {
            return password;
        }

        public Boolean checkUsername()
        {
            try
            {
                cmd.CommandText = "SELECT COUNT(Email) FROM dbo.loginCredentials WHERE Email = @user";
                cmd.Parameters.AddWithValue("@user", username);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.GetInt32(0) == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception err)
            {
                // Handling misc errors
                MessageBox.Show(err.Message, "Probelem with Check User");
                return false;
            }
            finally
            {
                // Terminating connection
                cn.Close();
                dr.Close();
            }
        }
        
        public Boolean checkPassword()
        {
            if(checkUsername()==true)
            //if(true == true)
            {
                try
                {
                    // Setting up the SQL command
                    cmd.CommandText = "SELECT Password FROM dbo.loginCredentials WHERE Email = @email";
                    cmd.Parameters.AddWithValue("@email", username);

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
                    dr.Close();
                }
            }
            else
            {
               // MessageBox.Show("User is not in database");
                return false; 
            }
            
        }//end of login method

        // Method used to register the user
        public Boolean registerUser()
        {
            objUserProfileDBH = new clsUserProfileDBH(this);
            try
            {
                // Checking to see if user exists
                if (this.userExists(username) == true)
                {
                    MessageBox.Show("A user with this email already exists!", "Warning!");
                    return false;
                }
                else
                {
                    // Updating the proper tables
                    objUserProfileDBH.addNewUser(userInformation[4], userInformation[5], username, password);
                    return true;
                }
            }
            catch (Exception err)
            {
                // Handling any errors above
                MessageBox.Show(err.Message, "Warning! Registration process failed");
                return false;
            }
        }//end register method

        // Private function that sets the user ID and puts values into the data array
        public void getProfileInformation()
        {
            // get id and store in variable
            this.setId();
            // using databasehandler object to fetch all the user data and store it in array
            objUserProfileDBH = new clsUserProfileDBH(this);
            objUserProfileDBH.fetchRowData(userId,1);
        } // End of getProfileInformation

        public void getProfileInfo()
        {
            // using databasehandler object to fetch all the user data and store it in array
            objUserProfileDBH = new clsUserProfileDBH(this);
            objUserProfileDBH.fetchRowData(userId, 1);
        } // End of getProfileInformation
        public void getProfileInformation2()
        {
            // using databasehandler object to fetch all the user data and store it in array
            objUserProfileDBH = new clsUserProfileDBH(this);
            objUserProfileDBH.fetchRowData(userId, 1);
        } // End of getProfileInformation

        private void setId()
        {
            try
            {
                // Setting up the querry and executing it to get the user id
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT UserID FROM dbo.loginCredentials WHERE Email = @username AND Password = @password";
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                userId = dr.GetInt32(0);        // Here we got the user ID
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error getting user ID");
            }
            finally
            {
                cn.Close();
            }
        } //End of SetId

        //Helper function for registering a new user
        private Boolean userExists(string e)
        {
            try
            {
                // Setting up connection to DB and querry
                cmd.CommandText = "SELECT COUNT(Email) FROM dbo.loginCredentials WHERE Email = @email";
                cmd.Parameters.AddWithValue("@email", e);

                // Opening the connection
                cn.Open();

                // Reading the value
                dr = cmd.ExecuteReader();

                //Read record from the reader
                dr.Read();

                // determining the return value
                if (dr.GetInt32(0) == 0)
                {
                    dr.Close();
                    return false;           // False if the user does not exist
                }
                else
                {
                    dr.Close();
                    return true;            // True if the user does exist in the table
                }

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
        
        public void UpdateInfo(string[] data)
        {
            objUserProfileDBH = new clsUserProfileDBH(this);
            objUserProfileDBH.updateTable(data); //calls db handler method to update table
            this.getProfileInformation();
        }

        //For messages 
        public int getIDGivenNames()
        {
            try
            {
                // Setting up connection to DB and querry
                cmd.CommandText = "SELECT COUNT(FirstName) FROM dbo.userProfile WHERE FirstName = @fname AND LastName = @lname";
                cmd.Parameters.AddWithValue("@fname", firstName);
                cmd.Parameters.AddWithValue("@lname", lastName);

                // Opening the connection
                cn.Open();

                // Reading the value
                dr = cmd.ExecuteReader();

                //Read record from the reader
                dr.Read();

                // determining the return value
                if (dr.GetInt32(0) == 0)
                {
                    MessageBox.Show("Individual Can't be found in our Database", "Please Enter " +
                        "A valid First and Last Name");
                    dr.Close();
                    return -1;           // if the user does not exist
                }
                else
                {
                    dr.Close();
                    cmd.Parameters.Clear();
                    cmd.CommandText = "SELECT UserID FROM dbo.userProfile WHERE FirstName = @fname AND LastName = @lname";
                    cmd.Parameters.AddWithValue("@fname", firstName);
                    cmd.Parameters.AddWithValue("@lname", lastName);
                    //execute command 
                    dr = cmd.ExecuteReader();
                    //Read record from the reader
                    dr.Read();
                    return dr.GetInt32(0);            // user ID if the user does exist in the table
                }

            }
            catch (Exception err)
            {
                // Handling misc errors
                MessageBox.Show(err.Message, "Error Finding User in Database");
                return -1;
            }
            finally
            {
                // Terminating connection
                cn.Close();
            }
        }
    }
}
