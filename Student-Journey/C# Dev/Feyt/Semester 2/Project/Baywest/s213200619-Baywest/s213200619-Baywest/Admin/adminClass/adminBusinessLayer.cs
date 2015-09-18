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

        public int insertLogin(classLoginDetails cld)
        {
            int x = 1;
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();

                }


                string sqlInsert = "spInsertLogin '" + cld.LoginID + "','" + cld.LoginUserName + "','" + cld.LoginRank + "'";
                sqlCom = new SqlCommand(sqlInsert, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return x;
        }

        public int deleteLogin(classLoginDetails cld)
        {
            int x = 1;
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                string sqlDelete = "spDeleteLogin '" + cld.LoginID + "'";
                sqlCom = new SqlCommand(sqlDelete, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return x;
        }

        public int updateLogin(classLoginDetails cld)
        {
            int x = 1;

            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                string sqlUpdate = "spUpdateLogin '" + cld.LoginID + "','" + cld.LoginUserName + "','" + cld.LoginRank + "'";
                sqlCom = new SqlCommand(sqlUpdate, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return x;
        }


        public DataTable getAllCustomer()
        {
            DataTable dbCustomer = new DataTable();
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                sqlCom = new SqlCommand("SpGetCustomer", sqlCon);
                sqlDbAdapter = new SqlDataAdapter(sqlCom);
                sqlDbAdapter.Fill(dbCustomer);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return dbCustomer;
        }

        public int insertCustomer(adminCustomer ac)
        {
            int x = 1;
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                sqlCom = new SqlCommand("spInsertCustomer '" + ac.CustomerID + "','" + ac.CustomerName + "','" + ac.CustomerCell + "','" + ac.LoginID + "'", sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return x;


        }


        public int deleteCustomer(adminCustomer ac)
        {
            int x = 1;
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                string sqlDelete = "spDeleteCustomer '" + ac.CustomerID + "'";
                sqlCom = new SqlCommand(sqlDelete, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return x;
        }

        public int updateCustomer(adminCustomer ac)
        {
            int x = 1;

            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                string sqlUpdate = "spUpdateCustomer '" + ac.CustomerID + "','" + ac.CustomerName + "','" + ac.CustomerCell + "','" + ac.LoginID + "'";
                sqlCom = new SqlCommand(sqlUpdate, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return x;
        }




        public DataTable getAllRental()
        {
            DataTable dbCustomer = new DataTable();
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                sqlCom = new SqlCommand("spGetAllRental", sqlCon);
                sqlDbAdapter = new SqlDataAdapter(sqlCom);
                sqlDbAdapter.Fill(dbCustomer);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return dbCustomer;
        }

        public int insertRental(adminRentalAgreement ara)
        {
            int x = 1;
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                sqlCom = new SqlCommand("spInsertRental '" + ara.RentalID + "','" + ara.CustomerID + "','" + ara.ShopID + "','" + ara.RentalStartDate + "','" + ara.RentalEndDate + "'", sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return x;


        }


        public int deleteRental(adminRentalAgreement ara)
        {
            int x = 1;
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                string sqlDelete = "spDeleteRental '" + ara.RentalID + "'";
                sqlCom = new SqlCommand(sqlDelete, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return x;
        }

        public int updateRental(adminRentalAgreement ara)
        {
            int x = 1;

            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                string sqlUpdate = "spUpdateRental '" + ara.RentalID + "','" + ara.CustomerID + "','" + ara.ShopID + "','" + ara.RentalStartDate + "','" + ara.RentalEndDate + "'";
                sqlCom = new SqlCommand(sqlUpdate, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return x;
        }





        public DataTable getAllShop()
        {
            DataTable dbShop = new DataTable();
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
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

        public int insertShop(adminShop asp)
        {
            int x = 1;
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                sqlCom = new SqlCommand("spInsertShop '" + asp.ShopID + "','" + asp.ShopName + "','" + asp.ShopSize + "'", sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return x;


        }


        public int deleteShop(adminShop asp)
        {
            int x = 1;
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                string sqlDelete = "spDeleteShop '" + asp.ShopID + "'";
                sqlCom = new SqlCommand(sqlDelete, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return x;
        }

        public int updateShop(adminShop asp)
        {
            int x = 1;

            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                string sqlUpdate = "spUpdateShop '" + asp.ShopID + "','" + asp.ShopName + "','" + asp.ShopSize + "'";
                sqlCom = new SqlCommand(sqlUpdate, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return x;
        }


        public DataTable getAllShopService()
        {
            DataTable dbShopService = new DataTable();
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                sqlCom = new SqlCommand("spGetAllShopService", sqlCon);
                sqlDbAdapter = new SqlDataAdapter(sqlCom);
                sqlDbAdapter.Fill(dbShopService);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return dbShopService;
        }

        public int insertShopService(adminShopService asps)
        {
            int x = 1;

            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                string sqlInsert = "spInsertShopService '" + asps.ShopServiceID + "','" + asps.ShopID + "','" + asps.ServiceID + "','" + asps.ServiceName + "'";
                sqlCom = new SqlCommand(sqlInsert, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return x;
        }

        public int deleteShopService(adminShopService asps)
        {
            int x = 1;
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                string sqlDelete = "spDeleteShopService '" + asps.ShopServiceID + "'";
                sqlCom = new SqlCommand(sqlDelete, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return x;
        }

        public int updateShopService(adminShopService asps)
        {
            int x = 1;

            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                string sqlUpdate = "spUpdateShopService '" + asps.ShopServiceID + "','" + asps.ShopID + "','" + asps.ServiceID + "','" + asps.ServiceName + "'";
                sqlCom = new SqlCommand(sqlUpdate, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return x;
        }


        public DataTable getAllShopInspection()
        {
            DataTable dbShopInspection = new DataTable();
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                sqlCom = new SqlCommand("spGetAllShopInspection", sqlCon);
                sqlDbAdapter = new SqlDataAdapter(sqlCom);
                sqlDbAdapter.Fill(dbShopInspection);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return dbShopInspection;
        }

        public int insertShopInspection(adminShopInspection asi)
        {
            int x = 1;

            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                string sqlInsert = "spInsertShopInspection '" + asi.InspectionID + "','" + asi.ShopID + "','" + asi.ServiceID + "','" + asi.StartDate + "','" + asi.EndDate + "','" + asi.InspectionTask + "','" + asi.Message + "'";
                sqlCom = new SqlCommand(sqlInsert, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return x;
        }

        public int deleteShopInspection(adminShopInspection asi)
        {
            int x = 1;
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                string sqlDelete = "spDeleteShopInspection '" + asi.InspectionID + "'";
                sqlCom = new SqlCommand(sqlDelete, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return x;
        }

        public int updateShopInspection(adminShopInspection asi)
        {
            int x = 1;

            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                string sqlUpdate = "spUpdateShopInspection '" + asi.InspectionID + "','" + asi.ShopID + "','" + asi.ServiceID + "','" + asi.StartDate + "','" + asi.EndDate + "','" + asi.InspectionTask + "','" + asi.Message + "'";
                sqlCom = new SqlCommand(sqlUpdate, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return x;
        }



        public DataTable getAllShopUpgrade()
        {
            DataTable dbShopInspection = new DataTable();
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                sqlCom = new SqlCommand("spGetAllShopUpgrade", sqlCon);
                sqlDbAdapter = new SqlDataAdapter(sqlCom);
                sqlDbAdapter.Fill(dbShopInspection);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return dbShopInspection;
        }

        public int insertShopUpgrade(adminShopUpgrade asu)
        {
            int x = 1;

            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                string sqlInsert = "spInsertShopUpgrade '" + asu.UpgradeID + "','" + asu.ShopID + "','" + asu.ServiceID + "','" + asu.StartDate + "','" + asu.EndDate + "','" + asu.UpgradeTask + "','" + asu.CompletionMessage + "'";
                sqlCom = new SqlCommand(sqlInsert, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return x;
        }

        public int deleteShopUpgrade(adminShopUpgrade asu)
        {
            int x = 1;
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                string sqlDelete = "spDeleteShopUpgrade '" + asu.UpgradeID + "'";
                sqlCom = new SqlCommand(sqlDelete, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return x;
        }

        public int updateShopUpgrade(adminShopUpgrade asu)
        {
            int x = 1;

            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                string sqlUpdate = "spUpdateShopUpgrade '" + asu.UpgradeID + "','" + asu.ShopID + "','" + asu.ServiceID + "','" + asu.StartDate + "','" + asu.EndDate + "','" + asu.UpgradeTask + "','" + asu.CompletionMessage + "'";
                sqlCom = new SqlCommand(sqlUpdate, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return x;
        }

    }


}
