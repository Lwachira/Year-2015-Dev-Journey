using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s213200619_Baywest.Admin.adminClass
{
    public class adminShopService
    {
        private adminBusinessLayer bl = new adminBusinessLayer();
        private int shopServiceID;
        private int shopID;
        private int serviceID;
        private string serviceName;

        public adminShopService(int shopServiceID, int shopID, int serviceID, string serviceName)
        {
            this.shopServiceID = shopServiceID;
            this.shopID = shopID;
            this.serviceID = serviceID;
            this.serviceName = serviceName;

        }

        public adminShopService(int shopServiceID)
        {
            this.shopServiceID = shopServiceID;
        }

        public adminShopService()
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

        public DataTable GetAllShopService()
        {
            return bl.getAllShopService();
        }

        public int InsertShopService()
        { return bl.insertShopService(this); }

        public int DeleteShopService()
        { return bl.deleteShopService(this); }

        public int UpdateShopService()
        { return bl.updateShopService(this); }
    }
}
