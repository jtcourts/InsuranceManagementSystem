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
    public partial class UserControlMessages : UserControl
    {
        private MessagesForm mForm;
        public UserControlMessages()
        {
            InitializeComponent();
        }

        public UserControlMessages(MessagesForm f)
        {
            mForm = f;
            InitializeComponent();
        }


        private void UserControlMessages_Load(object sender, EventArgs e)
        {

        }

        public void messages(int sid, DateTime t, string m)
        {
            //get name to set from sid 
            clsUser temp = new clsUser();

            temp.userId = sid;
            temp.getProfileInfo();
            lblName.Text = temp.firstName + " " + temp.lastName;
            lblDate.Text = t.ToString("MM/dd/yyyy HH:mm");
            lblMessageText.Text = m;

            if (lblName.Text == mForm.txtCurrentUserInfo.Text)
            {
                lblName.ForeColor = Color.FromArgb(78, 184, 206);
            }
            else
            {
                lblName.ForeColor = Color.WhiteSmoke;
            }
        }
    }
}
