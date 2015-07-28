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
    public partial class XYZ_Form : Form
    {
        private OleDbConnection dbConnect;
        private OleDbCommand dbCom;
        private OleDbDataReader dbReader;
        private string sConnect;
        private string sql;
         XYZ [] ProductDetailsTable = new XYZ [100];
        int count = 0;
        int i = 0;

        SingleViewForms singleForm;
        AllProduct allProds;
        public XYZ_Form()
            
        {
            InitializeComponent();
        }

        private void XYZ_Form_Load(object sender, EventArgs e)
        {
            try
            {
                sConnect = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = XYZCompany.accdb";

                dbConnect = new OleDbConnection(sConnect);
                dbConnect.Open();//Good Practice to put this last incase something bad happens.

                sql = "Select * From ProductDetails Order By ProductCategory Asc;";
                dbCom = new OleDbCommand();
                dbCom.CommandText = sql;

                dbCom.Connection = dbConnect;


                dbReader = dbCom.ExecuteReader();

                while (dbReader.Read())
                {

                    //cmbProdCat.Items.Add(dbReader["ProductCategory"]);

                    ProductDetailsTable[count] = new XYZ(dbReader["ProductNumber"].ToString(), dbReader["ProductDescription"].ToString(), double.Parse(dbReader["ProductCost"].ToString()), dbReader["ProductCategory"].ToString());
                    cmbProdCat.Items.Add(ProductDetailsTable[count].ProdCat);


                    count++;

                }
            }
            catch (Exception)
            {

                
            }
            finally
            {
                dbReader.Close();
                dbConnect.Close();
            }
           

          
           

          


        }

        private void cmbProdCat_SelectedIndexChanged(object sender, EventArgs e)
        {

       
            for (int p = 0; p < count; p++)
            {
                if (p == cmbProdCat.SelectedIndex)
                {
                    txtProdNum.Text = ProductDetailsTable[p].ProdNum.ToString();
                    txtProdCost.Text = ProductDetailsTable[p].ProdCost.ToString();
                    txtProdDes.Text = ProductDetailsTable[p].ProdDesc.ToString();
                  
                }
            }
            
            
        
           
            
        }

        private void productViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            singleForm = new SingleViewForms();
            singleForm.ShowDialog();
            this.Show();
           


        }

        private void allProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            allProds = new AllProduct();
            allProds.ShowDialog();
            this.Show();
        }
    }
}
