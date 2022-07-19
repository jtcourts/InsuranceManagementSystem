using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    // add this using directive for access to the sqlServer
using System.Drawing;
using System.IO;   

namespace MyLoginForm
{
    class clsClaimInformationDBH : clsDatabaseHandler
    {
        private clsClaims objClaim;
        private clsUser objUser;
        private clsClaimDetails objDetails;
        public new SqlConnection cn { get; set; }
        public clsClaimInformationDBH() : base()
        {
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";
            cmd.Connection = cn;
        }
        public clsClaimInformationDBH(clsClaims claim, clsUser user)
        {
            objClaim = claim;
            objUser = user;
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";
            cmd.Connection = cn;
        }

        public clsClaimInformationDBH(clsClaims claim, clsUser user, clsClaimDetails details)
        {
            objClaim = claim;
            objUser = user;
            objDetails = details;
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";
            cmd.Connection = cn;
        }
        public clsClaimInformationDBH(string connection)
        {
            try
            {
                cn = new SqlConnection();

                cn.ConnectionString = connection;

                cmd.Connection = cn;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Something went wrong with the DB connection");
            }
        }
        public clsClaimInformationDBH(string connection,clsUser user)
        {
            objUser = user;
            try
            {
                cn = new SqlConnection();

                cn.ConnectionString = connection;

                cmd.Connection = cn;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Something went wrong with the DB connection");
            }
        }

        public override void fetchRowData(int key, int type)
        {
            try
            {
                cmd.Parameters.Clear();
                // Code for type 1, searching based on the claim status
                if (type == 1)
                {
                    cmd.CommandText = "SELECT * FROM dbo.claimInformation WHERE Status = @KEY";
                }

                // Code for type 2, searching based on claimID
                if (type == 2)
                {
                    cmd.CommandText = "SELECT * FROM dbo.claimInformation WHERE ClaimID = @KEY";
                }

                // Adding key to the statement chosen
                cmd.Parameters.AddWithValue("@S", key);
                // Open the connection
                cn.Open();
                // seting up the data reader and reading it
                dr = cmd.ExecuteReader();
                dr.Read();
                // Setting the data of the claim object
                objClaim.ClaimID = dr.GetInt32(0);
                objClaim.TimeStamp = dr.GetDateTime(1);
                objClaim.DateOfIncident = dr.GetString(2);
                objClaim.TimeOfIncident = dr.GetString(3);
                objClaim.Location = dr.GetString(4);
                objClaim.WeatherCondition = dr.GetString(5);
                objClaim.VehicleInvolved = dr.GetString(6);
                objClaim.LicensePlate = dr.GetString(7);
                objClaim.Status = dr.GetString(8);
                objClaim.ClaimManagerID = dr.GetInt32(9);

                // Closing the data reader
                dr.Close();

                // Closing the connection
                cn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error fetching claim information!");
            }
        }

        public override void insertIntoTable(string[] data) 
        {
            try
            {
                cmd.Parameters.Clear();

                // Command to update the table
                cmd.CommandText = "INSERT INTO dbo.claimInformation (Timestamp, DateOfIncident, " +
                    "TimeOfIncident, Location, WeatherCondition, VehicleInvolved, LicensePlate, Status) " +
                    "VALUES( @t,@d,@ti,@l,@w,@v,@lp,@s)";
                // Adding all variables into querry
                cmd.Parameters.AddWithValue("@t", objClaim.TimeStamp);
                cmd.Parameters.AddWithValue("@d", objClaim.DateOfIncident);
                cmd.Parameters.AddWithValue("@ti", objClaim.TimeOfIncident);
                cmd.Parameters.AddWithValue("@l", objClaim.Location);
                cmd.Parameters.AddWithValue("@w", objClaim.WeatherCondition);
                cmd.Parameters.AddWithValue("@v", objClaim.VehicleInvolved);
                cmd.Parameters.AddWithValue("@lp", objClaim.LicensePlate);
                cmd.Parameters.AddWithValue("@s", objClaim.Status);

                // Opening the connection
                cn.Open();

                // Updating the database
                cmd.ExecuteNonQuery();

                // Command to get the user ID for insertion 
                cmd.CommandText = "SELECT ClaimID FROM dbo.claimInformation WHERE TimeStamp = @t2";
                // Adding TimeStamp parameter into querry
                cmd.Parameters.AddWithValue("@t2", objClaim.TimeStamp);

                // Getting and saving the created user ID from loginCredentials
                dr = cmd.ExecuteReader();
                dr.Read();
                objClaim.ClaimID = dr.GetInt32(0);
                
                // close data reader and connection
                dr.Close();
                cn.Close();

                //Finally update the userClaimTalbe
                this.insertUserClaim();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error adding claim to database");
            }
        }

        public void insertClaim()
        {
            try
            {
                cmd.Parameters.Clear();

                // Sql command to get the person with the fewest claims
                // This querry selects userID and a count of claims from an outer join
                // of the claim information(only ones not complete) and userID table
                // if the claim manager has no new claims, then it will be 0
                cmd.CommandText = "SELECT UserID, COUNT(ClaimID) AS claimCount " +
                    "FROM userProfile " +
                    "LEFT OUTER JOIN " +
                    "(SELECT * FROM claimInformation WHERE NOT Status = 'Complete') AS t1 " +
                    "ON UserID = t1.claimManagerID " +
                    "WHERE Role = 'CM' " +
                    "GROUP BY UserID " +
                    "ORDER BY claimCount ASC";

                // Opening the connection to the server
                cn.Open();

                // getting the data and then saving it as an int
                dr = cmd.ExecuteReader();
                dr.Read();
                // taking the first claim manager from the list
                int claimManagerID = dr.GetInt32(0);
                dr.Close();

                // Command to update the table
                cmd.CommandText = "INSERT INTO dbo.claimInformation (Timestamp, DateOfIncident, " +
                    "TimeOfIncident, Location, WeatherCondition, VehicleInvolved, LicensePlate, Status, claimManagerID) " +
                    "VALUES( @t,@d,@ti,@l,@w,@v,@lp,@s,@CMID)";
                // Adding all variables into querry
                cmd.Parameters.AddWithValue("@t", objClaim.TimeStamp);
                cmd.Parameters.AddWithValue("@d", objClaim.DateOfIncident);
                cmd.Parameters.AddWithValue("@ti", objClaim.TimeOfIncident);
                cmd.Parameters.AddWithValue("@l", objClaim.Location);
                cmd.Parameters.AddWithValue("@w", objClaim.WeatherCondition);
                cmd.Parameters.AddWithValue("@v", objClaim.VehicleInvolved);
                cmd.Parameters.AddWithValue("@lp", objClaim.LicensePlate);
                cmd.Parameters.AddWithValue("@s", objClaim.Status);
                cmd.Parameters.AddWithValue("@CMID", claimManagerID);

                // Updating the database
                cmd.ExecuteNonQuery();

                // Command to get the user ID for insertion 
                cmd.CommandText = "SELECT ClaimID FROM dbo.claimInformation WHERE TimeStamp = @t2";
                // Adding TimeStamp parameter into querry
                cmd.Parameters.AddWithValue("@t2", objClaim.TimeStamp);

                // Getting and saving the created user ID from loginCredentials
                dr = cmd.ExecuteReader();
                dr.Read();
                objClaim.ClaimID = dr.GetInt32(0);

                // close data reader and connection
                dr.Close();
                cn.Close();

                //Finally update the userClaimTalbe
                this.insertUserClaim();
                


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error adding claim to database");
            }
        }

        public override void updateTable(string[] data)
        {
            try
            {
                cmd.Parameters.Clear();
                cn.Open();
                cmd.CommandText = "UPDATE dbo.claimInformation SET Timestamp = @1, " +
                    "DateOfIncident = @3, TimeOfIncident = @4, Location = @5, WeatherCondition = @6, " +
                    "VehicleInvolved = @7, LicensePlate = @8, Status = @9, claimManagerID = @a" +
                    " WHERE ClaimID = @CID";
                cmd.Parameters.AddWithValue("@CID", int.Parse(data[0]));      //ClaimID
                cmd.Parameters.AddWithValue("@1", DateTime.Parse(data[1])); //Timestamp
                cmd.Parameters.AddWithValue("@3", data[3]);                 //Date of incident
                cmd.Parameters.AddWithValue("@4", data[4]);                 //Time of incident
                cmd.Parameters.AddWithValue("@5", data[5]);                 //Location
                cmd.Parameters.AddWithValue("@6", data[6]);                 //WeatherCondition
                cmd.Parameters.AddWithValue("@7", data[7]);                 //Vehicle Involved
                cmd.Parameters.AddWithValue("@8", data[8]);                 //License Plate
                cmd.Parameters.AddWithValue("@9", int.Parse(data[9]));      //Status
                cmd.Parameters.AddWithValue("@a", int.Parse(data[10]));     //Claim Manager ID number

                cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Update failed!");
            }
            finally
            {

                cn.Close();
            }
        }
        
        // Helper Function for insertIntoTable
        private void insertUserClaim()
        {
            try
            {
                cmd.Parameters.Clear();
                cn.Open();

                cmd.CommandText = "INSERT INTO dbo.userClaim (UserID,ClaimID)" +
                    "VALUES (@1,@2)";
               // cmd.CommandText = "INSERT INTO dbo.userClaimTable (UserID,ClaimID)" +
                    //"VALUES (@1,@2)";
                cmd.Parameters.AddWithValue("@1", objUser.userId);      //ClaimID
                cmd.Parameters.AddWithValue("@2", objClaim.ClaimID); //Timestamp

                //Executing querry
                cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Problem inserting into the userClaim table!");
            }
            finally
            {
                cn.Close();
            }
        }
        // Helping with inserting claim information. WILL NEED TO CONVERT DOCS IN THE FORM
        public void insertClaimDetails(int id, string descdamage, string descincident, byte[] doc1, byte[] doc2)
        {
            try
            {
                // insert stuff into the claim details table
                // Clear parameters
                cmd.Parameters.Clear();
                // command to insert into the claimDetails table
                cmd.CommandText = "INSERT INTO dbo.claimDetails VALUES(@CID,@DOD,@DOI,@DOCONE,@DOCTWO)";
                cmd.Parameters.AddWithValue("@CID", id);
                cmd.Parameters.AddWithValue("@DOD", descdamage);
                cmd.Parameters.AddWithValue("@DOI", descincident);
                cmd.Parameters.AddWithValue("@DOCONE", doc1);
                cmd.Parameters.AddWithValue("@DOCTWO", doc2);

                //Open connection
                cn.Open();
                // Execute querry
                cmd.ExecuteNonQuery();
                // Close connection
                cn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning! Could not save documents and descriptions!");
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public void insertClaimImages(List<byte []> uploadedImages, int claimid)
        {
            try
            {
                // creating array of image IDs based on amount of items in the list
                int[] imageIDs = new int[uploadedImages.Count];
                // integer to keep track of which position we are at in the imageID array
                int i = 0;
                // open the connection
                cn.Open();
                // for each image in the list, convert 
                foreach (byte[] imageData in uploadedImages)
                {
                    cmd.Parameters.Clear();
                    // Command to save the byte array into the database
                    cmd.CommandText = "INSERT INTO dbo.Images(Image) VALUES(@imagedata)";
                    cmd.Parameters.AddWithValue("@imagedata", imageData);

                    // Insert into the table
                    cmd.ExecuteNonQuery();

                    // Retrieve the imageID generated due to IDENTITY
                    cmd.CommandText = "SELECT ImageID FROM dbo.Images WHERE Image = @datavalue";
                    cmd.Parameters.AddWithValue("@datavalue", imageData);
                    // execute querry and save as datareader
                    dr = cmd.ExecuteReader();
                    // read the data reader
                    dr.Read();
                    // get the imageID from the reader (The only item in the data reader) and
                    // store it into the imageIDs array while incrimenting i
                    imageIDs[i++] = dr.GetInt32(0);
                    dr.Close();
                }

                // Inserting all the image ids with claim id into claimImages table
                foreach (int imageid in imageIDs)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO dbo.claimImages VALUES(@CID,@IID)";
                    cmd.Parameters.AddWithValue("@CID", claimid);
                    cmd.Parameters.AddWithValue("@IID", imageid);

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Image unsuccessfully saved.");
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        public List<clsClaims> LoadAllClaims(Boolean check, DateTime dt)
        {
            List<clsClaims> claims;
            claims = new List<clsClaims>();

            try
            {
                clsClaims tempClaim;

                cn.Open();

                SqlCommand sqlCommand;
                SqlDataReader reader;

                if (check==true)
                {
                    //by casting to a date we can compare just date instead of time too!
                    sqlCommand = new SqlCommand("SELECT * FROM claimInformation " +
                        "WHERE CAST(Timestamp AS DATE) = CAST(@DT AS DATE)", cn);
                    //sqlCommand = new SqlCommand("SELECT * FROM claimInformation WHERE Timestamp > @DT", cn); //greater than 4/7/22 00:00:00 and less than 4/7/22 23:59:99
                    sqlCommand.Parameters.AddWithValue("@DT", dt);
                    reader = sqlCommand.ExecuteReader();
                }
              
                else
                {
                    sqlCommand = new SqlCommand("SELECT * FROM claimInformation", cn);
                    reader = sqlCommand.ExecuteReader();
                }

                while (reader.Read())
                {
                    int cid = (int)reader["ClaimID"];
                    DateTime timeStamp = (DateTime)reader["Timestamp"];
                    string date = (string)reader["DateOfIncident"];
                    string time = (string)reader["TimeOfIncident"];
                    string location = (string)reader["Location"];
                    string weather = (string)reader["WeatherCondition"];
                    string vehicle = (string)reader["VehicleInvolved"];
                    string license = (string)reader["LicensePlate"];
                    string status = (string)reader["Status"];
                    int manager = (int)reader["claimManagerID"];

                    tempClaim = new clsClaims(cid, timeStamp, date, time, location, weather, vehicle, license, status, manager);
                    
                    claims.Add(tempClaim);
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Something went wrong with loading the claim data from the database (Load All)");
            }
            finally
            {
                cn.Close();
            }

            return claims;
        }

        public List<clsClaims> LoadAllClaims(Boolean check, DateTime dt, clsUser objUser)
        {
            List<clsClaims> claims;
            claims = new List<clsClaims>();

            try
            {
                clsClaims tempClaim;

                cn.Open();

                SqlCommand sqlCommand;
                SqlDataReader reader;


                if (check == true)
                {
                    if (objUser.Role == "CM")
                    {
                        //by casting to a date we can compare just date instead of time too!
                        sqlCommand = new SqlCommand("SELECT * FROM claimInformation " +
                            "WHERE CAST(Timestamp AS DATE) = CAST(@DT AS DATE) AND claimManagerID = @cid", cn);
                        sqlCommand.Parameters.AddWithValue("@DT", dt);
                        sqlCommand.Parameters.AddWithValue("@cid", objUser.userId);
                        reader = sqlCommand.ExecuteReader();
                    }
                    else if (objUser.Role == "FM")
                    {
                        //by casting to a date we can compare just date instead of time too!
                        sqlCommand = new SqlCommand("SELECT * FROM claimInformation " +
                            "WHERE CAST(Timestamp AS DATE) = CAST(@DT AS DATE)", cn);
                        sqlCommand.Parameters.AddWithValue("@DT", dt);
                        reader = sqlCommand.ExecuteReader();
                    }
                    else if (objUser.Role == "CL")
                    {
                        sqlCommand = new SqlCommand("SELECT claimInformation.ClaimID AS ClaimID, Timestamp, " +
                            "DateOfIncident, TimeOfIncident, Location, WeatherCondition, VehicleInvolved, " +
                            "LicensePlate, Status, claimManagerID FROM claimInformation " +
                            "INNER JOIN userClaim " +
                            "ON claimInformation.ClaimID = userClaim.ClaimID " +
                            "WHERE CAST(Timestamp AS DATE) = CAST(@DT AS DATE)" +
                            "AND UserID = @uid", cn);
                        sqlCommand.Parameters.AddWithValue("@DT", dt);
                        sqlCommand.Parameters.AddWithValue("@uid", objUser.userId);
                        reader = sqlCommand.ExecuteReader();
                    }
                    else
                    {
                        sqlCommand = new SqlCommand("SELECT * FROM claimInformation " +
                           "WHERE CAST(Timestamp AS DATE) = CAST(@DT AS DATE)", cn);
                        sqlCommand.Parameters.AddWithValue("@DT", dt);
                        reader = sqlCommand.ExecuteReader();
                    }

                }
                else
                {
                    if (objUser.Role == "CM")
                    {
                        sqlCommand = new SqlCommand("SELECT * FROM claimInformation " +
                            "WHERE claimManagerID = @cid", cn);
                        sqlCommand.Parameters.AddWithValue("@cid", objUser.userId);
                        reader = sqlCommand.ExecuteReader();
                    }
                    else if (objUser.Role == "FM")
                    {
                        sqlCommand = new SqlCommand("SELECT * FROM claimInformation", cn);
                        reader = sqlCommand.ExecuteReader();
                    }
                    else if (objUser.Role == "CL")
                    {
                        sqlCommand = new SqlCommand ("SELECT claimInformation.ClaimID AS ClaimID, Timestamp, " +
                            "DateOfIncident, TimeOfIncident, Location, WeatherCondition, VehicleInvolved, " +
                            "LicensePlate, Status, claimManagerID FROM claimInformation " +
                            "INNER JOIN userClaim " +
                            "ON claimInformation.ClaimID = userClaim.ClaimID " +
                            "WHERE UserID = @uid", cn);

                        sqlCommand.Parameters.AddWithValue("@uid", objUser.userId);
                        reader = sqlCommand.ExecuteReader();
                    }
                    else
                    {
                        sqlCommand = new SqlCommand("SELECT * FROM claimInformation", cn);
                        reader = sqlCommand.ExecuteReader();
                    }
                }

                while (reader.Read())
                {
                    int cid = (int)reader["ClaimID"];
                    DateTime timeStamp = (DateTime)reader["Timestamp"];
                    string date = (string)reader["DateOfIncident"];
                    string time = (string)reader["TimeOfIncident"];
                    string location = (string)reader["Location"];
                    string weather = (string)reader["WeatherCondition"];
                    string vehicle = (string)reader["VehicleInvolved"];
                    string license = (string)reader["LicensePlate"];
                    string status = (string)reader["Status"];
                    int manager = (int)reader["claimManagerID"];

                    tempClaim = new clsClaims(cid, timeStamp, date, time, location, weather, vehicle, license, status, manager);

                    claims.Add(tempClaim);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Something went wrong with loading the claim data from the database (Load All)");
            }
            finally
            {
                cn.Close();
            }

            return claims;
        }

        public List<clsClaims> LoadClientClaims(Boolean check, DateTime dt)
        {
            List<clsClaims> claims;
            claims = new List<clsClaims>();

            try
            {
                clsClaims tempClaim;

                cn.Open();
                SqlCommand sqlCommand;
                SqlDataReader reader;

                if (check == true)
                {
                    //by casting to a date we can compare just date instead of time too!
                    sqlCommand = new SqlCommand("SELECT * FROM dbo.claimInformation " +
                    "INNER JOIN dbo.userClaim " +
                    "ON dbo.claimInformation.ClaimID = dbo.userClaim.ClaimID " +
                    "WHERE dbo.userClaim.UserID = @ID", cn);
                    sqlCommand = new SqlCommand("SELECT * FROM claimInformation WHERE Timestamp > @DT", cn); //greater than 4/7/22 00:00:00 and less than 4/7/22 23:59:99
                    sqlCommand.Parameters.AddWithValue("@ID", objUser.userId);
                    sqlCommand.Parameters.AddWithValue("@DT", dt);
                  //  sqlCommand.Parameters.AddWithValue("@uid", userId);
                    reader = sqlCommand.ExecuteReader();
                }
                else
                {
                    sqlCommand = new SqlCommand("SELECT * FROM claimInformation", cn);
                    reader = sqlCommand.ExecuteReader();
                }


                while (reader.Read())
                {
                    int cid = (int)reader["ClaimID"];
                    DateTime timeStamp = (DateTime)reader["Timestamp"];
                    string date = (string)reader["DateOfIncident"];
                    string time = (string)reader["TimeOfIncident"];
                    string location = (string)reader["Location"];
                    string weather = (string)reader["WeatherCondition"];
                    string vehicle = (string)reader["VehicleInvolved"];
                    string license = (string)reader["LicensePlate"];
                    string status = (string)reader["Status"];
                    int manager = (int)reader["claimManagerID"];

                    tempClaim = new clsClaims(cid, timeStamp, date, time, location, weather, vehicle, license, status, manager);

                    claims.Add(tempClaim);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Something went wrong with loading the claim data from the database (Load All)");
            }
            finally
            {
                cn.Close();
            }

            return claims;
        }

        //methods for SQL queries involving joins 
        public int GetUserID(int claimID)
        {

            SqlCommand sqlCommand;
            SqlDataReader reader;
            cn.Open();
            int uid = 0;
            try
            {
                sqlCommand = new SqlCommand("SELECT UserID FROM dbo.claimInformation " +
                    "INNER JOIN dbo.userClaim " +
                    "ON dbo.claimInformation.ClaimID = dbo.userClaim.ClaimID " +
                    "WHERE dbo.claimInformation.ClaimID = @cid", cn);
                sqlCommand.Parameters.AddWithValue("@cid", claimID);
                reader = sqlCommand.ExecuteReader();


                if (reader.HasRows) //check if there are results from sql query 
                {
                    while (reader.Read())
                    {
                        uid = reader.GetInt32(0); //set user ID 
                    }
                }
                else
                {
                    uid = 0;
                    MessageBox.Show("No rows found.");
                }
                reader.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Something went wrong with retrieving userID");
                uid = 0;
            }
            finally
            {
                cn.Close();
            }
            return uid;
        }
        public void GetclaimDescriptions()
        { 
            try
            {
                // Clear parameters
                cmd.Parameters.Clear();
                // command to insert into the claimDetails table
                cmd.CommandText = "SELECT DescriptionOfDamage, DescriptionOfIncident " +
                    "FROM dbo.claimDetails WHERE ClaimID = @cid";
                cmd.Parameters.AddWithValue("@cid", objClaim.ClaimID);
                //Open connection
                cn.Open();
                // seting up the data reader and reading it
                dr = cmd.ExecuteReader();
                dr.Read();
                // Setting the data of the claim object
                objDetails.DescriptionOfDamage = dr.GetString(0);
                objDetails.DescriptionOfIncident = dr.GetString(1);
                // Close connection
                cn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("No descriptions found for this claim.");
              //  throw;
            }
            finally
            {
                cn.Close();
            }
        }
        public void updateStatus(int selectedClaim, string newStatus)
        {
            try
            {
                // Clear the parameters
                cmd.Parameters.Clear();
                // command to update the status of a claim
                cmd.CommandText = "UPDATE dbo.claimInformation " +
                    "SET Status = @status " +
                    "WHERE ClaimID = @CID";
                cmd.Parameters.AddWithValue("@status", newStatus);
                cmd.Parameters.AddWithValue("@CID", selectedClaim);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error updating status");
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
