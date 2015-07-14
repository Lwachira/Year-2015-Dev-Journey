using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }
    }
}
