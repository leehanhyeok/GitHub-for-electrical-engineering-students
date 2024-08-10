namespace PhotoApp
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
        }

        int pic = 1;
        int pic_max = 5;

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/걸그룹/" + pic + ".jpg");
            pic++;
            if (pic > pic_max)
            {
                pic = 1;
            }
        }
    }
}
