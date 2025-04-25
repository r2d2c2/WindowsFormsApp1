using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MessageBox.Show("이것은 MessageBox입니다.");
            textBox1.Text = "이것은 \r\n 멀티라인 \r\n 태스트박스\r\n 입니다.!";
            textBox1.Text+= "\r\n 추가된 텍스트입니다.";

            MessageBox.Show("안녕하세요, 맹승연입니다.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
