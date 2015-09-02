using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Class
{
    internal class classAssignedCall
    {
        private BusinessLayer bl = new BusinessLayer();
        private int assignedCallID;
        private int callID;
        private int staffID;
        private string startDate;
        private int shopID;
        private string callStatus;
        private int serviceID;

        public classAssignedCall(int assignedCallID, int callID, int staffID, string startDate, int shopID, string callStatus, int serviceID)
        {
            this.assignedCallID = assignedCallID;
            this.callID = callID;
            this.staffID = staffID;
            this.startDate = startDate;
            this.shopID = shopID;
            this.callStatus = callStatus;
            this.serviceID = serviceID;
        }

        public classAssignedCall(int assignedCallID)
        {
            this.assignedCallID = assignedCallID;
        }

        public classAssignedCall()
        {
        }

        public int AssignedCall
        {
            get { return assignedCallID; }
            set { assignedCallID = value; }
        }

        public int CallID
        {
            get { return callID; }
            set { callID = value; }
        }

        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public int ShopID
        {
            get { return shopID; }
            set { shopID = value; }
        }

        public string CallStatus
        {
            get { return callStatus; }
            set { callStatus = value; }
        }

        public int ServiceID
        {
            get { return serviceID; }
            set { serviceID = value; }
        }

        public DataTable GetAllAsignedCall()
        {
            return bl.GetAllAssignedCall();
        }

        public int InsertAllAssignedCall()
        {
            return bl.InsertAllAssignedCall(this);
        }

        public int DeleteAllAssignedCall()
        {
            return bl.DeleteAllAssignedCall(this);
        }

        public int UpdateAllAssignedCall()
        {
            return bl.UpdateAllAssignedCall(this);
        }
    }
}