using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLoginForm
{
    class clsSettings
    {
        private clsUser objUser;
        private clsUserSettingsDBH objUset;
        public clsSettings(clsUser user)
        {
            objUser = user;
        }

        //constructor to help make a claim 
        public clsSettings(clsUser user, string CM, string FM, string pass, string CCN, string PIN, string Exp, string CN) //string SQ1, string SQ2, string SA1, string SA2,
        {
            objUser = user;
            claimM = CM;
            financeM = FM;
            Password = pass;
            this.CCN = CCN;
            this.PIN = PIN;
            this.Exp = Exp;
            this.CardName = CN;
        }

        //settings forms
        public string claimM { get; set; }
        public string financeM { get; set; }
        public string Password { get; set; }
        public string CCN { get; set; }
        public string PIN { get; set; }
        public string Exp { get; set; }
        public string CardName { get; set; }

        public void createSettings()
        {
            objUset = new clsUserSettingsDBH(objUser, this);
            string[] data = new string[6];
            data[0] = objUser.userId.ToString();
            data[1] = objUser.password;
            data[2] = "";
            data[3] = "0";
            data[4] = "";
            data[5] = "";
            objUset.insertIntoTable(data);
        }

        public Boolean userExists()
        {
            objUset = new clsUserSettingsDBH(objUser, this);
            return objUset.userExists();
        }
        public void getSettingsInformation()
        {
            objUset = new clsUserSettingsDBH(objUser,this);
            objUset.fetchRowData(objUser.userId, 1);
        }

        public void updateSettings(string [] s)
        {
            objUset = new clsUserSettingsDBH(objUser, this);
            objUset.updateTable(s);
        }

    }

}
