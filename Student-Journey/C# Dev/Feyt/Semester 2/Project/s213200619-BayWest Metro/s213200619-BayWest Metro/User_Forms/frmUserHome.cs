using MetroFramework.Forms;
using s213200619_BayWest_Metro.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s213200619_BayWest_Metro.User_Forms
{
    public partial class frmUserHome : MetroForm
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

        private void btnChangePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files( *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picAvatar.Image = new Bitmap(open.FileName);
            }
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
        }

        private void rentalAgreementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userRentalAgreement ra = new userRentalAgreement();
            ra.ShowDialog();
        }
    }
}