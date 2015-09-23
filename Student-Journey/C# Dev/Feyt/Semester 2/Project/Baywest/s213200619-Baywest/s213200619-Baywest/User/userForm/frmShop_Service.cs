<<<<<<< HEAD
﻿using MetroFramework.Forms;
using s213200619_Baywest.User.userClass;
using System;
=======
﻿using System;
>>>>>>> 064fcc474fdf023a259aa852b3154a726676540e
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
=======
using MetroFramework.Forms;
using s213200619_Baywest.User.userClass;
>>>>>>> 064fcc474fdf023a259aa852b3154a726676540e

namespace s213200619_Baywest.User.userForm
{
    public partial class frmShop_Service : MetroForm
    {
<<<<<<< HEAD
        private userShopService uss = new userShopService();
        private userShop us = new userShop();
        private int shopServiceID;
        private int shopID;
        private int serviceID;
        private string serviceName;

=======

        public userShop us = new userShop();
        public userShopService uss = new userShopService();
        int shopServiceID;
        int shopID;
        int serviceID;
        string serviceName;
>>>>>>> 064fcc474fdf023a259aa852b3154a726676540e
        public frmShop_Service(userShop us)
        {
            InitializeComponent();
            this.us = us;
        }

        private void frmShop_Service_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            metrodgvShopsService.DataSource = uss.GetShop_Service(us.ShopID);
=======
            metrodgvShopsService.DataSource = uss.GetShop_Service(int.Parse(us.ShopID.ToString()));
>>>>>>> 064fcc474fdf023a259aa852b3154a726676540e
        }

        //private void metrodgvShopsService_RowEnter(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        txtShopServiceID.Text = metrodgvShopsService[0, e.RowIndex].Value.ToString();
        //        txtShopID.Text = metrodgvShopsService[1, e.RowIndex].Value.ToString();
        //        txtServiceID.Text = metrodgvShopsService[2, e.RowIndex].Value.ToString();
        //        txtServiceName.Text = metrodgvShopsService[3, e.RowIndex].Value.ToString();
        //    }
        //    catch (Exception ex)
        //    {
<<<<<<< HEAD
=======

>>>>>>> 064fcc474fdf023a259aa852b3154a726676540e
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void metrodgvShopsService_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                shopServiceID = int.Parse(metrodgvShopsService[0, e.RowIndex].Value.ToString());
                shopID = int.Parse(metrodgvShopsService[1, e.RowIndex].Value.ToString());
                serviceID = int.Parse(metrodgvShopsService[2, e.RowIndex].Value.ToString());
                serviceName = metrodgvShopsService[3, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {
<<<<<<< HEAD
=======

>>>>>>> 064fcc474fdf023a259aa852b3154a726676540e
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======

>>>>>>> 064fcc474fdf023a259aa852b3154a726676540e
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======

>>>>>>> 064fcc474fdf023a259aa852b3154a726676540e
        }

        private void btnShopInspection_Click(object sender, EventArgs e)
        {
            uss = new userShopService(shopServiceID, shopID, serviceID, serviceName);
            frmShopInspection shopInspection = new frmShopInspection(uss);
            shopInspection.ShowDialog();
        }

        private void btnShopUpgrade_Click(object sender, EventArgs e)
        {
            uss = new userShopService(shopServiceID, shopID, serviceID, serviceName);
            frmShopUpgrade shopUpgrade = new frmShopUpgrade(uss);
            shopUpgrade.ShowDialog();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            frmAddShopService shopService = new frmAddShopService();
            shopService.ShowDialog();
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 064fcc474fdf023a259aa852b3154a726676540e
