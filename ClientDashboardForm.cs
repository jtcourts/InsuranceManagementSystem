using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLoginForm
{
    public partial class ClientDashboardForm : Form
    {
        private clsUser objUser;
        private HomePage hPage;

        SettingsForm settings;
        ProfileForm profile;
        MessagesForm messages;
        FileClaim claims;
        ClientTransfer documents;
        ScheduleForm schedule;
        registerForm register;
        ViewClaims view;

        public ClientDashboardForm()
        {
            InitializeComponent();
        }

        public ClientDashboardForm(clsUser user, registerForm reg, HomePage h)
        {
            register = reg;
            objUser = user;
            hPage = h;

            InitializeComponent();
        }

        public ClientDashboardForm(clsUser user, HomePage h)
        {
            objUser = user;
            hPage = h;
            InitializeComponent();
            user.getProfileInformation();

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            settings = new SettingsForm(objUser, hPage);
            hPage.loadMainDisplay(settings);

            //Panel Color Adjustment
            hPage.pnlDashboard.BackColor = Color.FromArgb(34, 36, 49);
            hPage.pnlSettings.BackColor = Color.FromArgb(78, 184, 206);
        }

        private void btnClaims_Click(object sender, EventArgs e)
        {
            view = new ViewClaims(objUser, hPage);
            hPage.loadMainDisplay(view);

            //Panel Color Adjustment
            hPage.pnlDashboard.BackColor = Color.FromArgb(34, 36, 49);
            hPage.pnlClaims.BackColor = Color.FromArgb(78, 184, 206);
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            documents = new ClientTransfer(objUser, hPage);
            hPage.loadMainDisplay(documents);

            //Panel Color Adjustment
            hPage.pnlDashboard.BackColor = Color.FromArgb(34, 36, 49);
            hPage.pnlDocuments.BackColor = Color.FromArgb(78, 184, 206);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            schedule = new ScheduleForm(objUser, hPage);
            hPage.loadMainDisplay(schedule);

            //Panel Color Adjustment
            hPage.pnlDashboard.BackColor = Color.FromArgb(34, 36, 49);
            hPage.pnlSchedule.BackColor = Color.FromArgb(78, 184, 206);
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            messages = new MessagesForm(objUser, hPage);
            hPage.loadMainDisplay(messages);

            //Panel Color Adjustment
            hPage.pnlDashboard.BackColor = Color.FromArgb(34, 36, 49);
            hPage.pnlMessages.BackColor = Color.FromArgb(78, 184, 206);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            profile = new ProfileForm(objUser, hPage);
            hPage.loadMainDisplay(profile);

            //Panel Color Adjustment
            hPage.pnlDashboard.BackColor = Color.FromArgb(34, 36, 49);
            hPage.pnlProfile.BackColor = Color.FromArgb(78, 184, 206);
        }

        private void ClientDashboardForm_Load(object sender, EventArgs e)
        {
            lblName.Text = objUser.firstName + " " + objUser.lastName;
            
            switch(objUser.Role)
            {
                case "CL":
                    lblRole.Text = "Client";
                    break;
                case "CM":
                    lblRole.Text = "Client Manager";
                    break;
                case "FM":
                    lblRole.Text = "Finance Manager";
                    break;
                case "AD":
                    lblRole.Text = "Admin";
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
