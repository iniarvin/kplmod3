namespace modul3_1302223136
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
        }

        int num1int, num2int, resultint;
        string num1, num2, result;

        private void button11_Click(object sender, EventArgs e)
        {
            num1int = int.Parse(textBox1.Text);
            textBox1.Text =  " ";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            num2int = int.Parse(textBox1.Text);
            resultint = num1int + num2int;
            textBox1.Text = resultint.ToString();
        }

        
    }
}
