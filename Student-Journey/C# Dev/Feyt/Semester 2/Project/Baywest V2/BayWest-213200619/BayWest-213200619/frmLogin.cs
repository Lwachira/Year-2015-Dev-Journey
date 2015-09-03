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
        private int clientID;

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
                txtAbout home = new txtAbout(userName, userRank);

                home.ShowDialog();
            }
            else if (mCmbUsername.SelectedValue.ToString().Contains("user"))
            {
                mCmbUsername.ValueMember = "ClientID";
                clientID = int.Parse(mCmbUsername.SelectedValue.ToString());

                frmUserHome home = new frmUserHome(userName, userRank, clientID);

                home.ShowDialog();
            }
        }
    }
}