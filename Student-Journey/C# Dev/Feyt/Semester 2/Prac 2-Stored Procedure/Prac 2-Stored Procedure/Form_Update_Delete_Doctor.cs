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
    public partial class Form_Update_Delete_Doctor : Form
    {
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataAdapter sqlDbAdapter;
        DataTable dtDoctor;
        public Form_Update_Delete_Doctor()
        {
            InitializeComponent();
        }

        private void dgvUpdateDoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                
            
        }

        private void Form_Update_Delete_Doctor_Load(object sender, EventArgs e)
        {
            try
            {
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
                int i = e.RowIndex;

                txtDocID.Text = dgvUpdateDoc[0,i].Value.ToString();
                txtDocSurname.Text = dgvUpdateDoc[1, i].Value.ToString();
                txtDocFirstName.Text = dgvUpdateDoc[2, i].Value.ToString();
                txtDocCellNum.Text = dgvUpdateDoc[3, i].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                int i = 0;
            }
           
        }
    }
}
