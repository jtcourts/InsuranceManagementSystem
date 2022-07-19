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
    public partial class SettingsEditForm : Form
    {
        private SettingsForm settings;
        private clsUser objUser;
        private clsSettings objSet;
        private HomePage hPage;

        public SettingsEditForm()
        {
            InitializeComponent();
        }

        public SettingsEditForm(clsUser user)
        {
            objUser = user;
            InitializeComponent();
            this.LoadPage();
        }

        public void LoadPage() //this will populate the fields we know based on user info
        {
            txtPassword.Text = objUser.password;
            objSet = new clsSettings(objUser);
            if (!objSet.userExists())
                objSet.createSettings();
            objSet.getSettingsInformation();
            lblUserId2.Text = objUser.userId.ToString();


            txtCCN.Text = objSet.CCN;
            txtCCV.Text = objSet.PIN;
            txtExpDate.Text = objSet.Exp;
            txtCardName.Text = objSet.CardName;
        }

        public SettingsEditForm(clsUser user, SettingsForm back, HomePage h)
        {
            settings = back;
            objUser = user;
            hPage = h;
            InitializeComponent();
            this.LoadPage();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            hPage.loadMainDisplay(settings);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblUserId2.Text == "" || txtPassword.Text == "" || txtCCN.Text == "" || txtCCV.Text == "" || txtExpDate.Text == "" || txtCardName.Text == "")
                    MessageBox.Show("Please fill out all information.");
                else
                {
                    string[] d = { lblUserId2.Text,txtPassword.Text, txtCCN.Text, txtCCV.Text, txtExpDate.Text, txtCardName.Text};// sq1, sq2, txtSecAns1.Text, txtSecAns2.Text
                    objSet.updateSettings(d);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Updating User Settings");
                throw;
            }

            

            this.Close(); //hides the current edit form 
            settings.refresh(); //will populate profile with new user info
            hPage.loadMainDisplay(settings);
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            pnlPass.BackColor = Color.WhiteSmoke;

            pnlId.BackColor = Color.FromArgb(78, 184, 206);
            pnlCCN.BackColor = Color.FromArgb(78, 184, 206);
            pnlCardName.BackColor = Color.FromArgb(78, 184, 206);
            pnlCCV.BackColor = Color.FromArgb(78, 184, 206);
            pnlExp.BackColor = Color.FromArgb(78, 184, 206);
        }

        private void txtCCN_Click(object sender, EventArgs e)
        {
            pnlCCN.BackColor = Color.WhiteSmoke;

            pnlId.BackColor = Color.FromArgb(78, 184, 206);
            pnlPass.BackColor = Color.FromArgb(78, 184, 206);
            pnlCardName.BackColor = Color.FromArgb(78, 184, 206);
            pnlCCV.BackColor = Color.FromArgb(78, 184, 206);
            pnlExp.BackColor = Color.FromArgb(78, 184, 206);
       }

        private void txtCardName_Click(object sender, EventArgs e)
        {
            pnlCardName.BackColor = Color.WhiteSmoke;

            pnlId.BackColor = Color.FromArgb(78, 184, 206);
            pnlPass.BackColor = Color.FromArgb(78, 184, 206);
            pnlCCN.BackColor = Color.FromArgb(78, 184, 206);
            pnlCCV.BackColor = Color.FromArgb(78, 184, 206);
            pnlExp.BackColor = Color.FromArgb(78, 184, 206);
        }

        private void txtCCV_Click(object sender, EventArgs e)
        {
            pnlCCV.BackColor = Color.WhiteSmoke;

            pnlId.BackColor = Color.FromArgb(78, 184, 206);
            pnlPass.BackColor = Color.FromArgb(78, 184, 206);
            pnlCCN.BackColor = Color.FromArgb(78, 184, 206);
            pnlCardName.BackColor = Color.FromArgb(78, 184, 206);
            pnlExp.BackColor = Color.FromArgb(78, 184, 206);
        }

        private void txtExpDate_Click(object sender, EventArgs e)
        {
            pnlExp.BackColor = Color.WhiteSmoke;

            pnlId.BackColor = Color.FromArgb(78, 184, 206);
            pnlPass.BackColor = Color.FromArgb(78, 184, 206);
            pnlCCN.BackColor = Color.FromArgb(78, 184, 206);
            pnlCardName.BackColor = Color.FromArgb(78, 184, 206);
            pnlCCV.BackColor = Color.FromArgb(78, 184, 206);
        }

        private void lblUserId2_Click(object sender, EventArgs e)
        {
            pnlId.BackColor = Color.WhiteSmoke;

            pnlPass.BackColor = Color.FromArgb(78, 184, 206);
            pnlCCN.BackColor = Color.FromArgb(78, 184, 206);
            pnlCardName.BackColor = Color.FromArgb(78, 184, 206);
            pnlCCV.BackColor = Color.FromArgb(78, 184, 206);
            pnlExp.BackColor = Color.FromArgb(78, 184, 206);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRoleQuest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CCN show be 16 digits. Do not include spaces.");
        }
    }

}
