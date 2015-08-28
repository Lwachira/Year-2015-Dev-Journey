using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    internal class classRental
    {
        private BusinessLayer bl = new BusinessLayer();
        private int rentalID;
        private int clientID;
        private int shopID;
        private string startDate;
        private string endDate;
        private string rentalStatus;

        public classRental(int clientID, int shopID, string startDate, string endDate, string rentalStatus, int rentalID)
        {
            this.clientID = clientID;
            this.shopID = shopID;
            this.startDate = startDate;
            this.endDate = endDate;
            this.rentalStatus = rentalStatus;
            this.rentalID = rentalID;
        }

        public classRental(int rentalID, int clientID, int shopID, string startDate, string endDate, string rentalStatus)
        {
            this.clientID = clientID;
            this.shopID = shopID;
            this.startDate = startDate;
            this.endDate = endDate;
            this.rentalStatus = rentalStatus;
            this.rentalID = rentalID;
        }

        public classRental(int rentalID)
        {
            this.rentalID = rentalID;
        }

        public classRental()
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

        public DataTable GetAllCalls()
        {
            return bl.GetRental();
        }

        public int UpdateCall()
        {
            return bl.UpdateRental(this);
        }

        public int InsertCall()
        {
            return bl.InsertRental(this);
        }

        public int DeleteCall()
        {
            return bl.DeleteRental(this);
        }
    }
}