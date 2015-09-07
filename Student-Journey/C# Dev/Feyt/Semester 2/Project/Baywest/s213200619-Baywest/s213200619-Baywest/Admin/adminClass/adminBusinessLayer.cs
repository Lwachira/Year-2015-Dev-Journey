using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace s213200619_Baywest.Admin.adminClass
{
    public class adminBusinessLayer
    {
        private SqlCommand sqlCom;
        private SqlConnection sqlCon;
        private SqlDataAdapter sqlDbAdapter;
        private SqlConnectionStringBuilder sqlBuilder;


        public adminBusinessLayer()
        {
            try
            {
                sqlBuilder = new SqlConnectionStringBuilder();
                sqlBuilder.DataSource = "";
                sqlBuilder.InitialCatalog = "Baywest_213200619";
                sqlBuilder.IntegratedSecurity = true;
                sqlCon = new SqlConnection(sqlBuilder.ConnectionString);



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }


        public DataTable GetAllLogin()
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            DataTable dbLoginTable = new DataTable();
            try
            {

                sqlCom = new SqlCommand("spGetLogin", sqlCon);
                sqlDbAdapter = new SqlDataAdapter(sqlCom);
                sqlDbAdapter.Fill(dbLoginTable);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return dbLoginTable;

        }

    }


}
