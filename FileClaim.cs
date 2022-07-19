using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLoginForm
{
    public partial class FileClaim : Form
    {
        // private ProfileForm profile;
        
        private clsUser objUser; //create a clsUser object
        private HomePage hPage;
        private FileClaim2 next;
        private clsClaims objClaim;

        public FileClaim()
        {
            InitializeComponent();
        }

        public FileClaim(clsUser user, HomePage h)
        {
            objUser = user;
            hPage = h;
            InitializeComponent();
            user.getProfileInformation();
            this.LoadPage();
        }

        public FileClaim(clsUser user)
        {
            objUser = user; //set objUser equal to the user we passed in 
            InitializeComponent();
            user.getProfileInformation(); //not sure if we still need to call this? 
            this.LoadPage();
        }
        public void LoadPage() //this will populate the fields we know based on user info
        {
            lblFName.Text = objUser.firstName;
            lblLName.Text = objUser.lastName;
            lblUser.Text = objUser.userId.ToString();
            lblAddress.Text = objUser.address;
            lblCity.Text = objUser.city;
            lblState.Text = objUser.state;
            lblZip.Text = objUser.zip;
            lblCountry.Text = "USA";
            lblPhone.Text = objUser.phone;
            DTPIncidentDate.ResetText();
            DTPIncidentTime.ResetText();
        }
        
        private void FileClaim_Load(object sender, EventArgs e)
        {

        }

        private void btnFileClaim_Click(object sender, EventArgs e)
        {
            if (txtLocation.Text == "" || txtPlate.Text == "" || txtVehicle.Text == "" || comboBoxWeather.Text == "")
            {
                if (txtLocation.Text == "")
                {
                    pnlLoc.BackColor = Color.Red;
                    lblLocation.ForeColor = Color.Red;
                }
                else
                {
                    pnlLoc.BackColor = Color.FromArgb(78, 184, 206);
                    lblLocation.ForeColor = Color.FromArgb(78, 184, 206);
                }

                if (txtPlate.Text == "")
                {
                    pnlLicense.BackColor = Color.Red;
                    lblPlate.ForeColor = Color.Red;
                }
                else
                {
                    pnlLicense.BackColor = Color.FromArgb(78, 184, 206);
                    lblPlate.ForeColor = Color.FromArgb(78, 184, 206);
                }

                if (txtVehicle.Text == "")
                {
                    pnlVehicle.BackColor = Color.Red;
                    lblVehicle.ForeColor = Color.Red;
                }
                else
                {
                    pnlVehicle.BackColor = Color.FromArgb(78, 184, 206);
                    lblVehicle.ForeColor = Color.FromArgb(78, 184, 206);
                }

                if (comboBoxWeather.Text == "")
                    lblWeather.ForeColor = Color.Red;
                else lblWeather.ForeColor = Color.FromArgb(78, 184, 206);
            }
            else
            {
                try
                {
                    // getting current time in utc to be able to accurately describe which claims were "first"
                    DateTime timestamp = DateTime.UtcNow;
                    DateTime dt = DTPIncidentDate.Value.Date;


                    // creating the claim object
                    objClaim = new clsClaims(objUser, timestamp, DTPIncidentDate.Value.Date.ToString("dd/MM/yyyy"), DTPIncidentTime.Text,
                        txtLocation.Text, comboBoxWeather.SelectedItem.ToString(), txtVehicle.Text, txtPlate.Text, "Submitted");

                    next = new FileClaim2(objClaim, this, hPage); //pass this form as a parameter to fileClaim2 form 

                    //save info to database then clear
                    txtLocation.Clear();
                    comboBoxWeather.ResetText();
                    txtVehicle.Clear();
                    txtPlate.Clear();

                    hPage.loadMainDisplay(next);

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void txtLocation_Click(object sender, EventArgs e)
        {
            pnlLoc.BackColor = Color.WhiteSmoke;

            pnlVehicle.BackColor = Color.FromArgb(78, 184, 206);
            pnlLicense.BackColor = Color.FromArgb(78, 184, 206);
        }

        private void txtVehicle_Click(object sender, EventArgs e)
        {
            pnlVehicle.BackColor = Color.WhiteSmoke;

            pnlLoc.BackColor = Color.FromArgb(78, 184, 206);
            pnlLicense.BackColor = Color.FromArgb(78, 184, 206);
        }

        private void txtPlate_Click(object sender, EventArgs e)
        {
            pnlLicense.BackColor = Color.WhiteSmoke;

            pnlLoc.BackColor = Color.FromArgb(78, 184, 206);
            pnlVehicle.BackColor = Color.FromArgb(78, 184, 206);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
