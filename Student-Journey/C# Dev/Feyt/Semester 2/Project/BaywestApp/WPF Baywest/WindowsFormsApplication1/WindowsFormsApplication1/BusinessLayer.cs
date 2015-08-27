using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    internal class BusinessLayer
    {
        private SqlCommand sqlCom;
        private SqlConnection sqlCon;
        private SqlDataAdapter sqlDbAdapter;
        private SqlConnectionStringBuilder sqlBuilder;

        public BusinessLayer()
        {
            try
            {
                sqlBuilder = new SqlConnectionStringBuilder();
                sqlBuilder.DataSource = "DESKTOP-L1L70CN";
                sqlBuilder.InitialCatalog = "RentalSystem_213200619";
                sqlBuilder.IntegratedSecurity = true;
                sqlCon = new SqlConnection(sqlBuilder.ConnectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable GetRental()
        {
            if (sqlCon.State == ConnectionState.Closed)

                sqlCon.Open();
            DataTable dbRental = new DataTable();
            try
            {
                sqlCom = new SqlCommand("spGetAllRental", sqlCon);
                sqlDbAdapter = new SqlDataAdapter(sqlCom);
                sqlDbAdapter.Fill(dbRental);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dbRental;
        }

        public int UpdateRental(classRental r)
        {
            if (sqlCon.State == ConnectionState.Closed)

                sqlCon.Open();

            int x = 1;

            DataTable dbUpRental = new DataTable();
            try
            {
                string sql = "spUpdateRental '" + r.ClientID + "','" + r.ShopID + "','" + r.StartDate + "','" + r.EndDate + "','" + r.RentalStatus + "','" + r.RentalID + "'";
                sqlCom = new SqlCommand(sql, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "hi");
            }

            return x;
        }
    }
}