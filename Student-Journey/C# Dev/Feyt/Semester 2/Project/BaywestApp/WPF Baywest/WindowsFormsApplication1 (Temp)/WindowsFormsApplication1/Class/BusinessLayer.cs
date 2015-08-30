using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Class;

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
            DataTable db = new DataTable();
            try
            {
                sqlCom = new SqlCommand("spGetAllShop", sqlCon);
                sqlDbAdapter = new SqlDataAdapter(sqlCom);
                sqlDbAdapter.Fill(db);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return db;
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
            DataTable db = new DataTable();
            try
            {
                sqlCom = new SqlCommand("spGetAllClient", sqlCon);
                sqlDbAdapter = new SqlDataAdapter(sqlCom);
                sqlDbAdapter.Fill(db);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return db;
        }

        public int InsertClient(classClient cr)
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            int x = 1;

            try
            {
                string sqlInsert = "spInsertClient ' " + cr.ClientID + "','" + cr.ClientName + "','" + cr.ClientCell + "'";
                sqlCom = new SqlCommand(sqlInsert, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return x;
        }

        public int DeleteClient(classClient cr)
        {
            if (sqlCon.State == ConnectionState.Closed)

                sqlCon.Open();
            int x = 1;
            try
            {
                string sql = "spDeleteClient '" + cr.ClientID + "'";
                sqlCom = new SqlCommand(sql, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return x;
        }

        public int UpdateClient(classClient cr)
        {
            if (sqlCon.State == ConnectionState.Closed)

                sqlCon.Open();

            int x = 1;

            DataTable dbUpRental = new DataTable();
            try
            {
                string sql = "spUpdateClient '" + cr.ClientID + "','" + cr.ClientName + "','" + cr.ClientCell + "'";
                sqlCom = new SqlCommand(sql, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return x;
        }

        public DataTable GetAllService()
        {
            if (sqlCon.State == ConnectionState.Closed)

                sqlCon.Open();
            DataTable db = new DataTable();
            try
            {
                sqlCom = new SqlCommand("spGetAllService", sqlCon);
                sqlDbAdapter = new SqlDataAdapter(sqlCom);
                sqlDbAdapter.Fill(db);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return db;
        }

        public int InserService(classService cs)
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            int x = 1;

            try
            {
                string sqlInsert = "spInsertService ' " + cs.ServiceID + "','" + cs.ServiceName + "','" + cs.StaffID + "'";
                sqlCom = new SqlCommand(sqlInsert, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("Make sure that your using data that exist's ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return x;
        }

        public int DeleteService(classService cs)
        {
            if (sqlCon.State == ConnectionState.Closed)

                sqlCon.Open();
            int x = 1;
            try
            {
                string sql = "spDeleteService '" + cs.ServiceID + "'";
                sqlCom = new SqlCommand(sql, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return x;
        }

        public int UpdateService(classService cs)
        {
            if (sqlCon.State == ConnectionState.Closed)

                sqlCon.Open();

            int x = 1;

            DataTable dbUpRental = new DataTable();
            try
            {
                string sql = "spUpdateService '" + cs.ServiceID + "','" + cs.ServiceName + "','" + cs.StaffID + "'";
                sqlCom = new SqlCommand(sql, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return x;
        }

        public DataTable GetAllStaff()
        {
            if (sqlCon.State == ConnectionState.Closed)

                sqlCon.Open();
            DataTable db = new DataTable();
            try
            {
                sqlCom = new SqlCommand("spGetAllStaff", sqlCon);
                sqlDbAdapter = new SqlDataAdapter(sqlCom);
                sqlDbAdapter.Fill(db);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return db;
        }

        public int InsertStaff(classStaff cs)
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            int x = 1;

            try
            {
                string sqlInsert = "spInsertStaff ' " + cs.StaffID + "','" + cs.StaffName + "','" + cs.StaffCellNumber + "','" + cs.StaffType + "','" + cs.CallID + "'";
                sqlCom = new SqlCommand(sqlInsert, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (SqlException sx)
            {
                MessageBox.Show(sx.Message);
                MessageBox.Show("Make sure that your using data that exist's ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return x;
        }

        public int DeleteStaff(classStaff cs)
        {
            if (sqlCon.State == ConnectionState.Closed)

                sqlCon.Open();
            int x = 1;
            try
            {
                string sql = "spDeleteStaff '" + cs.StaffID + "'";
                sqlCom = new SqlCommand(sql, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return x;
        }

        public int UpdateStaff(classStaff cs)
        {
            if (sqlCon.State == ConnectionState.Closed)

                sqlCon.Open();

            int x = 1;

            DataTable dbUpRental = new DataTable();
            try
            {
                string sql = "spUpdateStaff '" + cs.StaffID + "','" + cs.StaffName + "','" + cs.StaffCellNumber + "','" + cs.StaffType + "','" + cs.CallID + "'";
                sqlCom = new SqlCommand(sql, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return x;
        }

        public DataTable GetAllCalls()
        {
            if (sqlCon.State == ConnectionState.Closed)

                sqlCon.Open();
            DataTable db = new DataTable();
            try
            {
                sqlCom = new SqlCommand("spGetAllCalls", sqlCon);
                sqlDbAdapter = new SqlDataAdapter(sqlCom);
                sqlDbAdapter.Fill(db);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return db;
        }

        public int InsertCalls(classCalls cc)
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            int x = 1;

            try
            {
                string sqlInsert = "spInsertCalls ' " + cc.CallID + "','" + cc.CallType + "','" + cc.ProblemDescription + "'";
                sqlCom = new SqlCommand(sqlInsert, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (SqlException sx)
            {
                MessageBox.Show(sx.Message);
                MessageBox.Show("Make sure that your using data that exist's ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return x;
        }

        public int DeleteCalls(classCalls cc)
        {
            if (sqlCon.State == ConnectionState.Closed)

                sqlCon.Open();
            int x = 1;
            try
            {
                string sql = "spDeleteCalls '" + cc.CallID + "'";
                sqlCom = new SqlCommand(sql, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return x;
        }

        public int UpdateCalls(classCalls cc)
        {
            if (sqlCon.State == ConnectionState.Closed)

                sqlCon.Open();

            int x = 1;

            DataTable dbUpRental = new DataTable();
            try
            {
                string sql = "spUpdateCalls '" + cc.CallID + "','" + cc.CallType + "','" + cc.ProblemDescription + "'";
                sqlCom = new SqlCommand(sql, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return x;
        }

        public DataTable GetAllLogin()
        {
            if (sqlCon.State == ConnectionState.Closed)

                sqlCon.Open();
            DataTable db = new DataTable();
            try
            {
                sqlCom = new SqlCommand("spGetAllLogin", sqlCon);
                sqlDbAdapter = new SqlDataAdapter(sqlCom);
                sqlDbAdapter.Fill(db);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return db;
        }

        //public int InsertLoign(classCalls cc)
        //{
        //    if (sqlCon.State == ConnectionState.Closed)
        //        sqlCon.Open();

        //    int x = 1;

        //    try
        //    {
        //        string sqlInsert = "spInsertLogin ' " + cc.CallID + "','" + cc.CallType + "','" + cc.ProblemDescription + "'";
        //        sqlCom = new SqlCommand(sqlInsert, sqlCon);
        //        x = sqlCom.ExecuteNonQuery();
        //    }
        //    catch (SqlException sx)
        //    {
        //        MessageBox.Show(sx.Message);
        //        MessageBox.Show("Make sure that your using data that exist's ");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //    return x;
        //}

        //public int DeleteLogin(classLogin cc)
        //{
        //    if (sqlCon.State == ConnectionState.Closed)

        //        sqlCon.Open();
        //    int x = 1;
        //    try
        //    {
        //        string sql = "spDeleteLogin '" + cc.CallID + "'";
        //        sqlCom = new SqlCommand(sql, sqlCon);
        //        x = sqlCom.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    return x;
        //}

        //public int UpdateLogin(classLogin cc)
        //{
        //    if (sqlCon.State == ConnectionState.Closed)

        //        sqlCon.Open();

        //    int x = 1;

        //    DataTable dbUpRental = new DataTable();
        //    try
        //    {
        //        string sql = "spUpdateLogin '" + cc.CallID + "','" + cc.CallType + "','" + cc.ProblemDescription + "'";
        //        sqlCom = new SqlCommand(sql, sqlCon);
        //        x = sqlCom.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //    return x;
        //}
    }
}