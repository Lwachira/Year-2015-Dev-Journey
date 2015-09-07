using s213200619_Baywest.Admin.adminClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s213200619_Baywest.User.userClass
{
    public class userCustomer
    {
        private classLoginDetails cl = new classLoginDetails();
        private userBuisnessLayer bl = new userBuisnessLayer();
        private int customerID;
        private string customerName;
        private string customerCellNumber;
        private int loginID;

        public userCustomer()
        {

        }

        public userCustomer(int loginID)
        {
            this.loginID = loginID;
        }

        public userCustomer(int customerID, int loginID)
        {
            this.customerID = customerID;
            this.loginID = loginID;
        }


        public userCustomer(int customerID, string customerName, string customerCellNumber, int loginID)
        {
            this.customerID = customerID;
            this.customerName = customerName;
            this.customerCellNumber = customerCellNumber;
            this.loginID = loginID;
        }


        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public string CustomerCellNumber
        {
            get { return customerCellNumber; }
            set { customerCellNumber = value; }
        }

        public int LoginID
        {
            get { return loginID; }
            set { loginID = value; }
        }
        public DataTable GetUser(int id)
        {
            id = id + 1;
            return bl.getMyUser(id);
        }

    }
}
