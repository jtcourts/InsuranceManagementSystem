using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    // add this using directive for access to the sqlServer
using System.Runtime.InteropServices;   //DllImport

namespace MyLoginForm
{
    public partial class AdminDashboardForm : Form
    {
        private clsUser objUser;
        private HomePage hPage;
        private SettingsForm settings;
        private MessagesForm messages;
        private ViewUsers view;
        private DocumentsForm documents;
        private ScheduleForm schedule;
        private AdminGrantPrivForm grant;

        //set the connection string to the database
        const string connectionString = @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        public AdminDashboardForm(clsUser user, HomePage h)
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
            view = new ViewUsers(objUser, hPage);
            hPage.loadMainDisplay(view);

            //Panel Color Adjustment
            hPage.pnlDashboard.BackColor = Color.FromArgb(34, 36, 49);
            hPage.pnlClaims.BackColor = Color.FromArgb(78, 184, 206);
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            documents = new DocumentsForm(objUser, hPage);
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
            grant = new AdminGrantPrivForm(objUser, hPage);
            hPage.loadMainDisplay(grant);

            //Panel Color Adjustment
            hPage.pnlDashboard.BackColor = Color.FromArgb(34, 36, 49);
            hPage.pnlProfile.BackColor = Color.FromArgb(78, 184, 206);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            lblName.Text = objUser.firstName + " " + objUser.lastName;

            switch (objUser.Role)
            {
                case "CL":
                    lblRole.Text = "Client";
                    break;
                case "CM":
                    lblRole.Text = "Claim Manager";
                    break;
                case "FM":
                    lblRole.Text = "Finance Manager";
                    break;
                case "AD":
                    lblRole.Text = "Admin";
                    break;
            }
        }
    }
}