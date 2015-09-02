using BayWest_213200619.AdminForms;
using BayWest_213200619.Classess;
using BayWest_213200619.UserForms;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BayWest_213200619
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        private classLogin cl = new classLogin();
        private string userName;
        private string userRank;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            mCmbUsername.DataSource = cl.GetAllLogin();
            mCmbUsername.DisplayMember = "UserName";
            mCmbUsername.ValueMember = "Rank";
        }

        private void mCmbUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            userName = mCmbUsername.Text;
            userRank = mCmbUsername.SelectedValue.ToString();
            if (mCmbUsername.SelectedValue.ToString().Contains("admin"))
            {
                frmAdminHome home = new frmAdminHome(userName, userRank);
                this.Visible = false;
                home.ShowDialog();
                this.Visible = true;
            }
            else if (mCmbUsername.SelectedValue.ToString().Contains("user"))
            {
                frmUserHome home = new frmUserHome();
                this.Visible = false;
                home.ShowDialog();
                this.Visible = true;
            }
        }
    }
}