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

namespace Practical_6___SD___Database_Access
{
    public partial class AllProduct : Form
    {
        XYZ[] AllProducts = new XYZ[100];
        private OleDbConnection dbConnect;
        private OleDbCommand dbCom;
        private OleDbDataReader dbReader;
        private string sConnect;
        private string sql;
        int counter = 0;

        public AllProduct()
        {
            InitializeComponent();
        }

        private void AllProduct_Load(object sender, EventArgs e)
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
                    AllProducts[counter] = new XYZ(dbReader["ProductNumber"].ToString(), dbReader["ProductDescription"].ToString(), double.Parse(dbReader["ProductCost"].ToString()), dbReader["ProductCategory"].ToString());


                    counter++;

                }

                for (int i = 0; i < counter; i++)
                {
                    dgvProducts.Rows.Add(AllProducts[i].ProdNum.ToString(), AllProducts[i].ProdDesc.ToString(), AllProducts[i].ProdCost.ToString(), AllProducts[i].ProdCat.ToString());

                }
            }


            catch (Exception f)
            {

                MessageBox.Show(f.Message);
            }
           finally
            {

            }

        }
    }
}
