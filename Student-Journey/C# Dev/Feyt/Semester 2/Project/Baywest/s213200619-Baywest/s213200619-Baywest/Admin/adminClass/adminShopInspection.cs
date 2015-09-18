using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s213200619_Baywest.Admin.adminClass
{
    public class adminShopInspection
    {
        private adminBusinessLayer bl = new adminBusinessLayer();
        private int inspectionID;
        private int shopID;
        private int serviceID;
        private string startDate;
        private string endDate;
        private string inspectionTask;
        private string message;

        public adminShopInspection(int inspectionID, int shopID, int serviceID, string startDate, string endDate, string inspectionTask, string message)
        {
            this.inspectionID = inspectionID;
            this.shopID = shopID;
            this.serviceID = serviceID;
            this.startDate = startDate;
            this.endDate = endDate;
            this.inspectionTask = inspectionTask;
            this.message = message;

        }

        public adminShopInspection(int inspectionID)
        {
            this.inspectionID = inspectionID;
        }

        public adminShopInspection()
        {

        }

        public int InspectionID
        {
            get { return inspectionID; }
            set { inspectionID = value; }
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

        public string InspectionTask
        {
            get { return inspectionTask; }
            set { inspectionTask = value; }


        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }


        public DataTable GetAllShopInspection()
        {
            return bl.getAllShopInspection();
        }

        public int InsertShopInspection()
        {
            return bl.insertShopInspection(this);
        }

        public int UpdateShopInspection()
        {
            return bl.updateShopInspection(this);
        }

        public int DeleteShopInspection()
        {
            return bl.deleteShopInspection(this);
        }

    }

}
