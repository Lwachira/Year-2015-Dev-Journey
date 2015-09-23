using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s213200619_Baywest.User.userClass
{
    public class userShopUpgrade
    {
        private userBuisnessLayer bl = new userBuisnessLayer();
<<<<<<< HEAD
        private int upgradeID;
        private int shopID;
        private int serviceID;
        private string startDate;
        private string endDate;
        private string upgradeTask;
        private string completionMessage;
=======
        int upgradeID;
        int shopID;
        int serviceID;
        string startDate;
        string endDate;
        string upgradeTask;
        string completionMessage;
>>>>>>> 064fcc474fdf023a259aa852b3154a726676540e

        public userShopUpgrade(int upgradeID, int shopID, int serviceID, string startDate, string endDate, string upgradeTask, string completionMessage)
        {
            this.upgradeID = upgradeID;
            this.shopID = shopID;
            this.serviceID = serviceID;
            this.startDate = startDate;
            this.endDate = endDate;
            this.upgradeTask = upgradeTask;
            this.completionMessage = completionMessage;
<<<<<<< HEAD
=======

>>>>>>> 064fcc474fdf023a259aa852b3154a726676540e
        }

        public userShopUpgrade(int shopID)
        {
            this.shopID = shopID;
        }

        public userShopUpgrade()
        {
<<<<<<< HEAD
=======

>>>>>>> 064fcc474fdf023a259aa852b3154a726676540e
        }

        public DataTable GetShopUpgrade(int id)
        {
            return bl.getShopUpgrade(id);
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 064fcc474fdf023a259aa852b3154a726676540e
