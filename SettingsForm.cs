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
    public partial class SettingsForm : Form
    {
        private clsUser objUser;
        private clsSettings objSet;
        private HomePage hPage;
        private SettingsEditForm change;

        public SettingsForm()
        {
            InitializeComponent();
        }

        public SettingsForm(clsUser user)
        {
            objUser = user;
            InitializeComponent();
        }

        public SettingsForm(clsUser user, HomePage h)
        {
            objUser = user;
            hPage = h;
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            change = new SettingsEditForm(objUser, this, hPage);
            hPage.loadMainDisplay(change);
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            txtPassword.Text = objUser.password;
            txtPassword.PasswordChar = '●';
            objSet = new clsSettings(objUser);
            if(!objSet.userExists())
                objSet.createSettings();
            objSet.getSettingsInformation();

            lblUserId2.Text = objUser.userId.ToString();
            txtCCN.Text = objSet.CCN;
            txtCCN.PasswordChar = '●';
            lblCardName.Text = objSet.CardName;
            txtCCV.Text = objSet.PIN;
            txtCCV.PasswordChar = '●';
            lblExpDate.Text = objSet.Exp;
        }

        public void refresh()
        {
            txtPassword.Text = objUser.password;
            txtPassword.PasswordChar = '●';
            lblUserId2.Text = objUser.userId.ToString();
            objSet.getSettingsInformation();
            txtCCN.Text = objSet.CCN;
            txtCCN.PasswordChar = '●';
            lblCardName.Text = objSet.CardName;
            txtCCV.Text = objSet.PIN;
            txtCCV.PasswordChar = '●';
            lblExpDate.Text = objSet.Exp;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
