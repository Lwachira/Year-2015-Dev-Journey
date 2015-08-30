using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Class;

namespace WindowsFormsApplication1
{
    public partial class frmService : Form
    {
        private classService cs = new classService();

        public frmService()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cs = new classService(int.Parse(txtServiceID.Text), txtServiceName.Text, int.Parse(txtStaffID.Text));
            dgvRental.DataSource = cs.InsertService();
            dgvRental.DataSource = cs.GetAllService();
        }

        private void dgvRental_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtServiceID.Text = dgvRental[0, e.RowIndex].Value.ToString();
                txtServiceName.Text = dgvRental[1, e.RowIndex].Value.ToString();
                txtStaffID.Text = dgvRental[2, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmService_Load(object sender, EventArgs e)
        {
            dgvRental.DataSource = cs.GetAllService();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cs = new classService(int.Parse(txtServiceID.Text));
            dgvRental.DataSource = cs.DeleteService();
            dgvRental.DataSource = cs.GetAllService();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cs = new classService(int.Parse(txtServiceID.Text), txtServiceName.Text, int.Parse(txtStaffID.Text));
            dgvRental.DataSource = cs.UpdateService();
            dgvRental.DataSource = cs.GetAllService();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStaff staff = new frmStaff();
            this.Visible = false;
            staff.ShowDialog();
            this.Visible = true;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            AdminHome home = new AdminHome();
            home.ShowDialog();
        }

        private void rentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}