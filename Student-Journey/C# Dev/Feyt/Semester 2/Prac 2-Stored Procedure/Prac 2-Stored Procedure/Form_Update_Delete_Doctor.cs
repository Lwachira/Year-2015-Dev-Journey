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
using System.Globalization;
namespace Prac_2_Stored_Procedure
{
    public partial class Form_Update_Delete_Doctor : Form
    {
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataAdapter sqlDbAdapter;
        DataTable dtDoctor;


        public Form_Update_Delete_Doctor()
        {
            InitializeComponent();
            string sqlString = "Data Source = localhost;Initial Catalog=s213200619;Integrated Security = SSPI;";
            sqlCon = new SqlConnection(sqlString);
        }

        private void dgvUpdateDoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void Form_Update_Delete_Doctor_Load(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();

                }

                string sqlString = "Data Source = localhost;Initial Catalog=s213200619;Integrated Security = SSPI;";
                sqlCon = new SqlConnection(sqlString);
                sqlCom = new SqlCommand("Select * From Doctor", sqlCon);
                sqlDbAdapter = new SqlDataAdapter(sqlCom);
                dtDoctor = new DataTable();
                sqlDbAdapter.Fill(dtDoctor);
                dgvUpdateDoc.DataSource = dtDoctor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvUpdateDoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();

                }

                int r = e.RowIndex;

                txtDocID.Text = dgvUpdateDoc[0, r].Value.ToString();
                txtDocSurname.Text = dgvUpdateDoc[1, r].Value.ToString();
                txtDocFirstName.Text = dgvUpdateDoc[2, r].Value.ToString();
                txtDocCellNum.Text = dgvUpdateDoc[3, r].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();

                }

                string sqlString = "Data Source = localhost;Initial Catalog=s213200619;Integrated Security = SSPI;";
                sqlCon = new SqlConnection(sqlString);
                sqlCom = new SqlCommand("Select * From Doctor", sqlCon);
                sqlDbAdapter = new SqlDataAdapter(sqlCom);
                dtDoctor = new DataTable();
                sqlDbAdapter.Fill(dtDoctor);
                dgvUpdateDoc.DataSource = dtDoctor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            string sqlString = "Data Source = localhost;Initial Catalog=s213200619;Integrated Security = SSPI;";
            sqlCon = new SqlConnection(sqlString);

            if (MessageBox.Show("You really want to do this", "Delete Buyer", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();

                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                try
                {
                    sqlCom = new SqlCommand("Delete Doctor Where Doctor.[Doctor ID] =@DoctorID", sqlCon);
                    sqlCom.Parameters.AddWithValue("@DoctorID", txtDocID.Text);
                    int i = sqlCom.ExecuteNonQuery();

                    if (i > 0)
                    {
                        DataSet ds = new DataSet();
                        sqlCom = new SqlCommand("Select * From Doctor;", sqlCon);
                        sqlDbAdapter = new SqlDataAdapter();
                        sqlDbAdapter.Fill(ds, "UpdateDoctor");
                        MessageBox.Show("Done");

                        dgvUpdateDoc.Refresh();
                        dgvUpdateDoc.DataSource = ds.Tables["UpdatedDoctor"];

                    }
                }
                catch (Exception ef)
                {
                    MessageBox.Show(ef.Message);
                }

            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Form_Insert_Doctor frmInsertDoc = new Form_Insert_Doctor();
            this.Visible = false;
            frmInsertDoc.ShowDialog();
            this.Visible = true;
        }
    }
}

