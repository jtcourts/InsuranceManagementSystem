using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyLoginForm
{
    public class clsMessages
    {
        clsUser objUser;
        clsMessagesDBH objMessageDBH;
        public clsMessages()
        {

        }

        public clsMessages(clsUser user)
        {
            objUser = user;
            SenderID = user.userId;
            Read = 0;
        }

        public clsMessages (int m, int s, int r, string mc, DateTime d, int read, clsUser user)
        {
            MessageID = m;
            SenderID = s;
            ReceiverID = r;
            MessageContents = mc;
            TimeStamp = d;
            Read = r;
            objUser = user;
        }
        //here is our data
        public int MessageID { get; set; }
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public string MessageContents { get; set; }
        public DateTime TimeStamp { get; set; }
        public int Read { get; set; }

        //Public Methods
        //Send a Message
        public void sendMessage(string m, string name)
        {
            MessageContents = m;
            objMessageDBH = new clsMessagesDBH(objUser, this);
            this.GetDate();
            try
            {
                ReceiverID = this.validateReceiver(name);
                if(ReceiverID > 0)
                {
                    //add row to table call function in DBH
                    string[] empty = new string[0];
                    objMessageDBH.insertIntoTable(empty); //this should insert message
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message, "Problem Sending Message "); 
            }

        }

        public int validateReceiver (string n)
        {
            int rid = -1;

            try
            {
                string[] words = n.Split(' ');
                rid = this.getRID(words);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Please enter a First and Last name");
                //throw;
            }

            ReceiverID = rid;
            return rid;
        }

        //Get ReciverID
        private int getRID(string [] name)
        {
            int rid = -1;
            clsUser temp = new clsUser();
            temp.firstName = name[0];
            temp.lastName = name[1];
            try
            {
                rid = temp.getIDGivenNames();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error getting Receiver ID ");
            }
            return rid;
        }
        //Get currentTime 
        private void GetDate()
        {
            TimeStamp = DateTime.Now;
        }

        //Display messages in the chat panel
        public List<clsMessages> DisplayMessage()
        {
            List<clsMessages> mlist; 
            objMessageDBH = new clsMessagesDBH(objUser, this);
            mlist = objMessageDBH.getMessages(ReceiverID);
            return mlist;
        }

        public List<string> getRecipients()
        {
            List<string> recips = new List<string>();
            List<int> rids = new List<int>();
            objMessageDBH = new clsMessagesDBH(objUser, this);
            rids = objMessageDBH.getRids();
            foreach (int id in rids)
            {
                if(id >0)
                {
                    clsUser temp = new clsUser();
                    temp.userId = id;
                    try
                    {
                        temp.getProfileInfo();
                        string tempname = temp.firstName + " " + temp.lastName;
                        recips.Add(tempname);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Problem getting recipient name");
                    }
                }
                else
                {
                    recips.Add("");
                }
            }
            return recips; 

        }

        public void DeleteMessage()
        {
            objMessageDBH = new clsMessagesDBH(objUser, this);
            objMessageDBH.deleteROW();
        }
    }
}
