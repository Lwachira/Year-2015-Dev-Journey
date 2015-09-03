using BayWest_213200619.Classess;
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

namespace BayWest_213200619.UserForms
{
    public partial class frmUserHome : MetroFramework.Forms.MetroForm
    {
        private userClassClient ucc = new userClassClient();
        private string userName;
        private string userRank;
        public int clientID;

        public frmUserHome(string userName, string userRank, int clientID)
        {
            InitializeComponent();
            this.userName = userName;
            this.userRank = userRank;
            this.clientID = clientID;
        }

       

        private void frmUserHome_Load(object sender, EventArgs e)
        {
            lblUserName.Text = userName;
            lblUserRank.Text = userRank;
            lblClientID.Text = clientID.ToString();
            ucc = new userClassClient(int.Parse(lblClientID.Text));
            dgvClient.DataSource = ucc.GetClient();
        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void metroContextMenu1_Opening(object sender, CancelEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog open = new OpenFileDialog();
            //open.Filter = "Image Files( *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            //if (open.ShowDialog() == DialogResult.OK)
            //{
            //    picAvatar.Image = new Bitmap(open.FileName);
            //}
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
        }
    }
}