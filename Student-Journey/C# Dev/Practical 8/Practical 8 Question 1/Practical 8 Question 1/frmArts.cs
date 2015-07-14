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
    public partial class frmArts : Form
    {
        private string studNo;
        private string studName;
        private string studDegree;

        public frmArts(string StudNo, string StudName, string StudDegree)
        {
            InitializeComponent();

            studNo = StudNo;
            studName = StudName;
            studDegree = StudDegree;
        }

        private void frmArts_Load(object sender, EventArgs e)
        {

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            string message = "";
            string colour = "No";
            if (rdoMarimba.Checked)
            {
                message = rdoMarimba.Text;
            }

            if (rdBallroom.Checked)
            {
                message = rdBallroom.Text;

            }

            if (int.Parse(txtWins.Text) > 8)
            {
                colour = "Yes";
            }
            StreamWriter myArts = new StreamWriter("arts.txt", true);
            myArts.Write(studName + "," + message + "," + cmbLevel.SelectedItem + "," + txtWins.Text + "," + colour);
            myArts.WriteLine();
            myArts.Close();
        }
    }
}
