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
    public partial class frmDoctor : Form
    {
        public frmDoctor()
        {
            InitializeComponent();
        }

        private OleDbConnection dbConn;
        private OleDbCommand dbCom;
        private string conString;
        private OleDbDataAdapter dbAdapter;
        private DataSet ds;

        private void frmDoctor_Load(object sender, EventArgs e)
        {
            try
            {
                conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source = PracticeXYZ.accdb";
                dbConn = new OleDbConnection(conString);
                dbCom = new OleDbCommand("Select * From  Doctor", dbConn);
                dbAdapter = new OleDbDataAdapter(dbCom);
                ds = new DataSet();
                dbAdapter.Fill(ds, "myDoctors");
                lstDoctor.DataSource = ds.Tables["myDoctors"];
            }
            catch (Exception f)
            {

                MessageBox.Show(f.Message);
            }

            finally
            {
                dbConn.Close();
            }
        }
    }
}
