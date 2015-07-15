using System;
using System.Windows.Forms;
using System.IO;
using Societies;


namespace Practical_8_Question_2
{

    public partial class Form1 : Form
    {

        Student[] students = new Student[100];
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader myStudentReader = new StreamReader("student.txt");
            string line;
            string[] words = new string[4];
           

            while (!myStudentReader.EndOfStream)
            {
                line = myStudentReader.ReadLine();
                words = line.Split(',');

                students[counter] = new Student(words[1], words[0], words[2]);
                counter = counter + 1;


            }


            for (int i = 0; i < counter; i++)
            {
                listBox1.Items.Add(students[i].ToString());
            }





        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAcademic myAcademic = new frmAcademic(students);
            this.Visible = false;
            myAcademic.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmArts myArts = new frmArts(students);
            this.Visible = false;
            myArts.ShowDialog();
            this.Visible = true;

        }
    }
}
