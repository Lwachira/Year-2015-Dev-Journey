using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BayWest
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
        }

        private void frmWelcome_Click(object sender, EventArgs e)
        {
            Home myHome = new Home();

            this.Visible = false;
            myHome.ShowDialog();
            this.Visible = true;
        }
    }
}