using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;    // add this using directive for access to the sqlServer
using System.Windows.Forms;

namespace MyLoginForm
{
    class clsMessagesDBH: clsDatabaseHandler
    {
        //private SqlConnection cn = new SqlConnection();
        private SqlCommand cmd = new SqlCommand();
        private clsUser objUser;
        private clsMessages objMessage;
        
        public new SqlConnection cn { get; set; }

        public clsMessagesDBH() : base()
        {
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";
            cmd.Connection = cn;
        }
        public clsMessagesDBH(clsUser user, clsMessages message)
        {
            objUser = user;
            objMessage = message;
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";
            cmd.Connection = cn;
        }
        public clsMessagesDBH(clsUser user)
        {
            objUser = user;
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";
            cmd.Connection = cn;
        }

        public override void fetchRowData(int key, int type)
        {
            try
            {
                cmd.Parameters.Clear();
                // Code for type 1, searching based on the recipient and sender
                if (type == 1)
                {
                    cmd.CommandText = "SELECT * FROM dbo.Messages WHERE receiverID = @KEY" +
                        "AND senderID = @S";
                }

                // Adding key to the statement chosen
                cmd.Parameters.AddWithValue("KEY", key);
                cmd.Parameters.AddWithValue("@S", objUser.userId);
                // Open the connection
                cn.Open();
                // seting up the data reader and reading it
                dr = cmd.ExecuteReader();
                dr.Read();
                // Setting the data of the claim object
                objMessage.MessageID = dr.GetInt32(0);
                objMessage.SenderID = dr.GetInt32(1);
                objMessage.ReceiverID = dr.GetInt32(2);
                objMessage.MessageContents = dr.GetString(3);
                objMessage.TimeStamp = dr.GetDateTime(4);
                objMessage.Read = dr.GetInt32(5);

                // Closing the data reader
                dr.Close();

                // Closing the connection
                cn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error fetching message Info!");
            }
        }

        public List <clsMessages> getMessages(int key ) //this is so we can get a list of messages
        {
            List<clsMessages> messages;
            messages = new List<clsMessages>();

            try //error handling
            {
                clsMessages tempMessage;

                cn.Open();
                SqlCommand sqlCommand = new SqlCommand("(SELECT * FROM dbo.Messages " +
                    "WHERE receiverID = @KEY AND senderID = @S)" +
                    "UNION " +
                    "(SELECT * FROM dbo.Messages " +
                    "WHERE receiverID = @send AND senderID = @rec)", cn);
                sqlCommand.Parameters.AddWithValue("@KEY", key);
                sqlCommand.Parameters.AddWithValue("@S", objUser.userId);
                sqlCommand.Parameters.AddWithValue("@send", objUser.userId);
                sqlCommand.Parameters.AddWithValue("@rec", key);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    int mID = (int)reader["messageID"];
                    int sID = (int)reader["senderID"];
                    int rID = (int)reader["receiverID"];
                    string mC = (string)reader["messageContents"];
                    DateTime t = (DateTime)reader["Timestamp"];
                    int r = (int)reader["Read"];
                    tempMessage = new clsMessages(mID, sID, rID, mC, t, r, objUser);
                    messages.Add(tempMessage);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Something went wrong with loading your messages!");
            }
            finally
            {
                cn.Close();
            }
            messages.Sort((x, y) => x.TimeStamp.CompareTo(y.TimeStamp));
            return messages;
        }

        public List<int> getRids()
        {
            List<int> rids;
            rids = new List<int>();
            if (checkRids()!=false)
            {
                try //error handling
                {
                    cmd.Parameters.Clear();
                    cn.Open();

                    SqlCommand sqlCommand = new SqlCommand("(SELECT DISTINCT senderID FROM dbo.Messages " +
                        "WHERE receiverID = @r)", cn);
                    sqlCommand.Parameters.AddWithValue("@r", objUser.userId);

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        int rID = (int)reader["senderID"];
                        rids.Add(rID);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Something went wrong with loading your contacts!");
                }
                finally
                {
                    cn.Close();
                }
            }
            else
            {
                rids.Add(-1);
            }
            
            return rids;
        }
        public bool checkRids()
        {
            try //error handling
            {
                cmd.CommandText = "SELECT COUNT(receiverID) FROM dbo.Messages WHERE senderID = @user";
                cmd.Parameters.AddWithValue("@user", objUser.userId);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.GetInt32(0) >= 1)
                    return true;
                else
                    return false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Something went wrong with checking for recipients!");
                return false;
            }
            finally
            {
                cn.Close();
            }
        }
        public override void insertIntoTable(string[] data) //this is so we can insert a message into DB
        {
            try
            {
                cmd.Parameters.Clear();

                // Command to update the table
                cmd.CommandText = "INSERT INTO dbo.Messages(senderID, receiverID, " +
                    "messageContents, Timestamp, [Read]) VALUES( @sid, @rid, @m, @t, @read)";
                // Adding all variables into querry
                cmd.Parameters.AddWithValue("@sid", objMessage.SenderID);
                cmd.Parameters.AddWithValue("@rid", objMessage.ReceiverID);
                cmd.Parameters.AddWithValue("@m", objMessage.MessageContents);
                cmd.Parameters.AddWithValue("@t", objMessage.TimeStamp);
                cmd.Parameters.AddWithValue("@read", objMessage.Read);
                // Opening the connection
                cn.Open();

                // Updating the database
                cmd.ExecuteNonQuery();

                // Command to get the user ID for insertion 
                cmd.CommandText = "SELECT messageID FROM dbo.Messages WHERE TimeStamp = @t2";
                // Adding TimeStamp parameter into querry
                cmd.Parameters.AddWithValue("@t2", objMessage.TimeStamp);

                // Getting and saving the created user ID from loginCredentials
                dr = cmd.ExecuteReader();
                dr.Read();
                objMessage.MessageID = dr.GetInt32(0);

                // close data reader and connection
                dr.Close();
                cn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Sending Message");
            }
        }
        public override void updateTable(string[] data) //I don't know that this will ever be needed
        {

        }

        public void deleteROW() //this gives us functionality to delete a message 
        {
            try
            {
                cmd.Parameters.Clear();

                // Command to update the table
                cmd.CommandText = "DELETE FROM dbo.Messages WHERE messageID = @mid";
                // Adding all variables into querry
                cmd.Parameters.AddWithValue("@mid", objMessage.MessageID); 
                cn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Deleteing the Message");
            }
        }
    }
}
