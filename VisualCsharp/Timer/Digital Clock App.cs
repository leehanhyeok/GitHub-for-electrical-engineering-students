using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DigtalWatchApp
{
    public partial class Form1 : Form
    {
        private Thread thread1;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                thread1 = new Thread(UpdateTime);
                thread1.IsBackground = true;    
                thread1.Start();
                
            }
            
        }

        private void UpdateTime()
        {
            while (true)
            {
                DateTime currentTime = DateTime.Now;
                string strTime = currentTime.ToString("hh : mm : ss");

                this.Invoke((MethodInvoker)delegate
                {
                    label1.Text = strTime;
                });

                Thread.Sleep(1000);
            }
        }
    }
}
