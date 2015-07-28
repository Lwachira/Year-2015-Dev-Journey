using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Societies
{
    public class Student
    {
        /// <summary>
        /// This is the student class that will act as a base to Academic and Arts
        /// </summary>
        /// 

        private string studNum;
        private string studName;
        private string degreeCode;


        public string StudentNum
        {
            get { return studNum; }
            set { studName = value; }

        }

        public string StudentName
        {
            get { return studName; }
            set { studName = value; }
        }

        public string DegreeCode
        {
            get { return degreeCode; }
            set { degreeCode = value; }
        }

        public Student(string studNum, string studName, string degreeCode)
        {
            this.studNum = studNum;
            this.studName = studName;
            this.degreeCode = degreeCode;
        }

        public Student(string studName)
        {

            this.studName = studName;

        }

        public override string ToString()
        {
            return "Student Number: " + studNum + "\t" + "Student Name: " + studName + "\t";
        }

    }

    public class Arts : Student
    {

        private string societyName;
        private string experienceLevel;
        private int wins;
        private string colors;

        public string SocietyName
        {
            get { return societyName; }
            set { societyName = value; }
        }

        public string ExperienceLevel
        {
            get { return experienceLevel; }
            set { experienceLevel = value; }
        }


        public string Colors
        {
            get { return colors; }
            set { colors = value; }
        }


        public Arts(string studNum, string studName, string degreeCode, string societyName, string experienceLevel, int wins, string colors) : base(studNum, studName, degreeCode)
        {
            this.societyName = societyName;
            this.experienceLevel = experienceLevel;
            this.wins = wins;
            this.colors = colors;

        }

        public override string ToString()
        {
            return base.ToString() + "  Arts and Culture Society: " + societyName + "\t" + "Experience Level: " + experienceLevel + "\t" + "No of wins: " + wins + "\t" + "Colors: " + colors;
        }
    }

    public class Academic : Student
    {
        private string societyName;
        private string courseCode;


        public string SocietyName
        {
            get { return societyName; }
            set { societyName = value; }

        }

        public string CourseCode
        {
            get { return courseCode; }
            set { courseCode = value; }
        }

        public Academic(string studName, string societyName, string courseCode) : base(studName)

        {
            this.courseCode = courseCode;
            this.societyName = societyName;
        }

        public override string ToString()
        {
            return "Student Name: " + base.StudentName + "\t\t" + "Academic Society: " + societyName + "\t\t" + "Course Code: " + courseCode + "\t";
        }
    }


}
