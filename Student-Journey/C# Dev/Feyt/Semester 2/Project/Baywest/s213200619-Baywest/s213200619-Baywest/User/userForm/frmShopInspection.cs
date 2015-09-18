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
    public partial class frmShopInspection : MetroForm
    {
        private userShopService uss = new userShopService();
        private userShopInspection usi = new userShopInspection();

        public frmShopInspection(userShopService uss)
        {
            InitializeComponent();
            this.uss = uss;
        }

        private void frmShopInspection_Load(object sender, EventArgs e)
        {
            metroDgvInspection.DataSource = usi.GetShopInspection(int.Parse(uss.ShopID.ToString()));
        }
    }
}