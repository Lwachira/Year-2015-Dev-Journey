using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Practical_6___SD___Database_Access
{
    public partial class SingleViewForms : Form
    {
        private OleDbConnection dbConnect;
        private OleDbCommand dbCom;
        private OleDbDataReader dbReader;
        private string sConnect;
        private string sql;
        int counter = 0;
        int i = 0;
   
        XYZ[] singleProd = new XYZ[100];
        public SingleViewForms()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {


           
            try
            {
                if (i < counter)
                {
                    lstProd.Items.Clear();
                    lstProd.Items.Add(singleProd[i].ProdDesc);
                    
                }
            }
            catch (Exception f)
            {

                MessageBox.Show(f.Message);
            }

            i++;



        }

        private void SingleViewForms_Load(object sender, EventArgs e)
        {
            try
            {
                sConnect = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = XYZCompany.accdb";
                dbConnect = new OleDbConnection(sConnect);
                dbConnect.Open();
                sql = "Select * From ProductDetails Order By ProductCategory Asc;";
                dbCom = new OleDbCommand();
                dbCom.CommandText = sql;
                dbCom.Connection = dbConnect;
                dbReader = dbCom.ExecuteReader();


                while (dbReader.Read())
                {
                    singleProd[counter] = new XYZ(dbReader["ProductDescription"].ToString());
                    counter++;

                }
            }
            catch (Exception f)
            {

                MessageBox.Show(f.Message);
                
            }

            finally
            {
                dbReader.Close();
                dbConnect.Close();
            }
            
           
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
           

        }
       
       
    }
}
