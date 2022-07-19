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
    public partial class ViewClaims : Form
    {
        private clsUser objUser; //create a clsUser object
        private HomePage hPage;
        private List<clsClaims> claims;
        private clsClaimInformationDBH objClaimDBH;
        private AdminDashboardForm ad;
        private ClaimReport report;
        private FMDashboardForm fm;
        private CMDashboardForm cm;
        private ClientDashboardForm cl;

        // set the connection string to the database
        const string connectionString = @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";
        
        public ViewClaims()
        {
            InitializeComponent();
        }
        public ViewClaims(clsUser user, HomePage h)
        {
            objUser = user;
            hPage = h;
            InitializeComponent();
            
            claims = new List<clsClaims>();
            objClaimDBH = new clsClaimInformationDBH(connectionString,objUser);


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (objUser.Role == "AD") //check admin priveleges
            {
                ad = new AdminDashboardForm(objUser, hPage); //load corresponding page
                hPage.loadMainDisplay(ad);
            }
            else if (objUser.Role == "CM") //check cm priveleges
            {
                cm = new CMDashboardForm(objUser, hPage); //load corresponding page
                hPage.loadMainDisplay(cm);
            }
            else if (objUser.Role == "FM") //check fm priveleges
            {
                fm = new FMDashboardForm(objUser, hPage); //load corresponding page
                hPage.loadMainDisplay(fm);
            }
            else if (objUser.Role == "CL") //check client priveleges
            {
                cl = new ClientDashboardForm(objUser, hPage); //load corresponding page
                hPage.loadMainDisplay(cl);
            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstBoxClaims.SelectedItems.Count > 0)
            {
                clsClaims selClaim;
                selClaim =(clsClaims)lstBoxClaims.SelectedItem;
                report = new ClaimReport(selClaim,objUser);
                report.Show();
            }
            else
                MessageBox.Show("No claim selected.");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            claims = objClaimDBH.LoadAllClaims(datetimeSearchClaims.Checked, datetimeSearchClaims.Value, objUser);
            lstBoxClaims.Items.Clear(); //clear any current info
            lstBoxClaims.Items.AddRange(claims.ToArray()); //display items 
        }
        private void ViewClaims_Load(object sender, EventArgs e)
        { // moved these function from a load button to the page load because a load button seems redundant. feel free to change
            claims = new List<clsClaims>();

            claims = objClaimDBH.LoadAllClaims(datetimeSearchClaims.Checked, datetimeSearchClaims.Value, objUser);
            lstBoxClaims.Items.Clear(); //clear any current info
            lstBoxClaims.Items.AddRange(claims.ToArray()); //display items

            if (objUser.Role != "CM") //check user privileges
            {
                lblChange.Hide();
                rdlComplete.Hide();
                rdlProgress.Hide();
                btnChange.Hide();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            // If no claim is selected from the box then return with error message
            if(lstBoxClaims.SelectedIndex == -1)
            {
                MessageBox.Show("No claim was selected in the box. No changes could be made", "Error: No claim selected");
                return;
            }
            // If neither of the radio buttons are pushed then return with error message
            if(rdlProgress.Checked == false && rdlComplete.Checked == false)
            {
                MessageBox.Show("No new status was selected. Please select a status to change to.", "Error: No new status selected");
                return;
            }

            // Setting the status
            string newStatus = "Submitted";
            if (rdlProgress.Checked)
                newStatus = "In Progress";
            if (rdlComplete.Checked)
                newStatus = "Complete";

            // Getting the claim ID of the selected claim
            int selectedClaim = claims[lstBoxClaims.SelectedIndex].ClaimID;

            // new claimInformationDBH object
            objClaimDBH = new clsClaimInformationDBH();
            // Calling function to update the status
            objClaimDBH.updateStatus(selectedClaim, newStatus);
            // User Feedback
            MessageBox.Show("Claim " + selectedClaim.ToString() + " was successfully updated to have current " +
                "status of \"" + newStatus + "\". Please click \"Refresh\" to see the change in the list.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
