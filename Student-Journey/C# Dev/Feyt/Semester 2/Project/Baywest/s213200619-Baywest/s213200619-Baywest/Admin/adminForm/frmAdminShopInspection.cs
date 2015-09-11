using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using s213200619_Baywest.Admin.adminClass;

namespace s213200619_Baywest.Admin.adminForm
{
    public partial class frmAdminShopInspection : MetroForm
    {
        private adminShopInspection asi = new adminShopInspection();
        public frmAdminShopInspection()
        {
            InitializeComponent();
        }

        private void frmAdminShopInspection_Load(object sender, EventArgs e)
        {
            try
            {
                dgvShopInspection.DataSource = asi.GetAllShopInspection();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                int inspectionID;
                int shopID;
                int serviceID;
                string startDate;
                string endDate;
                string inspectionTask;
                string message;

                inspectionID = int.Parse(txtInspectionID.Text.Trim());
                shopID = int.Parse(txtShopID.Text.Trim());
                serviceID = int.Parse(txtServiceID.Text.Trim());
                startDate = dtStart.Text.Trim();
                endDate = dtEnd.Text.Trim();
                inspectionTask = txtInspectionTask.Text.Trim();
                message = txtMessage.Text.Trim();

                asi = new adminShopInspection(inspectionID, shopID, serviceID, startDate, endDate, inspectionTask, message);
                dgvShopInspection.DataSource = asi.InsertShopInspection();
                dgvShopInspection.DataSource = asi.GetAllShopInspection();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int inspectionID;
                int shopID;
                int serviceID;
                string startDate;
                string endDate;
                string inspectionTask;
                string message;

                inspectionID = int.Parse(txtInspectionID.Text.Trim());
                shopID = int.Parse(txtShopID.Text.Trim());
                serviceID = int.Parse(txtServiceID.Text.Trim());
                startDate = dtStart.Text.Trim();
                endDate = dtEnd.Text.Trim();
                inspectionTask = txtInspectionTask.Text.Trim();
                message = txtMessage.Text.Trim();

                asi = new adminShopInspection(inspectionID, shopID, serviceID, startDate, endDate, inspectionTask, message);
                dgvShopInspection.DataSource = asi.DeleteShopInspection();
                dgvShopInspection.DataSource = asi.GetAllShopInspection();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int inspectionID;
                int shopID;
                int serviceID;
                string startDate;
                string endDate;
                string inspectionTask;
                string message;

                inspectionID = int.Parse(txtInspectionID.Text.Trim());
                shopID = int.Parse(txtShopID.Text.Trim());
                serviceID = int.Parse(txtServiceID.Text.Trim());
                startDate = dtStart.Text.Trim();
                endDate = dtEnd.Text.Trim();
                inspectionTask = txtInspectionTask.Text.Trim();
                message = txtMessage.Text.Trim();

                asi = new adminShopInspection(inspectionID, shopID, serviceID, startDate, endDate, inspectionTask, message);
                dgvShopInspection.DataSource = asi.UpdateShopInspection();
                dgvShopInspection.DataSource = asi.GetAllShopInspection();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvShopInspection_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtInspectionID.Text = dgvShopInspection[0, e.RowIndex].Value.ToString();
                txtShopID.Text = dgvShopInspection[1, e.RowIndex].Value.ToString();
                txtServiceID.Text = dgvShopInspection[2, e.RowIndex].Value.ToString();
                DateTime result = DateTime.Parse(dgvShopInspection[3, e.RowIndex].Value.ToString());
                dtStart.Value = result;
                result = DateTime.Parse(dgvShopInspection[4, e.RowIndex].Value.ToString());
                dtEnd.Value = result;
                txtInspectionTask.Text = dgvShopInspection[5, e.RowIndex].Value.ToString();
                txtMessage.Text = dgvShopInspection[6, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }
    }
}
