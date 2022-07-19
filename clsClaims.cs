using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;    // add this using directive for access to the sqlServer
using System.Windows.Forms;
using System.Drawing;           // Added for Bitmap functionality

namespace MyLoginForm
{
    public class clsClaims
    {
        public clsUser objUser;
        private clsClaimInformationDBH objDBH;

        public clsClaims(clsUser user)
        {
            objUser = user;
            // Setting up the database connection
            cn.ConnectionString = "Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";
            cmd.Connection = cn;
        }

        //constructor to help make a claim 
        public clsClaims(clsUser user, DateTime time, string iDate, string iTime, string loc, 
            string w, string v, string license, string s)
        {
            objUser = user;
            TimeStamp = time;
            DateOfIncident = iDate;
            TimeOfIncident = iTime;
            Location = loc;
            WeatherCondition = w;
            VehicleInvolved = v;
            LicensePlate = license;
            Status = s;
            // Setting up the database connection
            cn.ConnectionString = "Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";
            cmd.Connection = cn;
        }
        public clsClaims(int cid, DateTime time, string iDate, string iTime, string loc,
            string w, string v, string license, string s,int claimManager)
        {
            this.ClaimID = cid;
            this.TimeStamp = time;
            this.DateOfIncident = iDate;
            this.TimeOfIncident = iTime;
            this.Location = loc;
            this.WeatherCondition = w;
            this.VehicleInvolved = v;
            this.LicensePlate = license;
            this.Status = s;
            this.ClaimManagerID = claimManager;
            // Setting up the database connection
            cn.ConnectionString = "Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";
            cmd.Connection = cn;
        }

        //data that will be contained by this class
        public int ClaimID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string DateOfIncident { get; set; }
        public string TimeOfIncident { get; set; }
        public string Location { get; set; }
        public string WeatherCondition { get; set; }
        public string VehicleInvolved { get; set; }
        public string LicensePlate { get; set; }
        public string Status { get; set; }
        public int ClaimManagerID { get; set; }

        public void createClaim()
        {
            objDBH = new clsClaimInformationDBH(this, objUser);
            objDBH.insertClaim();
        }
        public void addClaimDetails(String s1, String s2, byte [] d1, byte[]d2)
        {
            objDBH = new clsClaimInformationDBH(this, objUser);
            objDBH.insertClaimDetails(this.ClaimID,s1, s2, d1, d2);
        }
        public void addImageDetails(List<byte[]> selectedImages)
        {
            objDBH.insertClaimImages(selectedImages, this.ClaimID);
        }

        public override string ToString()
        {
            return string.Format("ClaimID: {0}, Time Stamp: {1:d} {1:t}, Date: {2:d}, Time: {3:t}, Location: {4}, Weather: {5}, Vehicle: {6}, License: {7}, Status: {8}, Manager: {9}",
                ClaimID, TimeStamp, DateOfIncident, TimeOfIncident, Location, WeatherCondition, VehicleInvolved, LicensePlate, Status, ClaimManagerID);
        }

        //declare all necessary variables to read data from sql server
        private SqlConnection cn = new SqlConnection();
        private SqlCommand cmd = new SqlCommand();
    }

    

}
