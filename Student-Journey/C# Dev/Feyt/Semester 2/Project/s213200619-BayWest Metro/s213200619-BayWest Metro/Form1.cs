using MetroFramework.Forms;
using s213200619_BayWest_Metro.Admin_Forms;
using s213200619_BayWest_Metro.Class;
using s213200619_BayWest_Metro.User_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s213200619_BayWest_Metro
{
    public partial class Form1 : MetroForm
    {
        private classLogin cl = new classLogin();
        private string userName;
        private string userRank;
        private int clientID;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

                home.ShowDialog();
                this.Close();
            }
            else if (mCmbUsername.SelectedValue.ToString().Contains("user"))
            {
                mCmbUsername.ValueMember = "ClientID";
                clientID = int.Parse(mCmbUsername.SelectedValue.ToString());

                frmUserHome home = new frmUserHome(userName, userRank, clientID);

                home.ShowDialog();
                this.Close();
            }
        }
    }
}