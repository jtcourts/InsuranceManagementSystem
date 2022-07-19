using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;    // add this using directive for access to the sqlServer
using System.Windows.Forms;

namespace MyLoginForm
{
    abstract class clsDatabaseHandler
    {
        public clsDatabaseHandler()
        {
            cn = new SqlConnection();
            cmd = new SqlCommand();
            cn.ConnectionString = "Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_B;Persist Security Info=True;User ID=TEAM_B;Password=ZpFsLZXvYYLYWktBYMLnsAFv";
            cmd.Connection = cn;

        }
        public SqlConnection cn { get; set; }
        public SqlCommand cmd;
        public SqlDataReader dr;
        public abstract void fetchRowData(int key, int type);//added clsUser object

        public abstract void updateTable(string[] data);

        public abstract void insertIntoTable(string[] data);
        //method to load data from a database table into a list of clsUser objects
    }
}
