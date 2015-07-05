using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Societies;
using System.IO;

namespace Practical_8
{
    public partial class Form1 : Form
    {

        List<Student> myStudent = new List<Student>();
        List<Arts> myArts = new List<Arts>();
        List<Academic> myAcademic = new List<Academic>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbLevel.Items.Add("Easy");
            cmbLevel.Items.Add("Medium");
            cmbLevel.Items.Add("Hard");
        }

        private void chkAcademic_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkAcademic.Checked)
                {
                    grpAcademic.Visible = true;

                }

                else
                {
                    grpAcademic.Visible = false;
                }
            }
            catch (Exception f)
            {

                errorProvider1.SetError(chkAcademic, f.Message);
            }

        }

        private void chkArts_CheckedChanged(object sender, EventArgs e)
        {
            if (chkArts.Checked)
            {
                grpArts.Visible = true;
            }

            else
            {
                grpArts.Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkAcademic.Checked)
                {
                    if (rdoAccounting.Checked)
                    {
                        myAcademic.Add(new Academic(txtStudentNo.Text, txtName.Text, txtDegree.Text, "Acounting Society", txtCourseCode.Text));
                        rdoAccounting.Checked = false;
                    }
                    else
                    {
                        if (rdoLaw.Checked)
                        {
                            myAcademic.Add(new Academic(txtStudentNo.Text, txtName.Text, txtDegree.Text, "Student Law Society", txtCourseCode.Text));
                            rdoLaw.Checked = false;
                        }
                    }
                }

                if (chkArts.Checked)
                {
                    if (rdoMarimba.Checked)
                    {
                        myArts.Add(new Arts(txtStudentNo.Text, txtName.Text, txtDegree.Text, "Marimba Society", cmbLevel.SelectedItem.ToString(), int.Parse(txtWins.Text)));
                        cmbLevel.SelectedIndex = 0;
                        txtWins.Clear();
                        rdoMarimba.Checked = false;

                    }

                    else
                    {
                        if (rdoBallroom.Checked)
                        {
                            myArts.Add(new Arts(txtStudentNo.Text, txtName.Text, txtDegree.Text, "Balroom Society", cmbLevel.SelectedItem.ToString(), int.Parse(txtWins.Text)));
                            cmbLevel.SelectedIndex = 0;
                            txtWins.Clear();
                            rdoBallroom.Checked = false;
                        }
                    }

                }

                myStudent.Add(new Student(txtStudentNo.Text, txtName.Text, txtDegree.Text));
                txtCourseCode.Clear();
                txtDegree.Clear();
                txtName.Clear();
                txtStudentNo.Clear();
                txtWins.Clear();
                grpAcademic.Visible = false;
                grpArts.Visible = false;
                chkAcademic.Checked = false;
                chkArts.Checked = false;
                dgvAllStudents.Rows.Clear();
                dgvAcademic.Rows.Clear();
                dgvArts.Rows.Clear();


            }
            catch (Exception f)
            {

                errorProvider1.SetError(btnAdd, f.Message);
            }
        }


        private void grpAddStudents_Enter(object sender, EventArgs e)
        {

        }

        private void allStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void academicStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.AppendAllLines("Academic.txt", myAcademic.ConvertAll(Convert.ToString));

        }

        private void artsAndCultureStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.AppendAllLines("Arts.txt", myArts.ConvertAll(Convert.ToString));
        }
    }
}
