using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2ebtrue
{
    public partial class Form2 : Form
    {
        Form1 form1 = new Form1();
        private List<double> prices = new List<double>();

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 x)
        {
            InitializeComponent();
            form1 = x;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
