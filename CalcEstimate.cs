using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLoginForm
{
    public partial class CalcEstimate : Form
    {
        private clsUser objUser;
        private HomePage hPage;
        private clsClaims objClaim;
        private List<clsClaims> claims;
        private clsClaimInformationDBH objClaimDBH;
        private clsUserProfileDBH objUserDBH;
        private AdminDashboardForm ad;
        private ClaimReport report;
        private FMDashboardForm fm;
        private CMDashboardForm cm;

        // set the connection string to the database
        const string connectionString = @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";

        public CalcEstimate()
        {
            InitializeComponent();
        }

        public CalcEstimate(clsUser user, clsClaims claim, HomePage h)
        {
            objUser = user;
            hPage = h;
            objClaim = claim;
            InitializeComponent();

            claims = new List<clsClaims>();
            objClaimDBH = new clsClaimInformationDBH(connectionString);
        }

        private void CalcEstimate_Load(object sender, EventArgs e)
        {
            claims = new List<clsClaims>();
            objClaimDBH = new clsClaimInformationDBH(connectionString);

            claims = objClaimDBH.LoadAllClaims(datetimeSearchClaims.Checked, datetimeSearchClaims.Value);
            lstBoxClaims.Items.Clear(); //clear any current info
            lstBoxClaims.Items.AddRange(claims.ToArray()); //display items
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            claims = objClaimDBH.LoadAllClaims(datetimeSearchClaims.Checked, datetimeSearchClaims.Value);
            lstBoxClaims.Items.Clear(); //clear any current info
            lstBoxClaims.Items.AddRange(claims.ToArray()); //display items
        }

        private void lstBoxClaims_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxClaims.SelectedItems.Count > 0)
            {
                clsClaims selClaim = (clsClaims)lstBoxClaims.SelectedItem;
                int uid = objClaimDBH.GetUserID(selClaim.ClaimID);
                lblTime.Text = selClaim.TimeOfIncident;
                lblWeather.Text = selClaim.WeatherCondition;
                lblCar.Text = selClaim.VehicleInvolved;
                lblUser.Text = uid.ToString();
                lblCID.Text = selClaim.ClaimID.ToString();
                //    lblState.Text = us.state;
            }
            else
                MessageBox.Show("No claim selected.");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estimate cannot be calculated at this time.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
