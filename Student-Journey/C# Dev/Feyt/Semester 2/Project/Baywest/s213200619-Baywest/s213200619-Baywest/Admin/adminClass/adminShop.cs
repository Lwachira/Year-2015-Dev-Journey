using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s213200619_Baywest.Admin.adminClass
{
    public class adminShop
    {
        private adminBusinessLayer bl = new adminBusinessLayer();
        private int shopID;
        private string shopName;
        private string shopSize;

        public adminShop(int shopID, string shopName, string shopSize)
        {
            this.shopID = shopID;
            this.shopName = shopName;
            this.shopSize = shopSize;
        }

        public adminShop(int shopID)
        {
            this.shopID = shopID;

        }

        public adminShop()
        {

        }

        public int ShopID
        {
            get { return shopID; }
            set { shopID = value; }
        }

        public string ShopName
        {
            get { return shopName; }
            set { shopName = value; }
        }

        public string ShopSize
        {
            get { return shopSize; }
            set { shopSize = value; }
        }

        public DataTable GetAllShop()
        {
            return bl.getAllShop();
        }

        public int InsertShop()
        {
            return bl.insertShop(this);
        }

        public int UpdateShop()
        {
            return bl.updateShop(this);
        }

        public int DeleteShop()
        {
            return bl.deleteShop(this);
        }
    }
}
