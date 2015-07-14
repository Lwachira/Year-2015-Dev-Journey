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


    public partial class Form1 : Form
    {

        Student[] students = new Student[100];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader myStudentReader = new StreamReader("student.txt");
            string line;
            string[] words = new string[4];
            int counter = 0;
            while (!myStudentReader.EndOfStream)
            {
                line = myStudentReader.ReadLine();
                words = line.Split(',');

                students[counter] = new Student(words[0], words[1], words[2]);
                counter = counter + 1;


            }
            for (int i = 1; i < counter; i++)
            {
                listBox1.Items.Add(students[].ToString());
            }
           




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
