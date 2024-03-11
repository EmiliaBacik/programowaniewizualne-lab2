
namespace lab2ebtrue
{

    public partial class Form1 : Form
    {
        public int computer = 0;
        public int monitor = 0;
        int everything = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
            everything = monitor + computer;
            textBox1.Text = everything.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.ShowDialog();
            everything = monitor + computer;
            textBox1.Text = everything.ToString();
        }
    }
}
