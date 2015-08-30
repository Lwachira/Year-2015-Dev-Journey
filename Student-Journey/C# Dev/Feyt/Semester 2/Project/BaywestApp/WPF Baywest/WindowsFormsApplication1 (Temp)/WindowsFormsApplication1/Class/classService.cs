using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Class
{
    internal class classService
    {
        private BusinessLayer bl = new BusinessLayer();
        private int serviceID;
        private string serviceName;
        private int staffID;

        public classService(int serviceID, string serviceName, int staffID)
        {
            this.serviceID = serviceID;
            this.serviceName = serviceName;
            this.staffID = staffID;
        }

        public classService(int serviceID)
        {
            this.serviceID = serviceID;
        }

        public classService()
        {
        }

        public int ServiceID
        {
            get { return serviceID; }
            set { serviceID = value; }
        }

        public string ServiceName
        {
            get { return serviceName; }
            set { serviceName = value; }
        }

        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public DataTable GetAllService()
        {
            return bl.GetAllService();
        }

        public int UpdateService()
        {
            return bl.UpdateService(this);
        }

        public int InsertService()
        {
            return bl.InserService(this);
        }

        public int DeleteService()
        {
            return bl.DeleteService(this);
        }
    }
}