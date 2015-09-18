using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s213200619_Baywest.Admin.adminClass
{
    public class adminCustomer
    {
        private adminBusinessLayer bl = new adminBusinessLayer();
        private int customerID;
        private string customerName;
        private string customerCell;
        private int loginID;

        public adminCustomer(int customerID, string customerName, string customerCell, int loginID)
        {
            this.customerID = customerID;
            this.customerName = customerName;
            this.customerCell = customerCell;
            this.loginID = loginID;
        }

        public adminCustomer(int customerID)
        {
            this.customerID = customerID;

        }

        public adminCustomer()
        {

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

        public string CustomerCell
        {
            get { return customerCell; }
            set { customerCell = value; }
        }

        public int LoginID
        {
            get { return loginID; }
            set { loginID = value; }
        }

        public DataTable GetAllCustomer()
        {
            return bl.getAllCustomer();
        }

        public int InsertCustomer()
        {
            return bl.insertCustomer(this);
        }

        public int DeleteCustomer()

        {
            return bl.deleteCustomer(this);
        }

        public int UpdateCustomer()
        {
            return bl.updateCustomer(this);
        }

    }
}
