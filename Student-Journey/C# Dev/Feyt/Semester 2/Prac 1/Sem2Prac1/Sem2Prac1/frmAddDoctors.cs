using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem2Prac1
{
    public partial class frmAddDoctors : Form
    {
        public frmAddDoctors()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmDoctor formDoc = new frmDoctor();
            this.Visible = false;
            formDoc.ShowDialog();
            this.Visible = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            BusinessLayer b = new BusinessLayer();
            int x = b.insertDoctors(txtDocID.Text,txtDocSurname.Text,txtDocFirstName.Text,txtDocCellNum.Text);
        }

        private void frmAddDoctors_Load(object sender, EventArgs e)
        {

        }
    }
}
