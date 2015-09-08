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
    public partial class frmShopUpgrade : MetroForm
    {
        private userShopService uss = new userShopService();
        private userShopUpgrade usu = new userShopUpgrade();
        public frmShopUpgrade(userShopService uss)
        {
            InitializeComponent();
            this.uss = uss;
        }

        private void frmShopUpgrade_Load(object sender, EventArgs e)
        {
            metroDgvShopUpgrade.DataSource = usu.GetShopUpgrade(int.Parse(uss.ShopID.ToString()));
        }

        private void metroDgvShopUpgrade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
