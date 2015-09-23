using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s213200619_Baywest.User.userClass
{
    public class userShopInspection
    {
        private userBuisnessLayer bl = new userBuisnessLayer();
<<<<<<< HEAD
        private int shopInspectionID;
        private int shopID;
        private int serviceID;
        private string startDate;
        private string endDate;
        private string inspectionTask;
        private string message;
=======
        int shopInspectionID;
        int shopID;
        int serviceID;
        string startDate;
        string endDate;
        string inspectionTask;
        string message;

>>>>>>> 064fcc474fdf023a259aa852b3154a726676540e

        public userShopInspection(int shopInspectionID, int shopID, int serviceID, string startDate, string endDate, string inspectionTask, string message)
        {
            this.shopInspectionID = shopInspectionID;
            this.shopID = shopID;
            this.serviceID = serviceID;
            this.startDate = startDate;
            this.endDate = endDate;
            this.inspectionTask = inspectionTask;
            this.message = message;
        }

        public userShopInspection(int serviceID)
        {
            this.serviceID = serviceID;
        }

        public userShopInspection()
        {
<<<<<<< HEAD
=======

>>>>>>> 064fcc474fdf023a259aa852b3154a726676540e
        }

        public int ShopInspectionID
        {
            get { return shopInspectionID; }
            set { shopInspectionID = value; }
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

        public DataTable GetShopInspection(int id)
        {
            return bl.getShopInspection(id);
        }
<<<<<<< HEAD
    }
}
=======

    }
}
>>>>>>> 064fcc474fdf023a259aa852b3154a726676540e
