using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLoginForm
{
    public partial class DocumentsForm : Form
    {
        //   private clsDocuments objUserD; //create a clsUser object
        private HomePage hPage;
        private List<clsUser> users;
        private clsDBManager objDBManager;
        clsUser objUser;
        private clsDocuments objDoc;

        private List<byte[]> selectedImages = new List<byte[]>();

        private byte[] d1 = Array.Empty<byte>();
        private byte[] d2 = Array.Empty<byte>();

        const string connectionString = @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";


        int countEmail = 0;

        public DocumentsForm()
        {
            InitializeComponent();
        }

        public DocumentsForm(clsUser user, HomePage h)
        {
            objUser = user;
            hPage = h;
            InitializeComponent();
            user.getProfileInformation();
        }

        private void InitializeOpenFileDialog()
        {
            // Set the file dialog to filter for graphics files.
            this.openFileDialog1.Filter =
                "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
                "All files (*.*)|*.*";

            // Allow the user to select multiple images.
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "My Image Browser";
        }

        private void DocumentsForm_Load(object sender, EventArgs e)
        {
            InitializeOpenFileDialog();
            users = new List<clsUser>(); //one-to-many association
            objDBManager = new clsDBManager(connectionString);

            users = objDBManager.LoadDataFromDb();

            //clear previous content of the listbox
            lstBoxUsers.Items.Clear();
            //display all contents of the employees list in the listbox
            lstBoxUsers.Items.AddRange(users.ToArray());
        }

        private void btnFileOpen_Click(object sender, EventArgs e)
        {
            //uploads images only -- could be used for pictures of damages vehicles
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Read the files
                foreach (String file in openFileDialog1.FileNames)
                {
                    // Create a PictureBox.
                    try
                    {
                        PictureBox pb = new PictureBox();
                        Image loadedImage = Image.FromFile(file);
                        pb.Height = loadedImage.Height;
                        pb.Width = loadedImage.Width;
                        pb.Image = loadedImage;
                        flowLayoutPanel1.Controls.Add(pb);
                    }
                    catch (SecurityException ex)
                    {
                        // The user lacks appropriate permissions to read files, discover paths, etc.
                        MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                            "Error message: " + ex.Message + "\n\n" +
                            "Details (send to Support):\n\n" + ex.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        // Could not load the image -- probably related to Windows file system permissions.
                        MessageBox.Show("Cannot display the image: " + file.Substring(file.LastIndexOf('\\'))
                            + ". You may not have permission to read the file, or " +
                            "it may be corrupt.\n\nReported error: " + ex.Message);
                    }
                }
            }

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {  //uploads documents only -- could be used for uploading police/accident reports
           //upload document 1
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "All files (*.*)|*.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                lblFile.Text = Path.GetFileName(file.FileName);
                using (FileStream fs = new FileStream(Path.GetFullPath(file.FileName), FileMode.Open, FileAccess.Read))
                {
                    byte[] bytes = new byte[fs.Length];
                    int numBytesToRead = (int)fs.Length;
                    int numBytesRead = 0;
                    while (numBytesToRead > 0)
                    {
                        // Read may return anything from 0 to numBytesToRead.
                        int n = fs.Read(bytes, numBytesRead, numBytesToRead);

                        // Break when the end of the file is reached.
                        if (n == 0)
                        {
                            break;
                        }

                        numBytesRead += n;
                        numBytesToRead -= n;
                    }
                    numBytesToRead = bytes.Length;
                    d1 = bytes;
                }

            }
        }

        private void btnUpload2_Click(object sender, EventArgs e)
        { //uploads documents only -- could be used for uploading police/accident reports
          //upload document 2
            OpenFileDialog file2 = new OpenFileDialog();
            if (file2.ShowDialog() == DialogResult.OK)
            {
                lblFile2.Text = Path.GetFileName(file2.FileName);
                using (FileStream fs = new FileStream(Path.GetFullPath(file2.FileName), FileMode.Open, FileAccess.Read))
                {
                    byte[] bytes = new byte[fs.Length];
                    int numBytesToRead = (int)fs.Length;
                    int numBytesRead = 0;
                    while (numBytesToRead > 0)
                    {
                        // Read may return anything from 0 to numBytesToRead.
                        int n = fs.Read(bytes, numBytesRead, numBytesToRead);

                        // Break when the end of the file is reached.
                        if (n == 0)
                        {
                            break;
                        }

                        numBytesRead += n;
                        numBytesToRead -= n;
                    }
                    numBytesToRead = bytes.Length;
                    d2 = bytes;
                }
            }
        }

        private void btnDocs_Click(object sender, EventArgs e)
        {
            
                if (lblFile.Text == "" && lblFile2.Text == "" && flowLayoutPanel1.Controls.Count == 0)
                    MessageBox.Show("Transfer Failed: No files are selected.");
                else
                {
                    try
                    {
                        try
                        {
                          //  int Recipient = Int16Converter(txtRecipient.Text);
                            clsUser us = (clsUser)lstBoxUsers.SelectedItem;
                            objDoc = new clsDocuments(us);
                            objDoc.recieveId = us.userId;

                            objDoc.createTransfer();
                            MessageBox.Show("Your Documents Were Successfully Transferred!");
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show(err.Message, "Unable to file Claim at this time.");
                        }

                        this.addImages();       //try to upload the images

                    //save info to database then clear
                    lblFile.ResetText();
                    lblFile2.ResetText();
                    flowLayoutPanel1.Controls.Clear();
                    txtRecipient.ResetText();
                }
                    catch (Exception)
                    {
                        throw;
                    }
              
                }
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (countEmail == 0)
            {
                txtRecipient.Clear();
                countEmail++;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            users = objDBManager.LoadDataFromDb();

            //clear previous content of the listbox
            lstBoxUsers.Items.Clear();
            //display all contents of the employees list in the listbox
            lstBoxUsers.Items.AddRange(users.ToArray());
        }

        private void lstBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsUser us = (clsUser)lstBoxUsers.SelectedItem;

            txtRecipient.Text = us.firstName + " " + us.lastName;
            //could send through user ID instead of email becuase email can't be accessed from userProfile table
        }

        private void addImages()
        {
            objDoc.addImageDetails(selectedImages);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
