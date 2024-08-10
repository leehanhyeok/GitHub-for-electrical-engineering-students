namespace listbox02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)

        {

        }
        
        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = " ";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox1.Text);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("경상북도");
            listBox1.Items.Add("경상남도");
            listBox1.Items.Add("강원도");
            listBox1.Items.Add("서울특별시");
            listBox1.Items.Add("부산광역시");
        }
    }
}
