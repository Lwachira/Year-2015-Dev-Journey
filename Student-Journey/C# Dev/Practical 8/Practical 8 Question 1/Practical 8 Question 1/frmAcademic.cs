using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Practical_8_Question_1
{
    public partial class frmAcademic : Form
    {
        private string studNo;
        private string studName;
        private string studDegree;
        public frmAcademic(string studNo, string studName, string studDegree)
        {
            InitializeComponent();
            this.studName = studName;
            this.studNo = studNo;
            this.studDegree = studDegree;
        }

        private void frmAcademic_Load(object sender, EventArgs e)
        {

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {           
            //Academic File
            StreamWriter myAcademic = new StreamWriter("academic.txt", true);
            string message = "";

            if (rdoAcc.Checked)
            {
                message = rdoAcc.Text;
            }

            if (rdLaw.Checked)
            {
                message = rdLaw.Text;

            }
            myAcademic.Write(studName + "," + message + "," + txtCourse.Text);
            myAcademic.WriteLine();
            myAcademic.Close();
        }
    }
}
