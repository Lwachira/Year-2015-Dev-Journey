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

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            frmAcademic myAcademicForm = new frmAcademic(txtStudentNo.Text, txtName.Text, txtDegree.Text);
            this.Visible = false;
            myAcademicForm.ShowDialog();
            this.Visible = true;
        }

        private void btnArts_Click(object sender, EventArgs e)
        {

            frmArts myArtsForm = new frmArts(txtStudentNo.Text, txtName.Text, txtDegree.Text);
            this.Visible = false;
            myArtsForm.ShowDialog();
            this.Visible = true;
        }
    }
}
