using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Sem2Prac1
{
    public partial class frmAppMenu : Form
    {
        private string connString;
        private OleDbConnection dbConn;
        private OleDbCommand dbCom;
        private OleDbDataAdapter dbAdapter;

        DataSet ds;
        public frmAppMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source = PracticeXYZ.accdb";
                dbConn = new OleDbConnection(connString);

                dbCom = new OleDbCommand("Select * From Appointment", dbConn);
                ds = new DataSet();
                dbAdapter = new OleDbDataAdapter(dbCom);
                dbAdapter.Fill(ds, "MyAppointments");
                dgvAppoint.DataSource = ds.Tables["myAppointments"];

            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }



        }

        private void appointmentsByDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoctor formDoc = new frmDoctor();
            this.Visible = false;
            formDoc.ShowDialog();
            this.Visible = true;
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddDoctors formAddDoctor = new frmAddDoctors();
            this.Visible = false;
            formAddDoctor.ShowDialog();
            this.Visible = true;
        }
    }
}
