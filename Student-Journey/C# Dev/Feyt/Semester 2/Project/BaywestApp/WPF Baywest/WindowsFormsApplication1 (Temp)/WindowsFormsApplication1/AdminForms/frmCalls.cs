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
    public partial class frmCalls : Form
    {
        private classCalls cc = new classCalls();

        public frmCalls()
        {
            InitializeComponent();
        }

        private void frmCalls_Load(object sender, EventArgs e)
        {
            dgvCalls.DataSource = cc.GetAllCalls();
        }

        private void dgvCalls_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCallID.Text = dgvCalls[0, e.RowIndex].Value.ToString();
                txtCallType.Text = dgvCalls[1, e.RowIndex].Value.ToString();
                txtProblemDescription.Text = dgvCalls[2, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cc = new classCalls(int.Parse(txtCallID.Text), txtCallType.Text, txtProblemDescription.Text);
                dgvCalls.DataSource = cc.InsertCalls();
                dgvCalls.DataSource = cc.GetAllCalls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cc = new classCalls(int.Parse(txtCallID.Text));
            dgvCalls.DataSource = cc.DeleteCalls();
            dgvCalls.DataSource = cc.GetAllCalls();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cc = new classCalls(int.Parse(txtCallID.Text), txtCallType.Text, txtProblemDescription.Text);
            dgvCalls.DataSource = cc.UpdateCalls();
            dgvCalls.DataSource = cc.GetAllCalls();
        }
    }
}