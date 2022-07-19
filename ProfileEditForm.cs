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
    public partial class ProfileEditForm : Form
    {
        private ProfileForm profile;
        private clsUser objUser;
        private HomePage hPage;
        public ProfileEditForm()
        {
            InitializeComponent();
        }
        //consructor that allows us to pass the profile page and user instance
        public ProfileEditForm(clsUser user, ProfileForm prof, HomePage h)
        {
            profile = prof;
            objUser = user;
            hPage = h;
            InitializeComponent();

            this.loadPage();
        }

        private void loadPage() //will populate all user info on the edit page 
        {
            txtBoxEmail.Text = objUser.getEmail();
            txtBoxFName.Text = objUser.firstName;
            txtBoxLName.Text = objUser.lastName;
            txtBoxPhone.Text = objUser.phone;
            txtBoxAddress.Text = objUser.address;
            txtBoxCity.Text = objUser.city;
            if (objUser.zip.ToString() == "0")
            {
                txtBoxZip.Text = "";
            }
            else
            {
                txtBoxZip.Text = objUser.zip;
            }
            if(objUser.state!="" && objUser.state!=null)
            { lstBoxState.SelectedItem = objUser.state; }
            txtBoxCountry.Text = "USA";
         
        }
    
        private void btnSave_Click(object sender, EventArgs e)
        {
            // email validation code
            string email = txtBoxEmail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            // phone number validation code
            string phonenumber = txtBoxPhone.Text;
            Regex phonevalid = new Regex(@"\d{10}");
            Match phonematch = phonevalid.Match(phonenumber);
            if (match.Success)
            {
                if (phonematch.Success && txtBoxPhone.Text.Length == 10)
                {
                    string state = lstBoxState.Text;
                    try
                    {
                        string[] d = {objUser.userId.ToString(),txtBoxPhone.Text,txtBoxAddress.Text, state,txtBoxCity.Text,
                    txtBoxZip.Text,txtBoxFName.Text,txtBoxLName.Text,""};
                        objUser.UpdateInfo(d); //calls user class function to update the table

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Error Updating User Information");
                        throw;
                    }

                    this.Close(); //hides the current edit form 
                    profile.refresh(); //will populate profile with new user info
                    hPage.loadMainDisplay(profile);
                }
                else
                    MessageBox.Show(phonenumber + " is invalid. Please make sure there are 10 numbers and do not include -. Format: #########");
            }
            else
                MessageBox.Show(email + " is Invalid Email Address");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();//hides edit form 
            hPage.loadMainDisplay(profile);
        }

        private void txtBoxFName_Click(object sender, EventArgs e)
        {
            pnlFN.BackColor = Color.WhiteSmoke;

            pnlLN.BackColor = Color.FromArgb(78, 184, 206);
            pnlEmail.BackColor = Color.FromArgb(78, 184, 206);
            pnlPhone.BackColor = Color.FromArgb(78, 184, 206);
            pnlAddress.BackColor = Color.FromArgb(78, 184, 206);
            pnlCity.BackColor = Color.FromArgb(78, 184, 206);
            pnlZip.BackColor = Color.FromArgb(78, 184, 206);
            pnlCountry.BackColor = Color.FromArgb(78, 184, 206);
        }

        private void txtBoxLName_Click(object sender, EventArgs e)
        {
            pnlLN.BackColor = Color.WhiteSmoke;

            pnlFN.BackColor = Color.FromArgb(78, 184, 206);
            pnlEmail.BackColor = Color.FromArgb(78, 184, 206);
            pnlPhone.BackColor = Color.FromArgb(78, 184, 206);
            pnlAddress.BackColor = Color.FromArgb(78, 184, 206);
            pnlCity.BackColor = Color.FromArgb(78, 184, 206);
            pnlZip.BackColor = Color.FromArgb(78, 184, 206);
            pnlCountry.BackColor = Color.FromArgb(78, 184, 206);
        }

        private void txtBoxEmail_Click(object sender, EventArgs e)
        {
            pnlEmail.BackColor = Color.WhiteSmoke;

            pnlFN.BackColor = Color.FromArgb(78, 184, 206);
            pnlLN.BackColor = Color.FromArgb(78, 184, 206);
            pnlPhone.BackColor = Color.FromArgb(78, 184, 206);
            pnlAddress.BackColor = Color.FromArgb(78, 184, 206);
            pnlCity.BackColor = Color.FromArgb(78, 184, 206);
            pnlZip.BackColor = Color.FromArgb(78, 184, 206);
            pnlCountry.BackColor = Color.FromArgb(78, 184, 206);
        }

        private void txtBoxPhone_Click(object sender, EventArgs e)
        {
            pnlPhone.BackColor = Color.WhiteSmoke;

            pnlFN.BackColor = Color.FromArgb(78, 184, 206);
            pnlLN.BackColor = Color.FromArgb(78, 184, 206);
            pnlEmail.BackColor = Color.FromArgb(78, 184, 206);
            pnlAddress.BackColor = Color.FromArgb(78, 184, 206);
            pnlCity.BackColor = Color.FromArgb(78, 184, 206);
            pnlZip.BackColor = Color.FromArgb(78, 184, 206);
            pnlCountry.BackColor = Color.FromArgb(78, 184, 206);
        }

        private void txtBoxAddress_Click(object sender, EventArgs e)
        {
            pnlAddress.BackColor = Color.WhiteSmoke;

            pnlFN.BackColor = Color.FromArgb(78, 184, 206);
            pnlLN.BackColor = Color.FromArgb(78, 184, 206);
            pnlEmail.BackColor = Color.FromArgb(78, 184, 206);
            pnlPhone.BackColor = Color.FromArgb(78, 184, 206);
            pnlCity.BackColor = Color.FromArgb(78, 184, 206);
            pnlZip.BackColor = Color.FromArgb(78, 184, 206);
            pnlCountry.BackColor = Color.FromArgb(78, 184, 206);
        }

        private void txtBoxCity_Click(object sender, EventArgs e)
        {
            pnlCity.BackColor = Color.WhiteSmoke;

            pnlFN.BackColor = Color.FromArgb(78, 184, 206);
            pnlLN.BackColor = Color.FromArgb(78, 184, 206);
            pnlEmail.BackColor = Color.FromArgb(78, 184, 206);
            pnlPhone.BackColor = Color.FromArgb(78, 184, 206);
            pnlAddress.BackColor = Color.FromArgb(78, 184, 206);
            pnlZip.BackColor = Color.FromArgb(78, 184, 206);
            pnlCountry.BackColor = Color.FromArgb(78, 184, 206);
        }

        private void txtBoxZip_Click(object sender, EventArgs e)
        {
            pnlZip.BackColor = Color.WhiteSmoke;

            pnlFN.BackColor = Color.FromArgb(78, 184, 206);
            pnlLN.BackColor = Color.FromArgb(78, 184, 206);
            pnlEmail.BackColor = Color.FromArgb(78, 184, 206);
            pnlPhone.BackColor = Color.FromArgb(78, 184, 206);
            pnlAddress.BackColor = Color.FromArgb(78, 184, 206);
            pnlCity.BackColor = Color.FromArgb(78, 184, 206);
            pnlCountry.BackColor = Color.FromArgb(78, 184, 206);
        }

        private void txtBoxCountry_Click(object sender, EventArgs e)
        {
            pnlCountry.BackColor = Color.WhiteSmoke;

            pnlFN.BackColor = Color.FromArgb(78, 184, 206);
            pnlLN.BackColor = Color.FromArgb(78, 184, 206);
            pnlEmail.BackColor = Color.FromArgb(78, 184, 206);
            pnlPhone.BackColor = Color.FromArgb(78, 184, 206);
            pnlAddress.BackColor = Color.FromArgb(78, 184, 206);
            pnlCity.BackColor = Color.FromArgb(78, 184, 206);
            pnlZip.BackColor = Color.FromArgb(78, 184, 206);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
