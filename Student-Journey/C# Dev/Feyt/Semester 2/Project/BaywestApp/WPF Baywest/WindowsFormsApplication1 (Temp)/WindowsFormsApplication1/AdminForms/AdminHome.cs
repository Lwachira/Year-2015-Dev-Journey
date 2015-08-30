using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.AdminForms;

namespace WindowsFormsApplication1
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void rentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRental rental = new frmRental();
            this.Visible = false;
            rental.ShowDialog();
            this.Visible = true;
        }

        private void loginDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Visible = false;
            login.ShowDialog();
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

        private void serviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmService service = new frmService();
            this.Visible = false;
            service.ShowDialog();
            this.Visible = true;
        }

        private void staffToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmStaff staff = new frmStaff();
            this.Visible = false;
            staff.ShowDialog();
            this.Visible = true;
        }

        private void callsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalls calls = new frmCalls();
            this.Visible = false;
            calls.ShowDialog();
            this.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void assignedCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssignedCall assignedCall = new frmAssignedCall();
            this.Visible = false;
            assignedCall.ShowDialog();
            this.Visible = true;
        }
    }
}