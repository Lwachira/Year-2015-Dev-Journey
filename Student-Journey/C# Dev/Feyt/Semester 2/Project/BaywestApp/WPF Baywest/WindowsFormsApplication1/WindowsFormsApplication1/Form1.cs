using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void rentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRental rental = new frmRental();
            this.Visible = false;
            rental.ShowDialog();
            this.Visible = true;
        }

        private void shopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShop shop = new frmShop();
            this.Visible = false;
            shop.ShowDialog();
            this.Visible = true;
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClient client = new frmClient();
            this.Visible = false;
            client.ShowDialog();
            this.Visible = true;
        }
    }
}