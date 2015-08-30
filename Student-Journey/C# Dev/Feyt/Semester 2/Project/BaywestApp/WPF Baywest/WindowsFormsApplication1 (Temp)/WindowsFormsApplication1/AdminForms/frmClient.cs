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
    public partial class frmClient : Form
    {
        private classClient cl = new classClient();

        public frmClient()
        {
            InitializeComponent();
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            dgvClient.DataSource = cl.GetAllClient();
        }

        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtClientID.Text = dgvClient[0, e.RowIndex].Value.ToString();
                txtClientName.Text = dgvClient[1, e.RowIndex].Value.ToString();
                txtClientCell.Text = dgvClient[2, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cl = new classClient(int.Parse(txtClientID.Text), txtClientName.Text, txtClientCell.Text);
            dgvClient.DataSource = cl.InsertClient();
            dgvClient.DataSource = cl.GetAllClient();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cl = new classClient(int.Parse(txtClientID.Text));
            dgvClient.DataSource = cl.DeleteClient();
            dgvClient.DataSource = cl.GetAllClient();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cl = new classClient(int.Parse(txtClientID.Text), txtClientName.Text, txtClientCell.Text);
            dgvClient.DataSource = cl.UpdateClient();
            dgvClient.DataSource = cl.GetAllClient();
        }
    }
}