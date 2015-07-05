using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RectangleLibrary;

namespace Practical_8_Question_3
{
    public partial class frmRectangle : Form
    {
        frmShapes formShape = new frmShapes();
        public frmRectangle(TextBox txtHeight, TextBox txtWidth)
        {
            this.txtHeight = txtHeight;
            this.txtWidth = txtWidth;
            InitializeComponent();
        }

        private void frmRectangle_Load(object sender, EventArgs e)
        {
            Rectangle_CLass myRectangle = new Rectangle_CLass(double.Parse(txtHeight.Text), double.Parse(txtWidth.Text));
            lstRec.Items.Add(myRectangle.ToString());
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            this.Hide();
            formShape.ShowDialog();
        }
    }
}
