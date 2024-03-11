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
        int proc = 0;
        int disk = 0;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 x)
        {
            InitializeComponent();
            form1 = x;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedIndex == 0) { proc = 1000; }
                else if (comboBox1.SelectedIndex == 1) { proc = 1500; }
                else if (comboBox1.SelectedIndex == 2) { proc = 2000; }
                textBox1.Text = proc.ToString();
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { disk = 500; textBox2.Text = disk.ToString(); }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) { disk = 800; textBox2.Text = disk.ToString(); }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) { disk = 1300; textBox2.Text = disk.ToString(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.computer = proc + disk;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
