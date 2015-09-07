using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s213200619_Baywest.Admin.adminClass
{
    public class classLoginDetails
    {
        adminBusinessLayer bl = new adminBusinessLayer();
        int loginID;
        string loginUserName;
        string loginRank;


        public classLoginDetails(int loginID, string loginUserName, string loginRank)
        {
            this.loginID = loginID;
            this.loginUserName = loginUserName;
            this.loginRank = loginRank;
        }



        public classLoginDetails(int loginID)
        {
            this.loginID = loginID;

        }

        public classLoginDetails()
        {

        }

        public int LoginID
        {
            get { return loginID; }
            set { loginID = value; }
        }

        public string LoginUserName
        {
            get { return loginUserName; }
            set { loginUserName = value; }
        }

        public string LoginRank
        {
            get { return loginRank; }
            set { loginRank = value; }
        }

        public DataTable GetAllLogin()
        {
            return bl.GetAllLogin();
        }

    }
}
