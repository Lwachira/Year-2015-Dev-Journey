using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s213200619_Baywest.User.userClass
{
    class userCustomer
    {
        private int customerID;
        private string customerName;
        private string customerCellNumber;
        private int loginID;

        public userCustomer(int customerID, string customerName, string customerCellNumber, int loginID)
        {
            this.customerID = customerID;
            this.customerName = customerName;
            this.customerCellNumber = customerCellNumber;
            this.loginID = loginID;
        }


        public userCustomer(int customerID)
        {
            this.customerID = customerID;

        }





    }
}
