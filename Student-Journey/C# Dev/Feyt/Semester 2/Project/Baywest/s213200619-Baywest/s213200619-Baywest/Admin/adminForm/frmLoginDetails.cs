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
using System.IO;

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

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            try
            {
                metroDgvRequestLogin.DataSource = helperClass.DataTableFromTextFile(@"Files\registration.txt", '#');

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeletedUser_Click(object sender, EventArgs e)
        {
            try
            {
                metroDgvRequestLogin.DataSource = helperClass.DataTableFromTextFile(@"Files\deletedLoginDetails.txt", '#');
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                cld = new classLoginDetails(int.Parse(metroTxtID.Text), metroTxtUserName.Text, metroTxtRank.Text);
                metroDgvLogin.DataSource = cld.InsertLogin();
                metroDgvLogin.DataSource = cld.GetAllLogin();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            metroDgvLogin.DataSource = cld.GetAllLogin();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cld = new classLoginDetails(int.Parse(metroTxtID.Text), metroTxtUserName.Text, metroTxtRank.Text);
            metroDgvLogin.DataSource = cld.UpdateLogin();
            metroDgvLogin.DataSource = cld.GetAllLogin();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter file = new StreamWriter(@"Files\deletedLoginDetails.txt", true);
                //file.WriteLine(metroLabel1.Text + "#" + metroLabel2.Text + "#" + metroLabel3.Text);
                file.WriteLine(metroTxtID.Text + "#" + metroTxtUserName.Text + "#" + metroTxtRank.Text);
                file.Close();
                cld = new classLoginDetails(int.Parse(metroTxtID.Text), metroTxtUserName.Text, metroTxtRank.Text);
                metroDgvLogin.DataSource = cld.DeleteLogin();
                metroDgvLogin.DataSource = cld.GetAllLogin();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
