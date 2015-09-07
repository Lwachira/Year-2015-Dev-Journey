using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s213200619_Baywest.User.userClass
{
    public class userRental
    {
        private userBuisnessLayer bl = new userBuisnessLayer();
        private int rentalID;
        private int customerID;
        private int shopID;
        private string rentalStartDate;
        private string rentalEndDate;

        public userRental(int rentalID, int customerID, int shopID, string rentalStartDate, string rentalEndDate)
        {
            this.rentalID = rentalID;
            this.customerID = customerID;
            this.shopID = shopID;
            this.rentalStartDate = rentalStartDate;
            this.rentalEndDate = rentalEndDate;
        }

        public userRental(int customerID)
        {
            this.customerID = customerID;
        }


        public userRental()
        {

        }


        public int RentalID
        {
            get { return rentalID; }
            set { rentalID = value; }
        }

        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public int ShopID
        {
            get { return shopID; }
            set { shopID = value; }
        }

        public string RentalStartDate
        {
            get { return rentalStartDate; }
            set { rentalStartDate = value; }
        }

        public string RentalEndDate
        {
            get { return rentalEndDate; }
            set { rentalEndDate = value; }
        }


        public DataTable GetRental(int id)
        {

            return bl.getRental(id);
        }
    }

}
