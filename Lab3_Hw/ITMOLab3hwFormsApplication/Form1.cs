using System;
using System.Windows.Forms;

namespace ITMOLab3hwFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = validate1.textBox1.Text;
            richTextBox1.Text += s;
            richTextBox1.Text += "\n";
        }
    }
}
