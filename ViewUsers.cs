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
    public partial class ViewUsers : Form
    {

        private clsUser objUser;
        private clsUserProfileDBH objProfile;
        private ProfileForm profile;
        private List<clsUser> users;
        private clsDBManager objDBManager;
        private HomePage hPage;
        public ViewUsers(clsUser user)
        {
            objUser = user;
            InitializeComponent();
            user.getProfileInformation();
        }
        public ViewUsers(clsUser user, HomePage h)
        {
            objUser = user;
            hPage = h;
            InitializeComponent();
            user.getProfileInformation();

        }
        const string connectionString = @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";

        private void ViewUsers_Load(object sender, EventArgs e)
        {
            users = new List<clsUser>(); //one-to-many association
            objDBManager = new clsDBManager(connectionString);

            users = objDBManager.LoadUsersFromDb();

            //clear previous content of the listbox
            lstBoxUsers.Items.Clear();
            //display all contents of the employees list in the listbox
            lstBoxUsers.Items.AddRange(users.ToArray());
        }

        private void lstBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsUser us = (clsUser)lstBoxUsers.SelectedItem;
            us.getProfileInfo();
            if (lstBoxUsers.SelectedItems.Count > 0)
            {
                lblId.Text = us.userId.ToString();
                lblRole.Text = us.Role;
                lblPhone.Text = us.phone.ToString();
                lblAddress.Text = us.address;
                lblFN.Text = us.firstName;
                lblLN.Text = us.lastName;
                lblMN.Text = us.middleName;
                lblState.Text = us.state;
                lblCity.Text = us.city;
                lblZip.Text = us.zip;
            }
            else
            {
                MessageBox.Show("No user selected.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
