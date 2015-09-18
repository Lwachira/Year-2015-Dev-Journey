using MetroFramework.Forms;
using s213200619_Baywest.User.userClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s213200619_Baywest.User.userForm
{
    public partial class frmShop_Service : MetroForm
    {
        private userShopService uss = new userShopService();
        private userShop us = new userShop();
        private int shopServiceID;
        private int shopID;
        private int serviceID;
        private string serviceName;

        public frmShop_Service(userShop us)
        {
            InitializeComponent();
            this.us = us;
        }

        private void frmShop_Service_Load(object sender, EventArgs e)
        {
            metrodgvShopsService.DataSource = uss.GetShop_Service(us.ShopID);
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
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
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
}