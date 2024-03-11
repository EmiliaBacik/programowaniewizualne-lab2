using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace lab2ebtrue
{
    public partial class Form3 : Form
    {
        Form1 form1 = new Form1();
        int price = 0;
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form1 x)
        {
            InitializeComponent();
            form1 = x;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                foreach (ListViewItem selectedItem in listView1.SelectedItems)
                {
                    if (selectedItem.Text == "Ordinary") { price = 500; }
                    if (selectedItem.Text == "Japanese") { price = 1000; }
                    if (selectedItem.Text == "Chinese") { price = 99; }
                    if (selectedItem.Text == "Really big monitor") { price = 2000; }
                }
                textBox1.Text = price.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.monitor = price;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
