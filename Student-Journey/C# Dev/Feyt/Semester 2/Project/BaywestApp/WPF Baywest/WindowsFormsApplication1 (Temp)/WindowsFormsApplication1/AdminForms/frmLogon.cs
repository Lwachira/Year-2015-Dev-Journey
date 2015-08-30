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
    public partial class frmLogon : Form
    {
        private classLogin cl = new classLogin();

        public frmLogon()
        {
            InitializeComponent();
        }

        private void frmLogon_Load(object sender, EventArgs e)
        {
            cmbUsers.DataSource = cl.GetAllLogin();
            cmbUsers.ValueMember = "rank";
            txtID.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            cmbUsers.ValueMember = "rank";
            if (cmbUsers.SelectedValue.ToString().Contains("admin"))
            {
                AdminHome adHome = new AdminHome();
                this.Visible = false;
                adHome.ShowDialog();
                this.Visible = true;
            }
            else if (cmbUsers.SelectedValue.ToString().Contains("user"))
            {
                frmUserHome userHome = new frmUserHome(txtID.Text);
                this.Visible = false;
                userHome.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("We Don't Recognize you we only accept user/admin");
            }
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbUsers.ValueMember = "UserID";
            txtID.Text = cmbUsers.SelectedValue.ToString();
        }
    }
}