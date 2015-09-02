using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BayWest_213200619.AdminForms
{
    public partial class txtAbout : MetroForm
    {
        private string userName;
        private string userRank;

        public txtAbout(string userName, string userRank)
        {
            InitializeComponent();
            this.userName = userName;
            this.userRank = userRank;
        }

        private void frmAdminHome_Load(object sender, EventArgs e)
        {
        }
    }
}