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
    public partial class Form1 : Form
    {
        frmAcademic myAcademicForm;
        frmArts myArtsForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcademic_Click(object sender, EventArgs e)
        {
            StreamWriter myStudents = new StreamWriter("student.txt", true);
            myStudents.Write(txtStudNumber.Text + "," + txtStudName.Text + "," + txtStudentDegree.Text);
            myAcademicForm = new frmAcademic(txtStudNumber.Text, txtStudName.Text, txtStudentDegree.Text);
            this.Visible = false;
            myAcademicForm.ShowDialog();
            this.Visible = true;
        }

        private void btnArts_Click(object sender, EventArgs e)
        {
            StreamWriter myStudents = new StreamWriter("student.txt", true);
            myStudents.Write(txtStudNumber.Text + "," + txtStudName.Text + "," + txtStudentDegree.Text);
            myArtsForm = new frmArts(txtStudNumber.Text, txtStudName.Text, txtStudentDegree.Text);
            this.Visible = false;
            myArtsForm.ShowDialog();
            this.Visible = true;

        }
    }
}
