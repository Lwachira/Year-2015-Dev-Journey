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
    public partial class formDoctor : Form
    {
        public formDoctor()
        {
            InitializeComponent();
        }

        private void formDoctor_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtDoctor = new DataTable();
                string sqlString = "Data Source = localhost; Initial Catalog = s213200619; Integrated Security = SSPI";
                SqlConnection sqlCon = new SqlConnection(sqlString);
                SqlCommand sqlCom = new SqlCommand("SpAllDoctors",sqlCon);
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCom);
                sqlAdapter.Fill(dtDoctor);

                dgvDoctor.DataSource = dtDoctor;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
    }
}
