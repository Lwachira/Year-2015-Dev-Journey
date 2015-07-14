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
    public partial class Form1 : Form
    {
        frmArts myArtsForm;
        frmAcademic myAcademicForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            myAcademicForm = new frmAcademic();
            this.Visible = false;
            myAcademicForm.ShowDialog();
            this.Visible = true;
        }

        private void btnArts_Click(object sender, EventArgs e)
        {

            myArtsForm = new frmArts();
            this.Visible = false;
            myArtsForm.ShowDialog();
            this.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
