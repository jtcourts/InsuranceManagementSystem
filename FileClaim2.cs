using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace MyLoginForm
{
    public partial class FileClaim2 : Form
    {
        private clsClaims objClaim;

        private FileClaim back;
        private HomePage hPage;

        private List <byte[]> selectedImages = new List<byte[]>();

        private byte[] b1 = Array.Empty<byte>();
        private byte[] b2 = Array.Empty<byte>();

        public bool Multiselect { get; set; }

        public FileClaim2()
        {
            InitializeComponent();
        }

        public FileClaim2(clsClaims claim, FileClaim fileForm1, HomePage h) //this is temp fix 
        {
            objClaim = claim;
            back = fileForm1;
            hPage = h;

            InitializeComponent();
        }

        private void addDescriptions()
        {
            String s1 = txtDamages.Text;
            String s2 = txtIncident.Text;

            try
            {
                objClaim.addClaimDetails(s1, s2, b1, b2);
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message, "Unable to Upload Documents at this time.");
            }
            
        }
        private void addImages()
        {
            objClaim.addImageDetails(selectedImages);
        }


        private void btnFileClaim_Click(object sender, EventArgs e)
        {
            if (txtDamages.Text == "" || txtIncident.Text == "")
            {
                if (txtDamages.Text == "")
                    lblDamages.ForeColor = Color.Red;
                else lblDamages.ForeColor = Color.FromArgb(78, 184, 206); ;

                if (txtIncident.Text == "")
                    lblIncident.ForeColor = Color.Red;
                else lblIncident.ForeColor = Color.FromArgb(78, 184, 206); ;
            }
            else
            {
                try
                { 
                    try
                    {
                        objClaim.createClaim();
                        MessageBox.Show("Your Claim Was Successfully Filed!");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Unable to file Claim at this time.");
                    }

                    this.addDescriptions(); //let's try to add the documents
                    this.addImages();       //try to upload the images

                    this.Close();
                    //save info to database then clear
                    txtIncident.Clear();
                    txtDamages.Clear();
                    lblFile.ResetText();
                    lblFile2.ResetText();

                    //back.Refresh();

                    hPage.loadMainDisplay(back);



                }
                catch (Exception)
                {

                    throw;
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
                    b1 = bytes;
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
                    b2 = bytes;
                }
            }
        }

        private void FileClaim2_Load(object sender, EventArgs e)
        {
            InitializeOpenFileDialog(); 
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

        private void btnFileOpen_Click(object sender, EventArgs e)
        { //uploads images only -- could be used for pictures of damages vehicles
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Read the files
                foreach (String file in openFileDialog1.FileNames)
                {
                    // Create a PictureBox and add image to list of images
                    try
                    {
                        // creating the picture box
                        PictureBox pb = new PictureBox();
                        Image loadedImage = Image.FromFile(file);
                        pb.SizeMode = PictureBoxSizeMode.Zoom;
                        pb.Height = 128;
                        pb.Width = 128;
                        pb.Image = loadedImage;
                        flowLayoutPanel1.Controls.Add(pb);
                        // adding to list of images
                        // converting the string to a fileInfo object to get extention to be able to check file type
                        FileInfo fileInfo = new FileInfo(file);
                        using (var stream = new MemoryStream())
                        {
                            if(fileInfo.Extension == ".jpg")
                                loadedImage.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);      //jpeg uploaded
                            if(fileInfo.Extension == ".bmp")
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
                            "Details (send to Support):\n\n" + ex.StackTrace
                        );
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            hPage.loadMainDisplay(back);  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This section is for including police reports or accident reports in your claim.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This section is for including police reports or accident reports in your claim.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This section is for including images of the car damages in your claim.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
