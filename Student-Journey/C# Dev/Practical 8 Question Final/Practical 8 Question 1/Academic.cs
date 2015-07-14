using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_8_Question_1
{
    public partial class Academic : Form
    {
        private string studNo;
        private string studName;
        private string degree;
        public Academic(string studNo, string studName, string degree)
        {
            InitializeComponent();

            this.studNo = studNo;
            this.studName = studName;
            this.degree = degree;
        }

        private void Academic_Load(object sender, EventArgs e)
        {

        }
    }
}
