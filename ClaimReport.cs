using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Storage;

namespace MyLoginForm
{
    public partial class ClaimReport : Form
    {
        private clsClaims objClaim;
        private clsUser objUser;
        private clsClaimInformationDBH objClaimDBH;
        private clsClaimDetails objClaimDetails;
        private const string connectionString = @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";
        public ClaimReport()
        {
            InitializeComponent();
        }        

        public ClaimReport(clsClaims claim, clsUser user)
        {
            objClaim = claim;
            objUser = user;
            objClaimDBH = new clsClaimInformationDBH(connectionString);
            InitializeComponent();
        }

        public void refresh()
        {
            lblIncident.Text = objClaim.DateOfIncident;
            lblLoc.Text = objClaim.Location;
            lblTime.Text = objClaim.TimeOfIncident;
            lblWeather.Text = objClaim.WeatherCondition;
            lblVehicle.Text = objClaim.VehicleInvolved;
            lblPlate.Text = objClaim.LicensePlate;
            lblStatus.Text = objClaim.Status;
            lblTimestamp.Text = objClaim.TimeStamp.ToString();
            lblManID.Text = objClaim.ClaimManagerID.ToString();
            lblId.Text = objClaimDBH.GetUserID(objClaim.ClaimID).ToString();
        }

        // this is code to allow the user to drag and drop the window
        private void ClaimReport_Load(object sender, EventArgs e)
        {
            lblIncident.Text = objClaim.DateOfIncident;
            lblLoc.Text = objClaim.Location;
            lblTime.Text = objClaim.TimeOfIncident;
            lblWeather.Text = objClaim.WeatherCondition;
            lblVehicle.Text = objClaim.VehicleInvolved;
            lblPlate.Text = objClaim.LicensePlate;
            lblStatus.Text = objClaim.Status;
            lblTimestamp.Text = objClaim.TimeStamp.ToString();
            lblManID.Text = objClaim.ClaimManagerID.ToString();
            lblId.Text = objClaimDBH.GetUserID(objClaim.ClaimID).ToString();

            //create instance of claim details so we can view descriptions, images, and documents
            objClaimDetails = new clsClaimDetails(objUser, objClaim);
            objClaimDetails.getDescriptions();
            objClaimDetails.getImages();
            objClaimDetails.getDocuments();
            lblDamDesc.Text = objClaimDetails.DescriptionOfDamage;
            lblIncDesc.Text = objClaimDetails.DescriptionOfIncident;
            foreach(byte[] imageData in objClaimDetails.images)
            {
                PictureBox pb = new PictureBox();
                MemoryStream ms = new MemoryStream(imageData);
                Image loadedImage = new Bitmap(ms);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Height = 128;
                pb.Width = 128;
                pb.Image = loadedImage;
                flpImage.Controls.Add(pb);
            }

            if (objUser.Role == "FM" || objUser.Role == "AD") //check user privileges
            {
                btnDwnld.Hide();
            }


            //get user's name...but first ID
            int uid = objClaimDBH.GetUserID(objClaim.ClaimID);
            //create instance of user so we can get name 
            //now we have user ID ... we will need this to get first name...
            //Let's make a temp user
            clsUser tempUser;
            tempUser = new clsUser(uid);
            tempUser.getProfileInformation2();
            //concatenate string so whole name can be in one box 
            string temp = tempUser.firstName + " " + tempUser.lastName;
            //print the name
            lblName.Text = temp;      
        }

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

        private void ClaimReport_DragEnter(object sender, DragEventArgs e)
        {
            //When the form is being dragged, lower the opacity
            this.Opacity = 0.5;
        }

        private void ClaimReport_ResizeBegin(object sender, EventArgs e)
        {
            //When the form is resized/moved, lower the opacity
            this.Opacity = 0.5;
        }

        private void ClaimReport_ResizeEnd(object sender, EventArgs e)
        {
            //When the form is finished being resized, return to original opacity
            this.Opacity = 1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDwnld_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                // saveFileDialog for the user to select a location to save the file
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;
                // Setting the default name
                saveFileDialog.FileName = string.Format("ClaimReport{0}.txt", objClaim.ClaimID);


                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    using (StreamWriter report = new StreamWriter(Path.GetFullPath(saveFileDialog.FileName), false, Encoding.Default))
                    {

                        report.WriteLine(lblName.Text + "'s Claim Report");
                        report.WriteLine();
                        report.WriteLine();
                        report.WriteLine("Client:" + lblName.Text);
                        report.WriteLine("User ID: " + lblId.Text);
                        report.WriteLine("Manager ID: " + lblManID.Text);
                        report.WriteLine("Time Filed:" + lblTimestamp.Text);
                        report.WriteLine("Claim Status: " + lblStatus.Text);
                        report.WriteLine();
                        report.WriteLine("Incident Location:" + lblLoc.Text);
                        report.WriteLine("Date of Incident: " + lblIncident.Text);
                        report.WriteLine("Time of Incident: " + lblTime.Text);
                        report.WriteLine("Vehicle Involved: " + lblVehicle.Text);
                        report.WriteLine("Weather Condition: " + lblWeather.Text);
                        report.WriteLine("License Plate: " + lblPlate.Text);
                        report.WriteLine();
                        report.WriteLine("Incident Description: " + lblIncDesc.Text);
                        report.WriteLine("Damage Description: " + lblDamDesc.Text);
                    }                    
                }
                MessageBox.Show(lblName.Text + "'s claim report was downloaded successfully!");
            }
            catch { MessageBox.Show("Download failed"); }   
        }

        private void btnDownloadDoc1_Click(object sender, EventArgs e)
        {
            // testArrary to use when checking the document array to see if its empty
            byte[] testArray = Array.Empty<byte>();
            // If there user did not upload document 1
            if (Enumerable.SequenceEqual(objClaimDetails.Document1,testArray))
            {
                MessageBox.Show("User did not upload this document!", "No Document 1 uploaded");
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // saveFileDialog for the user to select a location to save the file
            saveFileDialog.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            // Setting the default name
            saveFileDialog.FileName = string.Format("Doc1Claim{0}.pdf", objClaim.ClaimID);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream file = File.Create(Path.GetFullPath(saveFileDialog.FileName)))
                {
                    file.Write(objClaimDetails.Document1, 0, objClaimDetails.Document1.Length);
                }
            }
        }

        private void btnDownloadDoc2_Click(object sender, EventArgs e)
        {
            // testArrary to use when checking the document array to see if its empty
            byte[] testArray = Array.Empty<byte>();
            // If the user did not upload something for document 2
            if(Enumerable.SequenceEqual(objClaimDetails.Document2,testArray))
            {
                MessageBox.Show("User did not upload this document!", "No Document 2 uploaded");
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // saveFileDialog for the user to select a location to save the file
            saveFileDialog.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            
            // Setting the default name
            saveFileDialog.FileName = string.Format("Doc2Claim{0}.pdf", objClaim.ClaimID);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                using (FileStream file = File.Create(Path.GetFullPath(saveFileDialog.FileName)))
                {
                    file.Write(objClaimDetails.Document2, 0, objClaimDetails.Document2.Length);
                }

            }
        }
    }
    
}
