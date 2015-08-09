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
    public partial class Form_Insert_Doctor : Form
    {
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataAdapter sqlDbAdapter;
        DataTable dtDoctor;
        public Form_Insert_Doctor()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlString = "Data Source = localhost;Initial Catalog=s213200619;Integrated Security = SSPI;";
                sqlCon = new SqlConnection(sqlString);
                sqlCom = new SqlCommand("Select * From Doctor", sqlCon);
                sqlDbAdapter = new SqlDataAdapter(sqlCom);
                dtDoctor = new DataTable();
                sqlDbAdapter.Fill(dtDoctor);
                dgvDoctor.DataSource = dtDoctor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                
                string sqlString = "Data Source = localhost;Initial Catalog=s213200619;Integrated Security = SSPI;";

                sqlCon = new SqlConnection(sqlString);
                sqlCon.Open();
                string sqlInsert = "spInsertDoc '" + txtDocID.Text + "' , '" + txtDocSurname.Text + "' , '" + txtDocFirstName.Text + "' , '" + txtDocCellNum.Text + " ' ";
                sqlCom = new SqlCommand(sqlInsert, sqlCon);
                int x = sqlCom.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
    }
}
