using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmShop : Form
    {
        private classShop cs = new classShop();

        public frmShop()
        {
            InitializeComponent();
        }

        private void frmShop_Load(object sender, EventArgs e)
        {
            dgvShop.DataSource = cs.GetAllShop();
        }

        private void dgvShop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtShopID.Text = dgvShop[0, e.RowIndex].Value.ToString();
                txtShopName.Text = dgvShop[1, e.RowIndex].Value.ToString();
                txtShopSize.Text = dgvShop[2, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}