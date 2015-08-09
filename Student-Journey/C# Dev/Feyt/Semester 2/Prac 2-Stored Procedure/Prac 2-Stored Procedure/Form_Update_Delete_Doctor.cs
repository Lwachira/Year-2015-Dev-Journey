using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac_2_Stored_Procedure
{
    public partial class Form_Update_Delete_Doctor : Form
    {
        public Form_Update_Delete_Doctor()
        {
            InitializeComponent();
        }

        private void dgvUpdateDoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUpdateDoc.SelectedRows.Count > 0)
            {
                int i = dgvUpdateDoc.SelectedRows[0].Index;

                txtDocID.Text = dgvUpdateDoc[0, i].Value.ToString();
                txtDocSurname.Text = dgvUpdateDoc[1, i].Value.ToString();
                txtDocFirstName.Text = dgvUpdateDoc[2, i].Value.ToString();
                txtDocCellNum.Text = dgvUpdateDoc[3, i].Value.ToString();
            }
        }
    }
}
