using System;
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
            cs = new classShop(int.Parse(txtShopID.Text), txtShopName.Text, txtShopSize.Text);
            dgvShop.DataSource = cs.InsertShop();
            dgvShop.DataSource = cs.GetAllShop();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cs = new classShop(int.Parse(txtShopID.Text));
            dgvShop.DataSource = cs.DeleteShop();
            dgvShop.DataSource = cs.GetAllShop();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cs = new classShop(int.Parse(txtShopID.Text), txtShopName.Text, txtShopSize.Text);
            dgvShop.DataSource = cs.UpdateShop();
            dgvShop.DataSource = cs.GetAllShop();
        }
    }
}