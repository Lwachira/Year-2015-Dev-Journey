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
    public partial class frmShop : MetroForm
    {
        public userRental ur = new userRental();
        public userShop us = new userShop();
        int shopID;
        string shopName;
        string shopSize;
        public frmShop(userRental ur)
        {
            InitializeComponent();
            this.ur = ur;
        }

        private void frmShop_Load(object sender, EventArgs e)
        {
            metrodgvShop.DataSource = us.GetShop(int.Parse(ur.ShopID.ToString()));
        }

        private void metrodgvUser_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                shopID = int.Parse(metrodgvShop[0, e.RowIndex].Value.ToString());
                shopName = metrodgvShop[1, e.RowIndex].Value.ToString();
                shopSize = metrodgvShop[2, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            us = new userShop(shopID, shopName, shopSize);
            frmShop_Service shopService = new frmShop_Service(us);
            shopService.ShowDialog();

        }
    }
}
