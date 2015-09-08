using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using s213200619_Baywest.User.userClass;

namespace s213200619_Baywest.User.userForm
{
    public partial class frmShop_Service : MetroForm
    {

        public userShop us = new userShop();
        public userShopService uss = new userShopService();
        int shopServiceID;
        int shopID;
        int serviceID;
        string serviceName;
        public frmShop_Service(userShop us)
        {
            InitializeComponent();
            this.us = us;
        }

        private void frmShop_Service_Load(object sender, EventArgs e)
        {
            metrodgvShopsService.DataSource = uss.GetShop_Service(int.Parse(us.ShopID.ToString()));
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
            uss = new userShopService(shopServiceID, shopID, serviceID, serviceName);
            frmShopInspection shopInspection = new frmShopInspection(uss);
            shopInspection.ShowDialog();
        }
    }
}
