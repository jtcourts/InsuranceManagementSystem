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
    public partial class registerForm : Form
    {
        LoginForm frmLogin;
        ClientDashboardForm clientdash;
        HomePage homePage;
        clsUser objUser;

        int countFirstName = 0;
        int countLastName = 0;
        int countUsername = 0;
        int countPassword = 0;
        int countConfirmPassword = 0;


        public registerForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close the application upon clicking the X
            Application.Exit();
        }
        private void txtFirstName_Click(object sender, EventArgs e)
        {
            //Color, Text, and Image Adjustments
            if (countFirstName == 0)
            {
                txtFirstName.Clear();
                countFirstName++;
            }

            picFirstName.BackgroundImage = Properties.Resources.name_4;
            pnlFirstName.BackColor = Color.FromArgb(78, 184, 206);
            txtFirstName.ForeColor = Color.FromArgb(78, 184, 206);

            picLastName.BackgroundImage = Properties.Resources.name_3;
            pnlLastName.BackColor = Color.WhiteSmoke;
            txtLastName.ForeColor = Color.WhiteSmoke;

            picUsername.BackgroundImage = Properties.Resources.user_1;
            pnlUsername.BackColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;

            picPassword.BackgroundImage = Properties.Resources.lock_1;
            pnlPassword.BackColor = Color.WhiteSmoke;
            txtPassword.ForeColor = Color.WhiteSmoke;

            picConfirmPassword.BackgroundImage = Properties.Resources.lock_1;
            pnlConfirmPassword.BackColor = Color.WhiteSmoke;
            txtConfirmPassword.ForeColor = Color.WhiteSmoke;
        }

        private void txtLastName_Click(object sender, EventArgs e)
        {
            //Color, Text, and Image Adjustments
            if (countLastName == 0)
            {
                txtLastName.Clear();
                countLastName++;
            }

            picLastName.BackgroundImage = Properties.Resources.name_4;
            pnlLastName.BackColor = Color.FromArgb(78, 184, 206);
            txtLastName.ForeColor = Color.FromArgb(78, 184, 206);

            picFirstName.BackgroundImage = Properties.Resources.name_1;
            pnlFirstName.BackColor = Color.WhiteSmoke;
            txtFirstName.ForeColor = Color.WhiteSmoke;

            picUsername.BackgroundImage = Properties.Resources.user_1;
            pnlUsername.BackColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;

            picPassword.BackgroundImage = Properties.Resources.lock_1;
            pnlPassword.BackColor = Color.WhiteSmoke;
            txtPassword.ForeColor = Color.WhiteSmoke;

            picConfirmPassword.BackgroundImage = Properties.Resources.lock_1;
            pnlConfirmPassword.BackColor = Color.WhiteSmoke;
            txtConfirmPassword.ForeColor = Color.WhiteSmoke;
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

            picFirstName.BackgroundImage = Properties.Resources.name_1;
            pnlFirstName.BackColor = Color.WhiteSmoke;
            txtFirstName.ForeColor = Color.WhiteSmoke;

            picLastName.BackgroundImage = Properties.Resources.name_3;
            pnlLastName.BackColor = Color.WhiteSmoke;
            txtLastName.ForeColor = Color.WhiteSmoke;

            picPassword.BackgroundImage = Properties.Resources.lock_1;
            pnlPassword.BackColor = Color.WhiteSmoke;
            txtPassword.ForeColor = Color.WhiteSmoke;

            picConfirmPassword.BackgroundImage = Properties.Resources.lock_1;
            pnlConfirmPassword.BackColor = Color.WhiteSmoke;
            txtConfirmPassword.ForeColor = Color.WhiteSmoke;
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

            picFirstName.BackgroundImage = Properties.Resources.name_1;
            pnlFirstName.BackColor = Color.WhiteSmoke;
            txtFirstName.ForeColor = Color.WhiteSmoke;

            picLastName.BackgroundImage = Properties.Resources.name_3;
            pnlLastName.BackColor = Color.WhiteSmoke;
            txtLastName.ForeColor = Color.WhiteSmoke;

            picUsername.BackgroundImage = Properties.Resources.user_1;
            pnlUsername.BackColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;

            picConfirmPassword.BackgroundImage = Properties.Resources.lock_1;
            pnlConfirmPassword.BackColor = Color.WhiteSmoke;
            txtConfirmPassword.ForeColor = Color.WhiteSmoke;
        }

        private void txtConfirmPassword_Click(object sender, EventArgs e)
        {
            //Color, Text, and Image Adjustments
            if (countConfirmPassword == 0)
            {
                txtConfirmPassword.Clear();
                countConfirmPassword++;
            }
            txtConfirmPassword.PasswordChar = '●';

            picConfirmPassword.BackgroundImage = Properties.Resources.lock_2;
            pnlConfirmPassword.BackColor = Color.FromArgb(78, 184, 206);
            txtConfirmPassword.ForeColor = Color.FromArgb(78, 184, 206);

            picFirstName.BackgroundImage = Properties.Resources.name_1;
            pnlFirstName.BackColor = Color.WhiteSmoke;
            txtFirstName.ForeColor = Color.WhiteSmoke;

            picLastName.BackgroundImage = Properties.Resources.name_3;
            pnlLastName.BackColor = Color.WhiteSmoke;
            txtLastName.ForeColor = Color.WhiteSmoke;

            picUsername.BackgroundImage = Properties.Resources.user_1;
            pnlUsername.BackColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;

            picPassword.BackgroundImage = Properties.Resources.lock_1;
            pnlPassword.BackColor = Color.WhiteSmoke;
            txtPassword.ForeColor = Color.WhiteSmoke;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || txtPassword.Text != txtConfirmPassword.Text)
            {
                if (txtFirstName.Text == "")
                    pnlFirstName.BackColor = Color.Red;

                if (txtLastName.Text == "")
                    pnlLastName.BackColor = Color.Red;

                if (txtUsername.Text == "")
                    pnlUsername.BackColor = Color.Red;

                if (txtPassword.Text == "")
                    pnlPassword.BackColor = Color.Red;

                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    pnlConfirmPassword.BackColor = Color.Red;
                    txtConfirmPassword.Clear();
                }
            }
            else
            {
                string email = txtUsername.Text;
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);
                if (match.Success)
                {
                    try
                    {
                        objUser = new clsUser(txtFirstName.Text, txtLastName.Text, txtUsername.Text, txtPassword.Text);

                        if (objUser.registerUser())
                        {
                            homePage = new HomePage(objUser);
                            clientdash = new ClientDashboardForm(objUser, this, homePage);
                            homePage.Show();  // Open and display the WelcomeForm
                            this.Hide();
                           
                            homePage.loadMainDisplay(clientdash);

                            MessageBox.Show("Registration Successful. Please enter your contact information on the 'Profile' page!");
                            this.Hide();    // Hide the registration form
                        }

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                else
                    MessageBox.Show(email + " is Invalid Email Address");
            }
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

        private void picSeeConfirmedPassword_Click(object sender, EventArgs e)
        {
            //Checking to see if the text are letteres/circles. Change accordingly
            if (txtConfirmPassword.PasswordChar == '●')
            {
                picSeeConfirmPassword.BackgroundImage = Properties.Resources.Eye_2;
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                picSeeConfirmPassword.BackgroundImage = Properties.Resources.Eye_1;
                txtConfirmPassword.PasswordChar = '●';
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //Load login form page and hide registration
            frmLogin = new LoginForm();

            this.Hide();    // Hide the registration form

            frmLogin.Show();  // Open and display the LoginForm
        }

        // this is code to allow the user to drag and drop the window
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        private void pnlDragBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        } 

        private void registerForm_DragEnter(object sender, DragEventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void registerForm_ResizeBegin(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void registerForm_ResizeEnd(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }
    }
}
