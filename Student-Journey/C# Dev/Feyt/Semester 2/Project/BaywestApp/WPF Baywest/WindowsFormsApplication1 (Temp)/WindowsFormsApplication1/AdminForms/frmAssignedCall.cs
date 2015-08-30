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

namespace WindowsFormsApplication1.AdminForms
{
    public partial class frmAssignedCall : Form
    {
        private classAssignedCall ca = new classAssignedCall();

        public frmAssignedCall()
        {
            InitializeComponent();
        }

        private void dgvAssignedCall_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void frmAssignedCall_Load(object sender, EventArgs e)
        {
            dgvAssignedCall.DataSource = ca.GetAllAsignedCall();
        }

        private void dgvAssignedCall_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtAssignedID.Text = dgvAssignedCall[0, e.RowIndex].Value.ToString();
                txtCallID.Text = dgvAssignedCall[1, e.RowIndex].Value.ToString();
                txtStaffID.Text = dgvAssignedCall[2, e.RowIndex].Value.ToString();
                txtStartDate.Text = dgvAssignedCall[3, e.RowIndex].Value.ToString();
                txtShopID.Text = dgvAssignedCall[4, e.RowIndex].Value.ToString();
                txtCallStatus.Text = dgvAssignedCall[5, e.RowIndex].Value.ToString();
                txtServiceID.Text = dgvAssignedCall[6, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rentalAgreementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRental rental = new frmRental();
            rental.ShowDialog();
        }

        private void callToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalls call = new frmCalls();
            call.ShowDialog();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStaff staff = new frmStaff();
            staff.ShowDialog();
        }

        private void serviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmService service = new frmService();
            service.ShowDialog();
        }

        private void callProgressToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}