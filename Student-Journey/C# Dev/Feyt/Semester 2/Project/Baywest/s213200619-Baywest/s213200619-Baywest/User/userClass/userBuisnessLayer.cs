using s213200619_Baywest.Admin.adminClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s213200619_Baywest.User.userClass
{
    internal class userBuisnessLayer
    {
        private classLoginDetails cld = new classLoginDetails();
        private SqlCommand sqlCom;
        private SqlConnection sqlConn;
        private SqlDataAdapter sqlDbAdapter;
        private SqlConnectionStringBuilder sqlBuilder;

        public userBuisnessLayer()
        {
            try
            {
                sqlBuilder = new SqlConnectionStringBuilder();
                sqlBuilder.DataSource = "";
                sqlBuilder.InitialCatalog = "Baywest_213200619";
                sqlBuilder.IntegratedSecurity = true;
                sqlConn = new SqlConnection(sqlBuilder.ConnectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable getMyUser(int id)
        {
            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                    sqlConn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DataTable DBcustomerTable = new DataTable();
            try
            {
                sqlCom = new SqlCommand("spGetUser '" + id.ToString() + "'", sqlConn);
                sqlDbAdapter = new SqlDataAdapter(sqlCom);
                sqlDbAdapter.Fill(DBcustomerTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return DBcustomerTable;
        }

        public DataTable getRental(int custID)
        {
            DataTable dbRentalTable = new DataTable();
            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                {
                    sqlConn.Open();
                }

                sqlCom = new SqlCommand("spGetRental '" + custID.ToString() + "'", sqlConn);
                sqlDbAdapter = new SqlDataAdapter(sqlCom);
                sqlDbAdapter.Fill(dbRentalTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dbRentalTable;
        }

        public DataTable getShop(int shopID)
        {
            DataTable dbShop = new DataTable();
            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                {
                    sqlConn.Open();
                }

                sqlCom = new SqlCommand("spGetShop '" + shopID.ToString() + "'", sqlConn);
                sqlDbAdapter = new SqlDataAdapter(sqlCom);
                sqlDbAdapter.Fill(dbShop);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dbShop;
        }

        public DataTable getShop_Service(int shopID)
        {
            DataTable dbShop_Service = new DataTable();
            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                {
                    sqlConn.Open();
                }

                sqlCom = new SqlCommand("spGetShop_Service '" + shopID + "'", sqlConn);
                sqlDbAdapter = new SqlDataAdapter(sqlCom);
                sqlDbAdapter.Fill(dbShop_Service);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dbShop_Service;
        }

        public DataTable getShopInspection(int id)
        {
            DataTable dbShopInspection = new DataTable();
            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                {
                    sqlConn.Open();
                }

                sqlCom = new SqlCommand("spGetShopInspection '" + id.ToString() + "'", sqlConn);
                sqlDbAdapter = new SqlDataAdapter(sqlCom);
                sqlDbAdapter.Fill(dbShopInspection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dbShopInspection;
        }

        public DataTable getShopUpgrade(int id)
        {
            DataTable dbUpgrade = new DataTable();
            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                {
                    sqlConn.Open();
                }

                sqlCom = new SqlCommand("spGetShopUpgrade '" + id.ToString() + "'", sqlConn);
                sqlDbAdapter = new SqlDataAdapter(sqlCom);
                sqlDbAdapter.Fill(dbUpgrade);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            return dbUpgrade;
        }
    }
}