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
    public partial class frmLogin : Form
    {
        private classLogin cl = new classLogin();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            dgvUser.DataSource = cl.GetAllLogin();
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    txtUserName.Text = dgvUser[0, e.RowIndex].Value.ToString();
            //    txtUserID.Text = dgvUser[2, e.RowIndex].Value.ToString();
            //    txtUserRank.Text = dgvUser[1, e.RowIndex].Value.ToString();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void dgvUser_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtUserName.Text = dgvUser[0, e.RowIndex].Value.ToString();
                txtUserID.Text = dgvUser[2, e.RowIndex].Value.ToString();
                txtUserRank.Text = dgvUser[1, e.RowIndex].Value.ToString();
                txtClientID.Text = dgvUser[3, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cl = new classLogin(txtUserName.Text, txtUserRank.Text, int.Parse(txtUserID.Text), int.Parse(txtClientID.Text));
            dgvUser.DataSource = cl.InsertLogin();
            dgvUser.DataSource = cl.GetAllLogin();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cl = new classLogin(int.Parse(txtUserID.Text));
            dgvUser.DataSource = cl.DeleteLogin();
            dgvUser.DataSource = cl.GetAllLogin();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cl = new classLogin(txtUserName.Text, txtUserRank.Text, int.Parse(txtUserID.Text), int.Parse(txtClientID.Text));
            dgvUser.DataSource = cl.UpdateLogin();
            dgvUser.DataSource = cl.GetAllLogin();
        }
    }
}