using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;    // add this using directive for access to the sqlServer
using System.Windows.Forms;

namespace MyLoginForm
{
    class clsDocuments
    {
        private clsDocumentsDBH objDBH;
        public clsUser objUser;
        private SqlConnection cn = new SqlConnection();
        private SqlCommand cmd = new SqlCommand();

        public clsDocuments(clsUser user)
        {
            objUser = user;
            // Setting up the database connection
            cn.ConnectionString = "Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";
            cmd.Connection = cn;
        }

        public clsDocuments(clsUser user, int id, string e, string fn, string ln, string role)
        {
            objUser = user;
            userId = id;
            username = e;
            firstName = fn;
            lastName = ln;

            cn.ConnectionString = "Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";
            cmd.Connection = cn;
        }

        public string username { get; set; }
        public int userId { get; set; }
        public string Role { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public byte[] document1 { get; set; }
        public byte[] document2 { get; set; }
        public int transferId { get; set; }
        public int recieveId { get; set; }
        public int senderID { get; set; }

        public override string ToString()
        {
            return string.Format("User ID: {0}, Name: {1} {2}, Role: {3}", userId, firstName, lastName, Role);
        }

        public void createTransfer()
        {
            objDBH = new clsDocumentsDBH(this, objUser);
            objDBH.insertTransfer();
        } 

        public void addTransferDocs(byte[] d1, byte[] d2)
        {
            objDBH = new clsDocumentsDBH(this, objUser);
            objDBH.insertTransferDocs(this.transferId, d1, d2);
        }

        public void addImageDetails(List<byte[]> selectedImages)
        {
            objDBH.insertClaimImages(selectedImages, this.transferId);
        }
    }
}
