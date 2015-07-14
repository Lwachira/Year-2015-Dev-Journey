using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_8_Question_Final
{
    public partial class frmAcademic : Form
    {
        private string studNo;
        private string studName;
        private string studDegree;

        public frmAcademic(string studNo, string studName, string studDegree)
        {
            InitializeComponent();
            this.studNo = studNo;
            this.studName = studName;
            this.studDegree = studDegree;
        }



        private void frmAcademic_Load(object sender, EventArgs e)
        {

        }
    }
}
