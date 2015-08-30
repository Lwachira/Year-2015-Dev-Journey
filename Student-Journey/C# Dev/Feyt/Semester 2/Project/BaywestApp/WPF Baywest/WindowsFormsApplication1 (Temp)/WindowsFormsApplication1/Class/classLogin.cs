using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Class
{
    internal class classLogin
    {
        private BusinessLayer bl = new BusinessLayer();

        private string userName;
        private string userRank;
        private int userID;
        private int clientID;

        public classLogin()
        {
        }

        public classLogin(string userName, string userRank, int userID, int clientID)
        {
            this.userName = userName;
            this.userRank = userRank;
            this.userID = userID;
            this.clientID = clientID;
        }

        public classLogin(int userID)
        {
            this.userID = userID;
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public int ClientID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string UserRank
        {
            get { return userRank; }
            set { userRank = value; }
        }

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public DataTable GetAllLogin()
        {
            return bl.GetAllLogin();
        }

        //public int InsertLogin()
        //{
        //    return bl.InsertLogin(this);
        //}

        //public int DeleteLogin()
        //{
        //    return bl.DeleteLogin(this);
        //}

        //public int UpdateLogin()
        //{
        //    return bl.UpdateLogin(this);
        //}
    }
}