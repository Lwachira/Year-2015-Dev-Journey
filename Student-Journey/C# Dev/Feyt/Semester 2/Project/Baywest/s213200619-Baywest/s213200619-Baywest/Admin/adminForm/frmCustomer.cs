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
using s213200619_Baywest.Admin.adminClass;

namespace s213200619_Baywest.Admin.adminForm
{
    public partial class frmCustomer : MetroForm
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            metroDgvFileCustomer.DataSource = helperClass.DataTableFromTextFile(@"Files\NewUser.txt", '#');
        }
    }
}
