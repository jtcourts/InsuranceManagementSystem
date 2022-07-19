using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;    // add this using directive for access to the sqlServer
using System.Windows.Forms;
using System.Drawing;           // Added for Bitmap functionality
using Windows.Data.Pdf;

namespace MyLoginForm
{
    
    public class clsClaimDetails
    {
        public clsUser objUser;
        private clsClaimInformationDBH objDBH;
        private clsClaims objClaim;

        //declare all necessary variables to read data from sql server
        private SqlConnection cn = new SqlConnection();
        private SqlCommand cmd = new SqlCommand();
        private SqlDataReader reader;

        public clsClaimDetails(clsUser user, clsClaims claim)
        {
            objUser = user;
            objClaim = claim;
            // Setting up the database connection
            cn.ConnectionString = "Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";
            cmd.Connection = cn;
        }

        public int ClaimID { get; set; }
        public string DescriptionOfDamage { get; set; }
        public string DescriptionOfIncident { get; set; }

        //here is where we can store the documents and images 
        public byte[] Document1 { get; set; }
        public byte[] Document2 { get; set; }

        public List<byte[]> images = new List<byte[]>();
        public void getDescriptions()
        {
            objDBH = new clsClaimInformationDBH(objClaim, objUser,this);
            objDBH.GetclaimDescriptions();
        }
        public void getImages()
        {
            List<int> imageIDs = new List<int>();
            try
            {
                cmd.Parameters.Clear();
                // getting the image ids associated with the specific claim
                cmd.CommandText = "SELECT ImageID FROM dbo.claimImages WHERE ClaimID = @CLAIMID";
                cmd.Parameters.AddWithValue("@CLAIMID", objClaim.ClaimID);
                // open the connection
                cn.Open();
                // read
                reader = cmd.ExecuteReader();
                //Adding an int to the image id list for each result found
                while (reader.Read())
                {
                    imageIDs.Add((int)reader["ImageID"]);
                }
                reader.Close();
                // for each image id found, get the image ID and store it in the byte[] list
                foreach (int i in imageIDs)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "SELECT Image FROM dbo.Images WHERE ImageID = @IMAGEID";
                    cmd.Parameters.AddWithValue("@IMAGEID", i);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    byte[] image = (byte[])reader["Image"];
                    images.Add(image);
                    reader.Close();
                }
                cn.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("No images found for this claim.");
              //  throw;
            }
        }
        
        public void getDocuments()
        {
            try
            {
                // clearing the paramters
                cmd.Parameters.Clear();
                // getting the two documents
                cmd.CommandText = "SELECT Document1, Document2 FROM dbo.claimDetails WHERE ClaimID = @CLAIMID";
                cmd.Parameters.AddWithValue("@CLAIMID", objClaim.ClaimID);
                // open the reader
                cn.Open();
                // set the reader and read the reader
                reader = cmd.ExecuteReader();
                reader.Read();
                // setting the documents
                Document1 = (byte[])reader["Document1"];
                Document2 = (byte[])reader["Document2"];
                // Close reader and connection
                reader.Close();
                cn.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("No documents found for this claim.");
                //throw;
            } 
        }

    }
}
