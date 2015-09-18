using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s213200619_Baywest.User.userClass
{
    public class userShopService
    {
        private userBuisnessLayer bl = new userBuisnessLayer();

        private int shopServiceID;
        private int shopID;
        private int serviceID;
        private string serviceName;

        public userShopService(int shopServiceID, int shopID, int serviceID, string serviceName)
        {
            this.shopServiceID = shopServiceID;
            this.shopID = shopID;
            this.serviceID = serviceID;
            this.serviceName = serviceName;
        }

        public userShopService(int shopID)
        {
            this.shopID = shopID;
        }

        public userShopService()
        {

        }

        public int ShopServiceID
        {
            get { return shopServiceID; }
            set { shopServiceID = value; }
        }

        public int ShopID
        {
            get { return shopID; }
            set { shopID = value; }
        }

        public int ServiceID
        {
            get { return serviceID; }
            set { serviceID = value; }
        }

        public string ServiceName
        {
            get { return serviceName; }
            set { serviceName = value; }
        }

        public DataTable GetShop_Service(int ID)
        {
            return bl.getShop_Service(ID);
        }
    }
}
