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
                MessageBox.Show(ex.Message);
            }

            return x;
        }

        public int InsertRental(classRental r)
        {
            if (sqlCon.State == ConnectionState.Closed)

                sqlCon.Open();
            int x = 1;
            try
            {
                string sql = "spInsertRental '" + r.RentalID + "','" + r.ClientID + "','" + r.ShopID + "','" + r.StartDate + "','" + r.EndDate + "','" + r.RentalStatus + "'";
                sqlCom = new SqlCommand(sql, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return x;
        }

        public int DeleteRental(classRental r)
        {
            if (sqlCon.State == ConnectionState.Closed)

                sqlCon.Open();
            int x = 1;
            try
            {
                string sql = "spDeleteRental '" + r.RentalID + "'";
                sqlCom = new SqlCommand(sql, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return x;
        }

        public DataTable GetShop()
        {
            if (sqlCon.State == ConnectionState.Closed)

                sqlCon.Open();
            DataTable dbShop = new DataTable();
            try
            {
                sqlCom = new SqlCommand("spGetAllShop", sqlCon);
                sqlDbAdapter = new SqlDataAdapter(sqlCom);
                sqlDbAdapter.Fill(dbShop);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dbShop;
        }

        public int InsertShop(classShop cr)
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            int x = 1;

            try
            {
                string sqlInsert = "spInsertShop ' " + cr.ShopID + "','" + cr.ShopName + "','" + cr.ShopSize + "'";
                sqlCom = new SqlCommand(sqlInsert, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return x;
        }

        public int DeleteShop(classShop cr)
        {
            if (sqlCon.State == ConnectionState.Closed)

                sqlCon.Open();
            int x = 1;
            try
            {
                string sql = "spDeleteShop '" + cr.ShopID + "'";
                sqlCom = new SqlCommand(sql, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return x;
        }

        public int updateShop(classShop cr)
        {
            if (sqlCon.State == ConnectionState.Closed)

                sqlCon.Open();

            int x = 1;

            DataTable dbUpRental = new DataTable();
            try
            {
                string sql = "spUpdateShop '" + cr.ShopID + "','" + cr.ShopName + "','" + cr.ShopSize + "'";
                sqlCom = new SqlCommand(sql, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return x;
        }

        public DataTable GetAllClient()
        {
            if (sqlCon.State == ConnectionState.Closed)

                sqlCon.Open();
            DataTable dbShop = new DataTable();
            try
            {
                sqlCom = new SqlCommand("spGetAllClient", sqlCon);
                sqlDbAdapter = new SqlDataAdapter(sqlCom);
                sqlDbAdapter.Fill(dbShop);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dbShop;
        }
    }
}