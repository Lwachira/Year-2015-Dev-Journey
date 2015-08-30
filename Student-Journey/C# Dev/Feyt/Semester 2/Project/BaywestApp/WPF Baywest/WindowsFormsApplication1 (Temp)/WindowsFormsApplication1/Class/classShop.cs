using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    internal class classShop
    {
        private BusinessLayer bl = new BusinessLayer();
        private int shopID;
        private string shopName;
        private string shopSize;

        public classShop()
        {
        }

        public classShop(int shopID, string shopName, string shopSize)
        {
            this.shopID = shopID;
            this.shopName = shopName;
            this.shopSize = shopSize;
        }

        public classShop(int shopID)
        {
            this.shopID = shopID;
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
            return bl.GetShop();
        }

        public int InsertShop()
        {
            return bl.InsertShop(this);
        }

        public int DeleteShop()
        {
            return bl.DeleteShop(this);
        }

        public int UpdateShop()
        {
            return bl.updateShop(this);
        }
    }
}