using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;
using s213200619_Baywest.Admin.adminClass;
using s213200619_Baywest.User.userForm;
using s213200619_Baywest.Admin.adminForm;

namespace s213200619_Baywest
{
    public partial class Form1 : MetroForm
    {
        private classLoginDetails cl = new classLoginDetails();
        int loginID;
        string loginUserName;
        string loginRank;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            mCmbUsername.DataSource = cl.GetAllLogin();
            mCmbUsername.DisplayMember = "loginUserName";
            mCmbUsername.ValueMember = "loginRank";



        }

        private void mCmbUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mCmbUsername.SelectedValue.ToString() == "Admin")
            {
                loginID = int.Parse(mCmbUsername.SelectedIndex.ToString()) + 1;
                loginUserName = mCmbUsername.Text;
                loginRank = mCmbUsername.SelectedValue.ToString();
                cl = new classLoginDetails(loginID, loginUserName, loginRank);
                frmAdmin fa = new frmAdmin();
                fa.ShowDialog();


            }
            else if (mCmbUsername.SelectedValue.ToString() == "User")
            {
                loginID = int.Parse(mCmbUsername.SelectedIndex.ToString());
                loginUserName = mCmbUsername.Text;
                loginRank = mCmbUsername.SelectedValue.ToString();
                cl = new classLoginDetails(loginID, loginUserName, loginRank);
                
                frmUser fu = new frmUser(cl);
                fu.ShowDialog();

            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister();
            register.ShowDialog();
        }
    }
}
