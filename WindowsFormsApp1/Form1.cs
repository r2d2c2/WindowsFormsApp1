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

            textBox1.Text = "이것은 \r\n 멀티라인 \r\n 태스트박스\r\n 입니다.";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
