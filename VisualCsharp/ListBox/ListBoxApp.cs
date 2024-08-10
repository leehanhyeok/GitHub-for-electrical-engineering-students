namespace ListBoxApp
{
    public partial class Form1 : Form //Form을 상속한 Form1 
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("장갑");
            listBox1.Items.Add("타월");
            listBox1.Items.Add("양말");
            listBox1.Items.Add("바지");
            listBox1.Items.Add("반팔티");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = " ";
            textBox1.Focus(); //깜빡깜빡
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.Text); //listBox1에 값을 listbox2로 넣음
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox1.Text); //listbox2의 값을 제거 
        }
    }
}
