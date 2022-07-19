using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLoginForm
{
    class clsDocumentsDBH
    {
        clsUser objUser;
        clsDocuments objDoc;
        public new SqlConnection cn { get; set; }
        private SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public clsDocumentsDBH(clsDocuments doc, clsUser user)
        {
            objDoc = doc;
            objUser = user;
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";
            cmd.Connection = cn;
        }

        public void insertTransfer()
        {
            try
            {
                cmd.Parameters.Clear();

                cn.Open();

                // Command to update the table (TransferId will be automatically generated)
                cmd.CommandText = "INSERT INTO dbo.docTransfer (ReceiveId) " +
                    "VALUES(@RID)";
                // Adding all variables into querry
                cmd.Parameters.AddWithValue("@RID", objDoc.objUser.userId);

                // Updating the database
                cmd.ExecuteNonQuery();

                // Clearing the parameters
                cmd.Parameters.Clear();
                // Selecting the highest TransferId [this means most recent]
                cmd.CommandText = "SELECT MAX(TransferId) FROM docTransfer";

                dr = cmd.ExecuteReader();
                dr.Read();
                objDoc.transferId = dr.GetInt32(0);

                // close data reader and connection
                dr.Close();
                cn.Close();

                //Finally update the userClaimTalbe
                this.insertUserTransfer();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error adding transfer to database");
            }
            finally
            {
                cn.Close();
            }
        }

        // Helper Function for insertIntoTable
        private void insertUserTransfer()
        {
            try
            {
                cmd.Parameters.Clear();
                cn.Open();

                cmd.CommandText = "INSERT INTO dbo.userTransfer (UserID,TransferID)" +
                    "VALUES (@1,@2)";
                cmd.Parameters.AddWithValue("@1", objDoc.senderID);      //ClaimID
                cmd.Parameters.AddWithValue("@2", objDoc.transferId); //Timestamp

                //Executing querry
                cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Problem inserting into the userTransfer table!");
            }
            finally
            {
                cn.Close();
            }
        }

        public void insertTransferDocs(int id, byte[] doc1, byte[] doc2)
        {
            try
            {
                // insert stuff into the claim details table
                // Clear parameters
                cmd.Parameters.Clear();
                // command to insert into the claimDetails table
                cmd.CommandText = "UPDATE dbo.docTransfer " +
                    "SET Document1 = @DOCONE, Document2 = @DOCTWO " +
                    "WHERE TransferId = @TID";
                cmd.Parameters.AddWithValue("@TID", id);
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
                MessageBox.Show(err.Message, "Warning! Could not save documents!");
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public void insertClaimImages(List<byte[]> uploadedImages, int transferId)
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
                    cmd.CommandText = "INSERT INTO dbo.docImages VALUES(@TID,@IID)";
                    cmd.Parameters.AddWithValue("@TID", transferId);
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
    }
}
