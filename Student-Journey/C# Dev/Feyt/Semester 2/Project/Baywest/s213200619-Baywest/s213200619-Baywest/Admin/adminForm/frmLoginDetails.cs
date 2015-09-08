using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using s213200619_Baywest.Admin.adminClass;

namespace s213200619_Baywest.Admin.adminForm
{
    public partial class frmLoginDetails : MetroForm
    {
        private classLoginDetails cld = new classLoginDetails();
        public frmLoginDetails()
        {
            InitializeComponent();
        }

        private void frmLoginDetails_Load(object sender, EventArgs e)
        {
            metroDgvLogin.DataSource = cld.GetAllLogin();
            metroDgvRequestLogin.DataSource = cld.GetAllLogin();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroDgvLogin_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                metroTxtID.Text = metroDgvLogin[0, e.RowIndex].Value.ToString();
                metroTxtUserName.Text = metroDgvLogin[1, e.RowIndex].Value.ToString();
                metroTxtRank.Text = metroDgvLogin[2, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void metroDgvRequestLogin_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                metroTxtID.Text = metroDgvRequestLogin[0, e.RowIndex].Value.ToString();
                metroTxtUserName.Text = metroDgvRequestLogin[1, e.RowIndex].Value.ToString();
                metroTxtRank.Text = metroDgvRequestLogin[2, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
