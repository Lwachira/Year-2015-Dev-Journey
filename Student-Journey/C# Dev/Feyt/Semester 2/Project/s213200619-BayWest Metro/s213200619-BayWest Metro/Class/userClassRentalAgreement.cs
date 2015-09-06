using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s213200619_BayWest_Metro.Class
{
    internal class userClassRentalAgreement
    {
        private businessLayer bl = new businessLayer();
        private int rentalID;
        private int clientID;
        private int shopID;
        private string startDate;
        private string endDate;
        private string rentalStatus;

        public userClassRentalAgreement(int rentalID, int clientID, int shopID, string startDate, string endDate, string rentalStatus)
        {
            this.rentalID = rentalID;
            this.clientID = clientID;
            this.shopID = shopID;
            this.startDate = startDate;
            this.endDate = endDate;
            this.rentalStatus = rentalStatus;
        }

        public userClassRentalAgreement(int clientID)
        {
            this.clientID = clientID;
        }

        public userClassRentalAgreement()
        {
        }

        public int RentalID
        {
            get { return rentalID; }
            set { rentalID = value; }
        }

        public int ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }

        public int ShopID
        {
            get { return shopID; }
            set { shopID = value; }
        }

        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public string EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public string RentalStatus
        {
            get { return rentalStatus; }
            set { rentalStatus = value; }
        }

        public DataTable GetRentalAgreement()
        {
            return bl.GetRentalAgreement(this);
        }
    }
}