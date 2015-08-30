using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Class
{
    internal class classCalls
    {
        private BusinessLayer bl = new BusinessLayer();
        private int callID;
        private string callType;
        private string problemDescription;

        public classCalls(int callID, string callType, string problemDescription)
        {
            this.callID = callID;
            this.callType = callType;
            this.problemDescription = problemDescription;
        }

        public classCalls(int callID)
        {
            this.callID = callID;
        }

        public classCalls()
        {
        }

        public int CallID
        {
            get { return callID; }
            set { callID = value; }
        }

        public string CallType
        {
            get { return callType; }
            set { callType = value; }
        }

        public string ProblemDescription
        {
            get { return problemDescription; }
            set { problemDescription = value; }
        }

        public DataTable GetAllCalls()
        {
            return bl.GetAllCalls();
        }

        public int InsertCalls()
        {
            return bl.InsertCalls(this);
        }

        public int DeleteCalls()
        {
            return bl.DeleteCalls(this);
        }

        public int UpdateCalls()
        {
            return bl.UpdateCalls(this);
        }
    }
}