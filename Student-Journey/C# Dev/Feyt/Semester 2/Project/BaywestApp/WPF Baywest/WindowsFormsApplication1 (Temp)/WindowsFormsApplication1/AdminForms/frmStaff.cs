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
    public partial class frmStaff : Form
    {
        private classStaff cs = new classStaff();

        public frmStaff()
        {
            InitializeComponent();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            dgvStaff.DataSource = cs.GetAllStaff();
        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtStaffID.Text = dgvStaff[0, e.RowIndex].Value.ToString();
                txtStaffName.Text = dgvStaff[1, e.RowIndex].Value.ToString();
                txtStaffCellNumber.Text = dgvStaff[2, e.RowIndex].Value.ToString();
                txtStaffType.Text = dgvStaff[3, e.RowIndex].Value.ToString();
                txtCallID.Text = dgvStaff[4, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cs = new classStaff(int.Parse(txtStaffID.Text), txtStaffName.Text, txtStaffCellNumber.Text, txtStaffType.Text, int.Parse(txtCallID.Text));
            dgvStaff.DataSource = cs.InsertStaff();
            dgvStaff.DataSource = cs.GetAllStaff();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cs = new classStaff(int.Parse(txtStaffID.Text));
            dgvStaff.DataSource = cs.DeleteStaff();
            dgvStaff.DataSource = cs.GetAllStaff();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cs = new classStaff(int.Parse(txtStaffID.Text), txtStaffName.Text, txtStaffCellNumber.Text, txtStaffType.Text, int.Parse(txtCallID.Text));
            dgvStaff.DataSource = cs.UpdateStaff();
            dgvStaff.DataSource = cs.GetAllStaff();
        }
    }
}