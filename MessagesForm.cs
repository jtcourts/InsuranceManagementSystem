using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLoginForm
{
    public partial class MessagesForm : Form
    {
        private clsUser objUser; //create a clsUser object
        private HomePage hPage;
        private clsMessages objMessage;
        private List<string> recipients; 

        //Clear chat field 
        int countTextChat = 0;
        int countTextUser = 0;

        public MessagesForm()
        {
            InitializeComponent();
        }

        public MessagesForm(clsUser user, HomePage h)
        {
            objUser = user;
            hPage = h;
            InitializeComponent();
            objMessage = new clsMessages(objUser);
            recipients = objMessage.getRecipients();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNewUserChat_Click(object sender, EventArgs e)
        {
            if(countTextUser == 0)
            {
                txtNewUserChat.Clear();
                countTextUser++;
            }
        }

        private void MessagesForm_Load(object sender, EventArgs e)
        {
            recipients = objMessage.getRecipients();
            if (recipients.Count >= 1)
            {
               btnUserInfo1.Text = recipients[0];
            }
            if(recipients.Count >= 2)
            {
                btnUserInfo2.Text = recipients[1];
            }
            if (recipients.Count >= 3)
            {
                btnUserInfo3.Text = recipients[2];
            }
            if (recipients.Count >= 4)
            {
                btnUserInfo4.Text = recipients[3];
            }
            if (recipients.Count >= 5)
            {
                btnUserInfo5.Text = recipients[4];
            }
            if (recipients.Count >= 6)
            {
                btnUserInfo6.Text = recipients[5];
            }
            if (recipients.Count >= 7)
            {
                btnUserInfo7.Text = recipients[6];
            }
        }

        private void btnUserInfo1_Click(object sender, EventArgs e)
        {
            if (btnUserInfo1.Text == "")
            {
                MessageBox.Show("This chat box is empty, try another one or create a new chat.");
            }
            else
            {
                txtCurrentUserInfo.Text = btnUserInfo1.Text;

                btnUserInfo1.FlatAppearance.BorderColor = Color.FromArgb(78, 184, 206);

                btnUserInfo2.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo3.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo4.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo5.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo6.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo7.FlatAppearance.BorderColor = Color.WhiteSmoke;

                //Display messages
                displayMessages();
            }
        }

        private void btnUserInfo2_Click(object sender, EventArgs e)
        {
            if (btnUserInfo2.Text == "")
            {
                MessageBox.Show("This chat box is empty, try another one or create a new chat.");
            }
            else
            {
                txtCurrentUserInfo.Text = btnUserInfo2.Text;

                btnUserInfo2.FlatAppearance.BorderColor = Color.FromArgb(78, 184, 206);

                btnUserInfo1.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo3.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo4.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo5.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo6.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo7.FlatAppearance.BorderColor = Color.WhiteSmoke;

                //Display messages
                displayMessages();
            }
        }

        private void btnUserInfo3_Click(object sender, EventArgs e)
        {
            if (btnUserInfo3.Text == "")
            {
                MessageBox.Show("This chat box is empty, try another one or create a new chat.");
            }
            else
            {
                txtCurrentUserInfo.Text = btnUserInfo3.Text;

                btnUserInfo3.FlatAppearance.BorderColor = Color.FromArgb(78, 184, 206);

                btnUserInfo1.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo2.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo4.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo5.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo6.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo7.FlatAppearance.BorderColor = Color.WhiteSmoke;

                //Display messages
                displayMessages();
            }
        }

        private void btnUserInfo4_Click(object sender, EventArgs e)
        {
            if (btnUserInfo4.Text == "")
            {
                MessageBox.Show("This chat box is empty, try another one or create a new chat.");
            }
            else
            {
                txtCurrentUserInfo.Text = btnUserInfo4.Text;

                btnUserInfo4.FlatAppearance.BorderColor = Color.FromArgb(78, 184, 206);

                btnUserInfo1.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo2.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo3.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo5.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo6.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo7.FlatAppearance.BorderColor = Color.WhiteSmoke;

                //Display messages
                displayMessages();
            }
        }

        private void btnUserInfo5_Click(object sender, EventArgs e)
        {
            if (btnUserInfo5.Text == "")
            {
                MessageBox.Show("This chat box is empty, try another one or create a new chat.");
            }
            else
            {
                txtCurrentUserInfo.Text = btnUserInfo5.Text;

                btnUserInfo5.FlatAppearance.BorderColor = Color.FromArgb(78, 184, 206);

                btnUserInfo1.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo2.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo3.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo4.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo6.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo7.FlatAppearance.BorderColor = Color.WhiteSmoke;

                //Display messages
                displayMessages();
            }
        }

        private void btnUserInfo6_Click(object sender, EventArgs e)
        {

            if (btnUserInfo6.Text == "")
            {
                MessageBox.Show("This chat box is empty, try another one or create a new chat.");
            }
            else
            {
                txtCurrentUserInfo.Text = btnUserInfo6.Text;

                btnUserInfo6.FlatAppearance.BorderColor = Color.FromArgb(78, 184, 206);

                btnUserInfo1.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo2.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo3.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo4.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo5.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo7.FlatAppearance.BorderColor = Color.WhiteSmoke;


                //Display messages
                displayMessages();
            }
        }

        private void btnUserInfo7_Click(object sender, EventArgs e)
        {
            if(btnUserInfo7.Text == "")
            {
                MessageBox.Show("This chat box is empty, try another one or create a new chat.");
            }
            else
            {
                txtCurrentUserInfo.Text = btnUserInfo7.Text;

                btnUserInfo7.FlatAppearance.BorderColor = Color.FromArgb(78, 184, 206);

                btnUserInfo1.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo2.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo3.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo4.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo5.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnUserInfo6.FlatAppearance.BorderColor = Color.WhiteSmoke;

                //Display messages
                displayMessages();
            }
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            //Validate that the user exists and is not already in the chat list
            clsMessages objMessage;
            objMessage = new clsMessages(objUser);

            if(objMessage.validateReceiver(txtNewUserChat.Text) >0 && txtNewUserChat.Text != btnUserInfo7.Text && txtNewUserChat.Text != btnUserInfo6.Text &&
                txtNewUserChat.Text != btnUserInfo5.Text && txtNewUserChat.Text != btnUserInfo4.Text && txtNewUserChat.Text != btnUserInfo3.Text &&
                txtNewUserChat.Text != btnUserInfo2.Text && txtNewUserChat.Text != btnUserInfo1.Text)
            {
                // Shift the User Chat List accordingly and remove the last user
                btnUserInfo7.Text = btnUserInfo6.Text;
                btnUserInfo6.Text = btnUserInfo5.Text;
                btnUserInfo5.Text = btnUserInfo4.Text;
                btnUserInfo4.Text = btnUserInfo3.Text;
                btnUserInfo3.Text = btnUserInfo2.Text;
                btnUserInfo2.Text = btnUserInfo1.Text;

                // Add the user into the chat list
                btnUserInfo1.Text = txtNewUserChat.Text;


                txtCurrentUserInfo.Text = txtNewUserChat.Text;
            }
        }

        private void displayMessages()
        {
            //now we need to get messages so we can fill
            int rid = objMessage.validateReceiver(txtCurrentUserInfo.Text);
            clsMessagesDBH objDBH;
            List<clsMessages> m = new List< clsMessages > ();
            objDBH = new clsMessagesDBH(objUser, objMessage);
            m = objDBH.getMessages(rid);

            flpDisplayMessages.Controls.Clear();

            // Create a userControl for message contents?
            for (int i = 1; i <= m.Count; i++)
            {
                if(m.Count >=i)
                {
                    UserControlMessages UCMsg = new UserControlMessages(this);
                    UCMsg.messages(m[i-1].SenderID,m[i-1].TimeStamp,m[i-1].MessageContents);
                    flpDisplayMessages.Controls.Add(UCMsg);
      
                }
            }
        }
        
        private void picSendMessage_Click(object sender, EventArgs e)
        {
            if (txtMessageBox.Text != "")
            {
                //Here is where we will send a message
                //To send a message we need the message contents and a receiver
                clsMessages objMessage;
                objMessage = new clsMessages(objUser); //first we have to create message
                try
                {
                    objMessage.sendMessage(txtMessageBox.Text, txtCurrentUserInfo.Text);
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message, "Error sending message ");
                }
                //Now we want to refresh messages to show that it sent.... 

                this.displayMessages();

                txtMessageBox.Clear();
            }
            else
                MessageBox.Show("Unable to send message: No message entered.");
        }

        private void picClearMessage_Click(object sender, EventArgs e)
        {
            txtMessageBox.Clear();
        }

        private void txtMessageBox_Click(object sender, EventArgs e)
        {
            if (countTextChat == 0)
            {
                txtMessageBox.Clear();
                countTextChat++;
            }
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            displayMessages();
        }
    }
}
