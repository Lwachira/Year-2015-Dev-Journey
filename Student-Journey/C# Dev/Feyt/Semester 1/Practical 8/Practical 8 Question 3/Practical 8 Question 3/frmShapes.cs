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
namespace Practical_8_Question_3
{
    public partial class frmShapes : Form
    {

        public frmShapes()
        {
            InitializeComponent();
        }

        frmTriangle formT;
        frmRectangle formR;
        frmCircle formC;
        int counter = 0;

        private void btnShape_Click(object sender, EventArgs e)
        {
            try
            {
                Shape2D myShape = new Shape2D(double.Parse(txtHeight.Text), double.Parse(txtWidth.Text));

                lstShape.Items.Add(myShape.showDetails());
            }
            catch (Exception f)
            {

                MessageBox.Show(f.Message);
            }
            
            counter += 1;
        }

        private void trianglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formT = new frmTriangle(txtHeight, txtWidth);
            if (counter > 0)
            {
                this.Hide();
                formT.ShowDialog();
            }


            counter = 0;
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formR = new frmRectangle(txtHeight, txtWidth);
            if (counter > 0)
            {
                this.Hide();
                formR.ShowDialog();
            }
            counter = 0;
        }

        private void circlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formC = new frmCircle(txtHeight, txtWidth);
            if (counter > 0)
            {
                this.Hide();
                formC.ShowDialog();
            }
            counter = 0;

        }

        private void frmShapes_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
