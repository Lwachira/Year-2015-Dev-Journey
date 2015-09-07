using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s213200619_Baywest.User.userClass
{
    public class userShop
    {
        userBuisnessLayer bl = new userBuisnessLayer();
        private int shopID;
        private string shopName;
        private string shopSize;

        public userShop(int shopID, string shopName, string shopSize)
        {
            this.shopID = shopID;
            this.shopName = shopName;
            this.shopSize = shopSize;
        }

        public userShop(int shopID)
        {
            this.shopID = shopID;
        }

        public userShop()
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

        public DataTable GetShop(int id)
        {
            return bl.getShop(id);
        }


    }
}
