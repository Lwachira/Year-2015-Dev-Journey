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
    public partial class frmRental : Form
    {
        private classRental cl = new classRental();

        public frmRental()
        {
            InitializeComponent();
        }

        private void dgvRental_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void dgvRental_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void frmRental_Load(object sender, EventArgs e)
        {
            dgvRental.DataSource = cl.GetAllCalls();
        }

        private void dgvRental_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtRentalID.Text = dgvRental[0, e.RowIndex].Value.ToString();
                txtClientID.Text = dgvRental[1, e.RowIndex].Value.ToString();
                txtShopID.Text = dgvRental[2, e.RowIndex].Value.ToString();
                txtStartDate.Text = dgvRental[3, e.RowIndex].Value.ToString();
                txtEndDate.Text = dgvRental[4, e.RowIndex].Value.ToString();
                txtRenalStatus.Text = dgvRental[5, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cl = new classRental(int.Parse(txtClientID.Text), int.Parse(txtShopID.Text), txtStartDate.Text, txtEndDate.Text, txtRenalStatus.Text, int.Parse(txtRentalID.Text));
                dgvRental.DataSource = cl.UpdateCall();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "hi");
            }

            //Immediate refreshing
            dgvRental.DataSource = cl.GetAllCalls();
        }
    }
}