using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLoginForm
{
    class clsUserSettingsDBH : clsDatabaseHandler
    {
        clsUser objUser;
        clsSettings objSet;
        public clsUserSettingsDBH() : base()
        {

        }
        //constructor that takes a user as an object...
        public clsUserSettingsDBH(clsUser user, clsSettings s) : base()
        {
            objUser = user;
            objSet = s;
        }

        public override void fetchRowData(int key, int type)
        {
            string[] data = new string[6];
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT UserID,Password, " +
                    "CCN, PIN, Exp,CardName FROM dbo.userSettings WHERE UserID = @UID"; //SecQuest1, SecQuest1, SecAnswer1, SecAnswer2,

                cmd.Parameters.AddWithValue("@UID", key);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                // populating the data array
                // The two values that are not strings
                data[0] = dr.GetInt32(0).ToString();
                data[3] = dr.GetInt32(3).ToString();
                // Filling the rest of strings
                for (int i = 1; i < 6; i++)
                {
                    if (i == 0)
                        continue;
                    if (i == 3)
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
            objSet.Password = data[1];
            objSet.CCN = data[2];

            if (data[3] == "0" || data[3] == null)
            {
                objSet.PIN = data[3];
            }
            else
            {
                objSet.PIN = data[3];
            }
            objSet.Exp = data[4];
            objSet.CardName = data[5];
        }

        public override void insertIntoTable(string[] data)
        {
            try
            {
                // Clearing the parameters to be safe
                cmd.Parameters.Clear();
                cn.Open();
                // Inserting the new user profile from given string of data information parsed to appropriate data type in SQL database
                cmd.CommandText = "INSERT INTO dbo.userSettings " +
                    "VALUES (@1,@2,@3,@4,@5,@L)"; //@6,@7,@8,@9
                cmd.Parameters.AddWithValue("@1", data[0]);                  //User ID
                cmd.Parameters.AddWithValue("@2", data[1]);                 //Password
                cmd.Parameters.AddWithValue("@3", data[2]);                 //credit card number
                cmd.Parameters.AddWithValue("@4", int.Parse(data[3]));      //pin
                cmd.Parameters.AddWithValue("@5", data[4]);                 //expiration date
                cmd.Parameters.AddWithValue("@L", data[5]);                 //card name

                // Executing the querry
                cmd.ExecuteNonQuery();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Local one");
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
                cmd.CommandText = "UPDATE dbo.userSettings " +
                    "SET Password = @p, " +
                    "CCN = @ccn, PIN = @pin, Exp = @exp, CardName = @cn " +
                    "WHERE UserID = @UID";

                cmd.Parameters.AddWithValue("@UID", int.Parse(data[0]));
                cmd.Parameters.AddWithValue("@p", data[1]);
                cmd.Parameters.AddWithValue("@ccn", data[2]);
                cmd.Parameters.AddWithValue("@pin", int.Parse(data[3]));
                cmd.Parameters.AddWithValue("@exp", data[4]);
                cmd.Parameters.AddWithValue("@cn", data[5]);

                cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show( err.Message, "Please ensure that all fields are completed correctly.");
            }
            finally
            {
                cn.Close();
            }

        }

        public Boolean userExists()
        {
            try
            {
                // Setting up connection to DB and querry
                cmd.CommandText = "SELECT COUNT(UserID) FROM dbo.userSettings WHERE UserID = @uid";
                cmd.Parameters.AddWithValue("@uid", objUser.userId);

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
    }

}
