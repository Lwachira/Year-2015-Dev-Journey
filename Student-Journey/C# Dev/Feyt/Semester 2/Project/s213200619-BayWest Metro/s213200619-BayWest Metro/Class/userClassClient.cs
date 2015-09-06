using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s213200619_BayWest_Metro.Class
{
    internal class userClassClient
    {
        private businessLayer bl = new businessLayer();

        private int clientID;
        private string clientName;
        private string clientCell;

        public userClassClient()
        {
        }

        public userClassClient(int clientID)
        {
            this.clientID = clientID;
        }

        public userClassClient(int clientID, string clientName, string clientCell)
        {
            this.clientID = clientID;
            this.clientName = clientName;
            this.clientCell = clientCell;
        }

        public int ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }

        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }

        public string ClientCell
        {
            get { return clientCell; }
            set { clientCell = value; }
        }

        public DataTable GetClient()
        {
            return bl.GetClient(this);
        }

        //public DataTable GetAllClient()
        //{
        //    return bl.GetAllClient();
        //}

        //public int InsertClient()
        //{
        //    return bl.InsertClient(this);
        //}

        //public int DeleteClient()
        //{
        //    return bl.DeleteClient(this);
        //}

        //public int UpdateClient()
        //{
        //    return bl.UpdateClient(this);
        //}
    }
}