using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.UsersForms;

namespace WindowsFormsApplication1
{
    public partial class frmUserHome : Form
    {
        private string text;

        public frmUserHome(string id)
        {
            InitializeComponent();
            this.text = id;
        }

        private void rentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmURental rental = new frmURental();
            this.Visible = false;
            rental.ShowDialog();
            this.Visible = true;
        }

        private void frmUserHome_Load(object sender, EventArgs e)
        {
            label1.Text = text;
        }
    }
}