using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.UsersForms
{
    public partial class frmURental : Form
    {
        private classRental cr = new classRental();

        public frmURental()
        {
            InitializeComponent();
        }

        private void frmRental_Load(object sender, EventArgs e)
        {
            dgvRental.DataSource = cr.GetAllCalls();
        }
    }
}