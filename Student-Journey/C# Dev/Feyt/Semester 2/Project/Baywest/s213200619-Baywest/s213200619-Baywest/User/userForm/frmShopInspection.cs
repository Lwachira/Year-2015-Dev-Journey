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
    public partial class frmShopInspection : MetroForm
    {
<<<<<<< HEAD
        private userShopService uss = new userShopService();
        private userShopInspection usi = new userShopInspection();

=======
        public userShopService uss = new userShopService();
        public userShopInspection usi = new userShopInspection();
>>>>>>> 064fcc474fdf023a259aa852b3154a726676540e
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
<<<<<<< HEAD
}
=======
}
>>>>>>> 064fcc474fdf023a259aa852b3154a726676540e
