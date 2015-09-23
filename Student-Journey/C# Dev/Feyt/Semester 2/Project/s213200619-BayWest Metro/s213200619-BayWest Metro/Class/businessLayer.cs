using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s213200619_BayWest_Metro.Class
{
    internal class businessLayer
    {
        private SqlCommand sqlCom;
        private SqlConnection sqlCon;
        private SqlDataAdapter sqlDbAdapter;
        private SqlConnectionStringBuilder sqlBuilder;

        public businessLayer()
        {
            try
            {
                sqlBuilder = new SqlConnectionStringBuilder();
                sqlBuilder.DataSource = "";
                sqlBuilder.InitialCatalog = "RentalSystem_213200619";
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

        public int InsertLogin(classLogin cc)
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            int x = 1;

            try
            {
                string sqlInsert = "spInsertLogin ' " + cc.UserName + "','" + cc.UserRank + "','" + cc.UserID + "','" + cc.ClientID + "'";
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

        public int DeleteLogin(classLogin cc)
        {
            if (sqlCon.State == ConnectionState.Closed)

                sqlCon.Open();
            int x = 1;
            try
            {
                string sql = "spDeleteLogin '" + cc.UserID + "'";
                sqlCom = new SqlCommand(sql, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return x;
        }

        public int UpdateLogin(classLogin cc)
        {
            if (sqlCon.State == ConnectionState.Closed)

                sqlCon.Open();

            int x = 1;

            DataTable dbUpRental = new DataTable();
            try
            {
                string sql = "spUpdateLogin '" + cc.UserName + "','" + cc.UserRank + "','" + cc.UserID + "','" + cc.ClientID + "'";
                sqlCom = new SqlCommand(sql, sqlCon);
                x = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return x;
        }

        public DataTable GetClient(userClassClient cc)
        {
            if (sqlCon.State == ConnectionState.Closed)

                sqlCon.Open();
            DataTable db = new DataTable();
            try
            {
                string sql = "spGetClient '" + cc.ClientID + "'";

                sqlCom = new SqlCommand(sql, sqlCon);
                sqlDbAdapter = new SqlDataAdapter(sqlCom);
                sqlDbAdapter.Fill(db);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return db;
        }

        public DataTable GetRentalAgreement(userClassRentalAgreement cc)
        {
            if (sqlCon.State == ConnectionState.Closed)

                sqlCon.Open();
            DataTable db = new DataTable();
            try
            {
                string sql = "spClientRentalAgreement '" + cc.ClientID + "'";

                sqlCom = new SqlCommand(sql, sqlCon);
                sqlDbAdapter = new SqlDataAdapter(sqlCom);
                sqlDbAdapter.Fill(db);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return db;
        }
    }
}