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
    public partial class AdminGrantPrivForm : Form
    {

        private List<clsUser> users;
        private clsDBManager objDBManager;
        private clsUser objUser;
        private HomePage hPage;
        private AdminDashboardForm dash;


        //set the connection string to the database
        const string connectionString = @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";

        public AdminGrantPrivForm()
        {
            InitializeComponent();
        }

        public AdminGrantPrivForm(clsUser user, HomePage h)
        {
            objUser = user;
            hPage = h;
            InitializeComponent();
            user.getProfileInformation();
        }

        private void btnChangeRoles_Click_1(object sender, EventArgs e)
        {
            if (txtRole.Text == "CL" || txtRole.Text == "AD" || txtRole.Text == "CM" || txtRole.Text == "FM")
            {
                SqlConnection cn = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;

                try
                {
                    clsUser us = (clsUser)lstBoxUsers.SelectedItem;
                    {
                        string fn = lblFN.Text;
                        string ln = lblLN.Text;
                        int id = int.Parse(lblUID.Text);
                        string role = txtRole.Text;

                        //check to see if an Employee is selected in the listbox
                        if (lstBoxUsers.SelectedIndex >= 0) //means something is selected in the listbox
                        {
                            //get reference to the selected User from the listboxr
                            us.firstName = fn;
                            us.lastName = ln;
                            us.userId = id;
                            us.Role = role;

                            {

                                cn.ConnectionString = "Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";

                                cmd.CommandText = "UPDATE dbo.userProfile SET Role= '" + txtRole.Text + "'WHERE UserID = @useruserId";

                                cmd.Parameters.AddWithValue("@useruserId", us.userId);
                                cmd.Connection = cn;

                                //open a connection to DB
                                cn.Open();

                                //read the table
                                dr = cmd.ExecuteReader();

                                //read a record from the data reader
                                dr.Read();
                                //       return dr.GetString(0);
                            }
                        }

                        if (lstBoxUsers.SelectedItems.Count > 0)
                        {
                            // re-display the updated roster
                            lstBoxUsers.Items.Clear();
                            lstBoxUsers.Items.AddRange(users.ToArray());
                            MessageBox.Show("User " + us.firstName + " " + us.lastName + "'s role was successfully changed!");
                        }
                        else
                        {
                            MessageBox.Show("No user selected. Please select a user.");
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Warning!");
                }
            }
            else
                MessageBox.Show("Invalid user type. Please use CL, AD, CM, or FM. The user types need to be all uppercase.");
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            users = objDBManager.LoadDataFromDb();

            //clear previous content of the listbox
            lstBoxUsers.Items.Clear();
            //display all contents of the employees list in the listbox
            lstBoxUsers.Items.AddRange(users.ToArray());
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


        private void lstBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsUser us = (clsUser)lstBoxUsers.SelectedItem;
            lblFN.Text = us.firstName;
            lblLN.Text = us.lastName;
            lblUID.Text = us.userId.ToString();
            txtRole.Text = us.Role;
        }

        private void AdminGrantPrivForm_Load(object sender, EventArgs e)
        {
            users = new List<clsUser>(); //one-to-many association
            objDBManager = new clsDBManager(connectionString);

            users = objDBManager.LoadDataFromDb();

            //clear previous content of the listbox
            lstBoxUsers.Items.Clear();
            //display all contents of the employees list in the listbox
            lstBoxUsers.Items.AddRange(users.ToArray());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dash = new AdminDashboardForm(objUser, hPage);
            hPage.loadMainDisplay(dash);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valid Role types include CM, FM, AD, or CL: " + "CM - Claim Manager, " + "FM - Finance Manager, " + "AD - Administrator, " + "CL - Client");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
        
}