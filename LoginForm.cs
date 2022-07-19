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
using System.Text.RegularExpressions;

namespace MyLoginForm
{
    public partial class LoginForm : Form
    {
        // Declare Home Page Variable
        HomePage homePage;

        // Declare RegisterForm Variable
        registerForm frmRegister;

        clsUser objUser;

        private string email = string.Empty;
        private string password = string.Empty;

        //Clear Text Fields Counter
        int countUsername = 0;
        int countPassword = 0;

        public string Email
        {
            get { return email; }   // get method
            set { email = value; }  // set method
        }

        public string Password
        {
            get { return password; }   // get method
            set { password = value; }  // set method
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close the application upon clicking the X
            Application.Exit();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string email = txtUsername.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                string enteredPassword = txtPassword.Text;
                string enteredUsername = txtUsername.Text;

                try
                {
                    objUser = new clsUser(enteredUsername, enteredPassword);

                    //find valid password for given user from the database
                    if (objUser.checkPassword())
                    {
                        this.DialogResult = DialogResult.OK; //tells form ok button has been selected

                        homePage = new HomePage(objUser);

                        email = enteredUsername;
                        password = enteredPassword;
                        objUser.getProfileInformation(); //do this here to load all necessary user info
                        homePage.loadDashBoard(objUser); //load the dashboard corresponding to the correct user 
                        homePage.Show();  // Open and display the WelcomeForm
                        this.Hide();    // Hide the login form


                        //need to figure out load main display funtionality and close functionality
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password, Please try again!");
                        pnlUsername.BackColor = Color.FromArgb(170, 30, 30);
                        pnlPassword.BackColor = Color.FromArgb(170, 30, 30);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Warning!");
                }
            }
            else
                MessageBox.Show(email + " is Invalid Email Address");
        }
        
        private void txtUsername_Click(object sender, EventArgs e)
        {
            //Color, Text, and Image Adjustments
            if (countUsername == 0)
            {
                txtUsername.Clear();
                countUsername++;
            }

            picUsername.BackgroundImage = Properties.Resources.user_2;
            pnlUsername.BackColor = Color.FromArgb(78, 184, 206);
            txtUsername.ForeColor = Color.FromArgb(78, 184, 206);

            picPassword.BackgroundImage = Properties.Resources.lock_1;
            pnlPassword.BackColor = Color.WhiteSmoke;
            txtPassword.ForeColor = Color.WhiteSmoke;
        }
        
        private void txtPassword_Click(object sender, EventArgs e)
        {
            //Color, Text, and Image Adjustments
            if (countPassword == 0)
            {
                txtPassword.Clear();
                countPassword++;
            }

            txtPassword.PasswordChar = '●';
            picPassword.BackgroundImage = Properties.Resources.lock_2;
            pnlPassword.BackColor = Color.FromArgb(78, 184, 206);
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);

            picUsername.BackgroundImage = Properties.Resources.user_1;
            pnlUsername.BackColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Load the register form

            frmRegister = new registerForm();

            this.Hide();        // Hide the login form

            frmRegister.Show();  // Open and display the RegisterForm
        }

        private void picSeePassword_Click(object sender, EventArgs e)
        {
            //Checking to see if the text are letteres/circles. Change accordingly
            if (txtPassword.PasswordChar == '●')
            {
                picSeePassword.BackgroundImage = Properties.Resources.Eye_2;
                txtPassword.PasswordChar = '\0'; 
            }
            else
            {
                picSeePassword.BackgroundImage = Properties.Resources.Eye_1;
                txtPassword.PasswordChar = '●';
            }

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

        private void LoginForm_DragEnter(object sender, DragEventArgs e)
        {
            //When the form is being dragged, lower the opacity
            this.Opacity = 0.5;
        }

        private void LoginForm_ResizeBegin(object sender, EventArgs e)
        {
            //When the form is resized/moved, lower the opacity
            this.Opacity = 0.5;
        }

        private void LoginForm_ResizeEnd(object sender, EventArgs e)
        {
            //When the form is finished being resized, return to original opacity
            this.Opacity = 1;
        }
    }
}
