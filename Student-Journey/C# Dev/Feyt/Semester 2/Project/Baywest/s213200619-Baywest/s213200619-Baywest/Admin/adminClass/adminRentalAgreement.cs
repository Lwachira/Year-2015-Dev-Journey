using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s213200619_Baywest.Admin.adminClass
{
    public class adminRentalAgreement
    {

        private adminBusinessLayer bl = new adminBusinessLayer();
        private int rentalID;
        private int customerID;
        private int shopID;
        private string rentalStartDate;
        private string rentalEndDate;


        public adminRentalAgreement(int rentalID, int customerID, int shopID, string rentalStartDate, string rentalEndDate)
        {
            this.rentalID = rentalID;
            this.customerID = customerID;
            this.shopID = shopID;
            this.rentalStartDate = rentalStartDate;
            this.rentalEndDate = rentalEndDate;
        }

        public adminRentalAgreement(int rentalID)
        {
            this.rentalID = rentalID;
        }

        public adminRentalAgreement()
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


        public DataTable GetAllRental()
        {
            return bl.getAllRental();
        }

        public int InsertRental()
        {
            return bl.insertRental(this);
        }

        public int DeleteRental()

        {
            return bl.deleteRental(this);
        }

        public int UpdateRental()
        {
            return bl.updateRental(this);
        }
    }
}
