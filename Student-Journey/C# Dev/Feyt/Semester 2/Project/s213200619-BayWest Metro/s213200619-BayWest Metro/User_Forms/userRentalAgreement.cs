using MetroFramework.Forms;
using s213200619_BayWest_Metro.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s213200619_BayWest_Metro.User_Forms
{
    public partial class userRentalAgreement : MetroForm
    {
        private userClassRentalAgreement ucra = new userClassRentalAgreement();

        public userRentalAgreement()
        {
            InitializeComponent();
        }

        private void userRentalAgreement_Load(object sender, EventArgs e)
        {
            ucra = new userClassRentalAgreement(2);
            dgvRentalAgreement.DataSource = ucra.GetRentalAgreement();
        }
    }
}