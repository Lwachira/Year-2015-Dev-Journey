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
    public partial class frmUpdateDoc : Form
    {
        OleDbCommand dbCom;
        OleDbConnection dbConn;
        string conString;
        DataSet ds;
        OleDbDataAdapter dbAdapter;
        int i;
        string sql;
        public frmUpdateDoc()
        {
            InitializeComponent();
        }

        private void frmUpdateDoc_Load(object sender, EventArgs e)
        {

            try
            {
                conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source = PracticeXYZ.accdb";
                dbConn = new OleDbConnection(conString);
                dbCom = new OleDbCommand("Select * From  Doctor", dbConn);
                dbAdapter = new OleDbDataAdapter(dbCom);
                ds = new DataSet();
                dbAdapter.Fill(ds, "myDoctors");
                dgvDoctorView.DataSource = ds.Tables["myDoctors"];
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



        private void dgvDoctorView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDoctorView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                i = e.RowIndex;
                DataGridViewRow row = dgvDoctorView.Rows[i];
                txtDocID.Text = row.Cells[0].Value.ToString();
                txtDocSurname.Text = row.Cells[1].Value.ToString();
                txtDocFirstName.Text = row.Cells[2].Value.ToString();
                txtDocCellNum.Text = row.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void dgvDoctorView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {



            try
            {

                sql = "Update Doctor Set  Doctor Surname = @sName,Doctor First Name = @fName,Doctor Cell No = @docCellNum Where Doctor ID = @ID";
                conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source = PracticeXYZ.accdb";
                dbConn = new OleDbConnection(conString);
                dbConn.Open();
                dbCom = new OleDbCommand(sql, dbConn);
                dbCom.Parameters.AddWithValue("@ID", txtDocID.Text.ToString());
                dbCom.Parameters.AddWithValue("@sName", txtDocSurname.Text).ToString();
                dbCom.Parameters.AddWithValue("@fName", txtDocFirstName.Text.ToString());
                dbCom.Parameters.AddWithValue("@docCellNum", txtDocCellNum.Text.ToString());
                int x = dbCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConn.Close();
            }


        }
    }
}
