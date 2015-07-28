using System;
using System.Windows.Forms;
using System.IO;
using Societies;
namespace Practical_8_Question_2
{
    public partial class frmArts : Form
    {

        Arts[] myArts = new Arts[100];
        int counter = 0;
        private Student[] students;  //Needed to port from the Home form
        public frmArts(Student[] students)
        {
            InitializeComponent();
            this.students = students;
        }

        private void frmArts_Load(object sender, EventArgs e)
        {
            StreamReader myArtReader = new StreamReader("arts.txt");
            string[] artWord;

            while (!myArtReader.EndOfStream)
            {
                string line = myArtReader.ReadLine();
                artWord = line.Split(',');


                myArts[counter] = new Arts(students[counter].StudentNum, students[counter].StudentName, students[counter].DegreeCode, artWord[1], artWord[2], int.Parse(artWord[3]), artWord[4]);
                counter++;


            }

            for (int i = 0; i < counter; i++)
            {
                lstBoxArts.Items.Add(myArts[i].ToString());
            }

        }
    }
}
