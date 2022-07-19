using System;
using System.Windows.Forms;

namespace MyLoginForm
{
    public partial class ProfileForm : Form
    {

        private clsUser objUser;
        private ProfileEditForm edit;
        private HomePage hPage;

        public ProfileForm()
        {
            InitializeComponent();
        }
        public ProfileForm(clsUser user)
        {
            objUser = user;
            InitializeComponent();
            user.getProfileInformation();
        }
        public ProfileForm(clsUser user, HomePage h)
        {
            objUser = user;
            hPage = h;
            InitializeComponent();
            user.getProfileInformation();

        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            lblEmail.Text = objUser.username;
            lblFName.Text = objUser.firstName;
            lblLName.Text = objUser.lastName;
            lblPhone.Text = objUser.phone;
            lblAddress.Text = objUser.address;
             lblCity.Text = objUser.city;
            if (objUser.zip.ToString() == "0")
            {
                lblZip.Text = "";
            }
            else
            {
                lblZip.Text = objUser.zip;
            }
            lblState.Text = objUser.state;
            lblCountry.Text = "USA";
        }

        public void refresh()
        {
            lblEmail.Text = objUser.getEmail();
            lblFName.Text = objUser.firstName;
            lblLName.Text = objUser.lastName;
            lblPhone.Text = objUser.phone.ToString();
            lblAddress.Text = objUser.address;
            lblCity.Text = objUser.city;
            if(objUser.zip.ToString() == "0")
            {
                lblZip.Text = "";
            }
            else
            {
                lblZip.Text = objUser.zip;
            }
            lblState.Text = objUser.state;
            lblCountry.Text = "USA";

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            edit = new ProfileEditForm(objUser,this, hPage);
            hPage.loadMainDisplay(edit);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
