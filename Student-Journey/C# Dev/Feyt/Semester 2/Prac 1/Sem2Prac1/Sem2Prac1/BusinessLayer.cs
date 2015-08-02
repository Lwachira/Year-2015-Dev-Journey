using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Sem2Prac1
{
    class BusinessLayer
    {
        private string connstring;
        private OleDbConnection dbCon;
        private OleDbCommand dbCom;
        // private OleDbDataAdapter dbAdapter;

        public BusinessLayer()
        {
            connstring = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source = PracticeXYZ.accdb";
            dbCon = new OleDbConnection(connstring);
        }

        public string Connstring
        {
            get { return connstring; }
            set { connstring = value; }
        }



        public int insertDoctors(string doctorID, string doctorSurname, string doctorFirstname, string doctorCellNo)
        {
            int x = 0;
            try
            {
                if (dbCon.State == System.Data.ConnectionState.Closed)
                {
                    dbCon.Open();
                }

                string OleInsert = "Insert INTO Doctor VALUES( '" + doctorID + "','" + doctorSurname + "','" + doctorFirstname + "','" + doctorCellNo + "')";

                dbCom = new OleDbCommand(OleInsert, dbCon);
                x = dbCom.ExecuteNonQuery();
            }
            catch (Exception f)
            {

                MessageBox.Show(f.Message);
            }


            return x;

        }
    }
}
