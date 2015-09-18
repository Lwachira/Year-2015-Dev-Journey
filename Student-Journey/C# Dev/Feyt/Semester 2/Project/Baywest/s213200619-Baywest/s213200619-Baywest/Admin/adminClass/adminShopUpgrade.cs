using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s213200619_Baywest.Admin.adminClass
{
    public class adminShopUpgrade
    {
        private adminBusinessLayer bl = new adminBusinessLayer();
        private int upgradeID;
        private int shopID;
        private int serviceID;
        private string startDate;
        private string endDate;
        private string upgradeTask;
        private string completionMessage;


        public adminShopUpgrade(int upgradeID, int shopID, int serviceID, string startDate, string endDate, string upgradeTask, string completionMessage)
        {
            this.upgradeID = upgradeID;
            this.shopID = shopID;
            this.serviceID = serviceID;
            this.startDate = startDate;
            this.endDate = endDate;
            this.upgradeTask = upgradeTask;
            this.completionMessage = completionMessage;
        }

        public adminShopUpgrade(int upgradeID)
        {
            this.upgradeID = upgradeID;
        }

        public adminShopUpgrade()
        {

        }


        public int UpgradeID
        {
            get { return upgradeID; }
            set { upgradeID = value; }
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

        public string UpgradeTask
        {
            get { return upgradeTask; }
            set { upgradeTask = value; }
        }

        public string CompletionMessage
        {
            get { return completionMessage; }
            set { completionMessage = value; }
        }


        public DataTable GetAllShopUpgrade()
        {
            return bl.getAllShopUpgrade();
        }

        public int InsertShopUpgrade()
        {
            return bl.insertShopUpgrade(this);
        }

        public int UpdateShopUpgrade()
        {
            return bl.updateShopUpgrade(this);
        }

        public int DeleteShopUpgrade()
        {
            return bl.deleteShopUpgrade(this);
        }
    }
}
