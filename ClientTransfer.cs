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
    public partial class ClientTransfer : Form
    {
        private HomePage hPage;
        private List<clsUser> users;
        private clsDBManager objDBManager;
        private clsDocuments objDoc;
        clsUser objUser;

        const string connectionString = @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";

        private byte[] d1 = Array.Empty<byte>();
        private byte[] d2 = Array.Empty<byte>();
        private List<byte[]> selectedImages = new List<byte[]>();

        int countEmail = 0;

        public ClientTransfer()
        {
            InitializeComponent();
        }

        public ClientTransfer(clsUser user, HomePage h)
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

        private void ClientTransfer_Load(object sender, EventArgs e)
        {
            InitializeOpenFileDialog(); ;
            users = new List<clsUser>(); //one-to-many association
            objDBManager = new clsDBManager(connectionString);
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
                        // adding to list of images
                        // converting the string to a fileInfo object to get extention to be able to check file type
                        FileInfo fileInfo = new FileInfo(file);
                        using (var stream = new MemoryStream())
                        {
                            if (fileInfo.Extension == ".jpg")
                                loadedImage.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);      //jpeg uploaded
                            if (fileInfo.Extension == ".bmp")
                                loadedImage.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);       //bmp upload
                            // adding the stream array to the list of byte arrays
                            selectedImages.Add(stream.ToArray());
                        }
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
          // string path2;
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
            if (lstBoxUsers.SelectedIndex != -1)
            {
                if (lblFile.Text == "" && lblFile2.Text == "" && flowLayoutPanel1.Controls.Count == 0)
                    MessageBox.Show("Transfer Failed: No files are selected.");
                else
                {
                    try
                    {
                        // Creating a new document object with selected user from list box
                        objDoc = new clsDocuments(users[lstBoxUsers.SelectedIndex]);

                        // Creating a transfer in the object
                        objDoc.senderID = objUser.userId;
                        objDoc.createTransfer();
                        objDoc.addTransferDocs(d1, d2);
                        objDoc.addImageDetails(selectedImages);

                        // Clear the fields
                        lblFile.ResetText();
                        lblFile2.ResetText();
                        flowLayoutPanel1.Refresh();

                        // Letting user know that the files were sent to selected recipient
                        MessageBox.Show("Files successfully sent to " + txtRecipient.Text);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Error transfering documents to user");
                    }
                }
            }
            else
                MessageBox.Show("No email selected");
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
            users = objDBManager.ClientLoadDataFromDb();

            //clear previous content of the listbox
            lstBoxUsers.Items.Clear();
            //display all contents of the employees list in the listbox
            lstBoxUsers.Items.AddRange(users.ToArray());
        }

        private void lstBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsUser us = (clsUser)lstBoxUsers.SelectedItem;

            txtRecipient.Text = us.firstName + " " + us.lastName;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
