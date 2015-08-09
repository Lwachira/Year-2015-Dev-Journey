using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prac_2_Stored_Procedure
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("I built my app from the ground up since the last");

            try
            {
                DataTable dtAppointments = new DataTable();
                string sqlConnection = "Data Source = localhost;Initial Catalog = s213200619;Integrated Security = SSPI";
                SqlConnection sqlConn = new SqlConnection(sqlConnection);
                SqlCommand sqlComm = new SqlCommand("sp_GetAppointments", sqlConn);
                SqlDataAdapter dbAdapter = new SqlDataAdapter(sqlComm);
                dbAdapter.Fill(dtAppointments);

                dgvAppointments.DataSource = dtAppointments;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void appointmentsByDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDoctor frmDoctor = new formDoctor();
            this.Visible = false;
            frmDoctor.ShowDialog();
            this.Visible = true;
        }

        private void insertDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Insert_Doctor frmInsertDoc = new Form_Insert_Doctor();
            this.Visible = false;
            frmInsertDoc.ShowDialog();
            this.Visible = true;
        }

        private void delteUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Update_Delete_Doctor frmUpdate = new Form_Update_Delete_Doctor();
            this.Visible = false;
            frmUpdate.ShowDialog();
            this.Visible = true;
        }
    }
}
