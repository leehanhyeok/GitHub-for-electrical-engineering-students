using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessForm
{
    public partial class Form2 : Form
    {
        private Form1 frm1;
        private string str;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(object frm)
        {
            InitializeComponent();
            frm1 = (Form1)frm; //폼2에서 폼1을 엑세스 함 
        }

        public Form2(object frm, string _str)
        {
            InitializeComponent();
            frm1 = (Form1)frm; //폼2에서 폼1을 엑세스 함 
            str = _str;
        }

        private void btnChangeMainLabel_Click(object sender, EventArgs e)
        {
            frm1.label1.Text = "Form2에서 변경함";//생성자 뿐만 아니라, Form1의 Label modifires속성을 public으로 바꿔 줘야함 
            frm1.label1.BackColor = Color.Red;
        }
    }
}
