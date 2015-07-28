using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShapesLibrary;
using TriangleLibrary;
namespace Practical_8_Question_3
{
    public partial class frmTriangle : Form
    {
        frmShapes formShapes = new frmShapes();
        public frmTriangle(TextBox txtHeight, TextBox txtWidth)
        {
            this.txtHeight = txtHeight;
            this.txtWidth = txtWidth;

            InitializeComponent();
        }

        private void frmTriangle_Load(object sender, EventArgs e)
        {
            
        }

        private void cmbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTriangle.Items.Clear();
            Triangle_Class myTriangle = new Triangle_Class(cmbStyle.SelectedItem.ToString(), double.Parse(txtHeight.Text), double.Parse(txtWidth.Text));
            lstTriangle.Items.Add(myTriangle.ToString());
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPrv_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            formShapes.ShowDialog();
        }
    }
}
