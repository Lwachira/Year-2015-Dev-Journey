using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Class
{
    internal class classStaff
    {
        private BusinessLayer bl = new BusinessLayer();
        private int staffID;
        private string staffName;
        private string staffCellNumber;
        private string staffType;
        private int callID;

        public classStaff(int staffID, string staffName, string staffCellNumber, string staffType, int callID)
        {
            this.staffID = staffID;
            this.staffName = staffName;
            this.staffCellNumber = staffCellNumber;
            this.staffType = staffType;
            this.callID = callID;
        }

        public classStaff(int staffID)
        {
            this.staffID = staffID;
        }

        public classStaff()
        {
        }

        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public string StaffName
        {
            get { return staffName; }
            set { staffName = value; }
        }

        public string StaffCellNumber
        {
            get { return staffCellNumber; }
            set { staffCellNumber = value; }
        }

        public string StaffType
        {
            get { return staffType; }
            set { staffType = value; }
        }

        public int CallID
        {
            get { return callID; }
            set { callID = value; }
        }

        public DataTable GetAllStaff()
        {
            return bl.GetAllStaff();
        }

        public int InsertStaff()
        {
            return bl.InsertStaff(this);
        }

        public int DeleteStaff()
        {
            return bl.DeleteStaff(this);
        }

        public int UpdateStaff()
        {
            return bl.UpdateStaff(this);
        }
    }
}