using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2Prac1
{
    class classDoctor
    {

        private string doctorID;
        private string doctorSurname;
        private string doctorFirstName;
        private string doctorCellNo;


        public string DoctorID
        {
            get { return doctorID; }
            set { doctorID = value; }
        }

        public string DoctorSurname
        {
            get
            {
                return doctorSurname;
            }
            set
            {
                doctorSurname = value;


            }


        }

        public string DoctorFirstName
        {
            get
            {
                return doctorFirstName;
            }
            set
            {
                doctorFirstName = value;
            }
        }

        public string DoctorCellNo
        {
            get
            {
                return doctorCellNo;
            }

            set
            {
                doctorCellNo = value;
            }
        }
    }
}
