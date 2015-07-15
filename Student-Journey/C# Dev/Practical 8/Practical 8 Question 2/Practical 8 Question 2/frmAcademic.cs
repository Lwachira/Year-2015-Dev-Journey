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
using Societies;
namespace Practical_8_Question_2
{
    public partial class frmAcademic : Form
    {
        Academic[] myAcademic = new Academic[100];
        int counter = 0;
        private Student[] students;  //Needed to port from the Home form
        private string studentName;
        private string v1;
        private string v2;

        public frmAcademic(Student[] students)
        {
            InitializeComponent();
            this.students = students;
        }



        private void Academic_Load(object sender, EventArgs e)
        {
            StreamReader myArtReader = new StreamReader("academic.txt");
            string[] academicWord;

            while (!myArtReader.EndOfStream)
            {
                string line = myArtReader.ReadLine();
                academicWord = line.Split(',');


                myAcademic[counter] = new Academic(students[counter].StudentName, academicWord[1], academicWord[2]);
                counter++;

            }

            for (int i = 0; i < counter; i++)
            {
                lstBoxAcademic.Items.Add(myAcademic[i].ToString());
            }
        }
    }
}