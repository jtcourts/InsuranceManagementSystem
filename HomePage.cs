using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MyLoginForm
{
    public partial class HomePage : Form
    {
        LoginForm frmLogin;


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]    //Allows for the use of the CreateRoundRectRgn Function 
                                                                       //EntryPoint indicates the name of the DLL to be called

        private static extern IntPtr CreateRoundRectRgn
        (
            //Initializing all the variables to build the rounded corners

            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public HomePage()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;        //Setting it so there is no border then rounding the edges   
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
        }//defualt constructor 

        clsUser objUser;
        public HomePage(clsUser user)
        {
            objUser = user;
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;        //Setting it so there is no border then rounding the edges   
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
        }


        public void loadMainDisplay(object Form)
        {
            if(this.pnlMainDisplay.Controls.Count > 0)          //This will remove the previous form once 
                this.pnlMainDisplay.Controls.RemoveAt(0);       //another has been asked to be loaded. Removes the controls
            Form MainDisplay = Form as Form;                    //Create the formMainDisplay
            MainDisplay.TopLevel = false;                       //Create the form to make it a child form. 
            MainDisplay.Dock = DockStyle.Fill;                  //This docks the displayed form to all the edges, fills the panel completely
            this.pnlMainDisplay.Controls.Add(MainDisplay);      //A form control is added to the panels control collection
            this.pnlMainDisplay.Tag = MainDisplay;              
            MainDisplay.Show();                                 //Open and display the selected form on the panel.
        }

        public void loadDashBoard(clsUser objUser) //function to load correct dashboard upon login 
        {
            if (objUser.Role == "AD") //check admin priveleges
                loadMainDisplay(new AdminDashboardForm(objUser, this)); //load corresponding page
            else if (objUser.Role == "CL") //check client priveleges
                loadMainDisplay(new ClientDashboardForm(objUser, this)); //load corresponding page
            else if (objUser.Role == "CM") //check client priveleges
                loadMainDisplay(new CMDashboardForm(objUser, this)); //load corresponding page
            else if (objUser.Role == "FM") //check client priveleges
                loadMainDisplay(new FMDashboardForm(objUser, this)); //load corresponding page



            //loadMainDisplay(new AdminDashboardForm());               // Load dashboard form onto pnlMainDisplay

            //Panel Color Adjustment
            pnlDashboard.BackColor = Color.FromArgb(78, 184, 206);
            pnlClaims.BackColor = Color.FromArgb(34, 36, 49);
            pnlDocuments.BackColor = Color.FromArgb(34, 36, 49);
            pnlSchedule.BackColor = Color.FromArgb(34, 36, 49);
            pnlProfile.BackColor = Color.FromArgb(34, 36, 49);
            pnlMessages.BackColor = Color.FromArgb(34, 36, 49);
            pnlSettings.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (objUser.Role == "AD") //check admin priveleges
                loadMainDisplay(new AdminDashboardForm(objUser, this)); //load corresponding page
            else if (objUser.Role == "CL") //check client priveleges
                loadMainDisplay(new ClientDashboardForm(objUser, this)); //load corresponding page
            else if (objUser.Role == "CM") //check client priveleges
                loadMainDisplay(new CMDashboardForm(objUser, this)); //load corresponding page
            else if (objUser.Role == "FM") //check client priveleges
                loadMainDisplay(new FMDashboardForm(objUser, this)); //load corresponding page

            //Panel Color Adjustment
            pnlDashboard.BackColor = Color.FromArgb(78, 184, 206);
            pnlClaims.BackColor = Color.FromArgb(34, 36, 49);
            pnlDocuments.BackColor = Color.FromArgb(34, 36, 49);
            pnlSchedule.BackColor = Color.FromArgb(34, 36, 49);
            pnlProfile.BackColor = Color.FromArgb(34, 36, 49);
            pnlMessages.BackColor = Color.FromArgb(34, 36, 49);
            pnlSettings.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void btnClaims_Click(object sender, EventArgs e)
        {
            if(objUser.Role == "CL")
                loadMainDisplay(new FileClaim(objUser, this));               // Load claims form onto pnlMainDisplay
            else
                loadMainDisplay(new ViewClaims(objUser, this));
            //Panel Color Adjustment
            pnlDashboard.BackColor = Color.FromArgb(34, 36, 49);
            pnlClaims.BackColor = Color.FromArgb(78, 184, 206);
            pnlDocuments.BackColor = Color.FromArgb(34, 36, 49);
            pnlSchedule.BackColor = Color.FromArgb(34, 36, 49);
            pnlProfile.BackColor = Color.FromArgb(34, 36, 49);
            pnlMessages.BackColor = Color.FromArgb(34, 36, 49);
            pnlSettings.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            if (objUser.Role == "CL")
                loadMainDisplay(new ClientTransfer(objUser, this));               // Load claims form onto pnlMainDisplay
            else
                loadMainDisplay(new DocumentsForm());               // Load documents form onto pnlMainDisplay

            //Panel Color Adjustment
            pnlDashboard.BackColor = Color.FromArgb(34, 36, 49);
            pnlClaims.BackColor = Color.FromArgb(34, 36, 49);
            pnlDocuments.BackColor = Color.FromArgb(78, 184, 206);
            pnlSchedule.BackColor = Color.FromArgb(34, 36, 49);
            pnlProfile.BackColor = Color.FromArgb(34, 36, 49);
            pnlMessages.BackColor = Color.FromArgb(34, 36, 49);
            pnlSettings.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            loadMainDisplay(new ScheduleForm());               // Load schedule form onto pnlMainDisplay

            //Panel Color Adjustment
            pnlDashboard.BackColor = Color.FromArgb(34, 36, 49);
            pnlClaims.BackColor = Color.FromArgb(34, 36, 49);
            pnlDocuments.BackColor = Color.FromArgb(34, 36, 49);
            pnlSchedule.BackColor = Color.FromArgb(78, 184, 206);
            pnlProfile.BackColor = Color.FromArgb(34, 36, 49);
            pnlMessages.BackColor = Color.FromArgb(34, 36, 49);
            pnlSettings.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            loadMainDisplay(new ProfileForm(objUser,this));
            //Panel Color Adjustment
            pnlDashboard.BackColor = Color.FromArgb(34, 36, 49);
            pnlClaims.BackColor = Color.FromArgb(34, 36, 49);
            pnlDocuments.BackColor = Color.FromArgb(34, 36, 49);
            pnlSchedule.BackColor = Color.FromArgb(34, 36, 49);
            pnlProfile.BackColor = Color.FromArgb(78, 184, 206);
            pnlMessages.BackColor = Color.FromArgb(34, 36, 49);
            pnlSettings.BackColor = Color.FromArgb(34, 36, 49);

            
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            loadMainDisplay(new MessagesForm(objUser, this));               // Load messages form onto pnlMainDisplay

            //Panel Color Adjustment
            pnlDashboard.BackColor = Color.FromArgb(34, 36, 49);
            pnlClaims.BackColor = Color.FromArgb(34, 36, 49);
            pnlDocuments.BackColor = Color.FromArgb(34, 36, 49);
            pnlSchedule.BackColor = Color.FromArgb(34, 36, 49);
            pnlProfile.BackColor = Color.FromArgb(34, 36, 49);
            pnlMessages.BackColor = Color.FromArgb(78, 184, 206);
            pnlSettings.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            loadMainDisplay(new SettingsForm(objUser, this));               // Load settings form onto pnlMainDisplay

            //Panel Color Adjustment
            pnlDashboard.BackColor = Color.FromArgb(34, 36, 49);
            pnlClaims.BackColor = Color.FromArgb(34, 36, 49);
            pnlDocuments.BackColor = Color.FromArgb(34, 36, 49);
            pnlSchedule.BackColor = Color.FromArgb(34, 36, 49);
            pnlProfile.BackColor = Color.FromArgb(34, 36, 49);
            pnlMessages.BackColor = Color.FromArgb(34, 36, 49);
            pnlSettings.BackColor = Color.FromArgb(78, 184, 206);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //Return back to loginForm to log back in
            frmLogin = new LoginForm();

            this.Hide();                        // Hide the homePage form

            frmLogin.Show();                    // Open and display the LoginForm
        }

        // this is code to allow the user to drag and drop the window
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        private void pnlDragBar_MouseDown(object sender, MouseEventArgs e)
        {
            //Upon grabbing the pnlDragBar, your mouse functions will be disabled until you release
            //Learned this functionality through stackoverflow
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void HomePage_DragEnter(object sender, DragEventArgs e)
        {
            //When the form is being dragged, lower the opacity
            this.Opacity = 0.5;
        }

        private void HomePage_ResizeBegin(object sender, EventArgs e)
        {
            //When the form is resized/moved, lower the opacity
            this.Opacity = 0.5;
        }

        internal void btnProfile_Click()
        {
            throw new NotImplementedException();
        }

        private void HomePage_ResizeEnd(object sender, EventArgs e)
        {
            //When the form is finished being resized, return to original opacity
            this.Opacity = 1;
        }

    }
}
