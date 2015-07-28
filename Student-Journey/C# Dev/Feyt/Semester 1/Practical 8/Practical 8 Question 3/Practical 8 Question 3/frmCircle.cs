using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CircleLibrary;

namespace Practical_8_Question_3
{
    public partial class frmCircle : Form
    {

        public frmCircle(TextBox txtHeight, TextBox txtWidth)
        {
            this.txtHeight = txtHeight;
            this.txtWidth = txtWidth;
            InitializeComponent();
        }

        private void frmCircle_Load(object sender, EventArgs e)
        {

        }

        private void txtRadius_TextChanged(object sender, EventArgs e)
        {

            lstRadius.Items.Clear();
            try
            {
                Circle_Class myCircle = new Circle_Class(double.Parse(txtRadius.Text), double.Parse(txtHeight.Text), double.Parse(txtWidth.Text));
                lstRadius.Items.Add(myCircle.ToString());

            }
            catch (Exception f)
            {

                MessageBox.Show(f.Message);
            }


        }
    }
}
