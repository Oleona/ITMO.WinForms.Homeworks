using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ITMOLab7_hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MaxValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле должно содержать цифры");
            }
        }

        public string GoButt(int maxValue)
        {
            var resultText = new StringBuilder();

            for (int trial = 2; trial <= maxValue; trial++)
            {
                bool isPrime = true;
                for (int divisor = 2; divisor <= Math.Sqrt(trial); divisor++)
                {

                    if (trial % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    resultText.AppendFormat("{0} ", trial);
                    Thread.Sleep(1000);
                }
            }
            PrintInResultLabelDelegate delPrint = new PrintInResultLabelDelegate(Print);
            ResultLabel.Invoke(delPrint, new object[] { resultText.ToString() });
            return resultText.ToString();
        }


        public delegate string GoButtDelegate(int maxValue);
        public delegate void PrintInResultLabelDelegate(string str);

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(MaxValue.Text, out int maxValue))
            {
                ResultLabel.Text = "Unable to parse maximum value.";
                return;
            }

            GoButtDelegate del = new GoButtDelegate(GoButt);
            IAsyncResult result = del.BeginInvoke(maxValue, null, null);


        }
        void Print(string str)
        {
            ResultLabel.Text = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResultLabel.Text = "";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            tbSum.Text = (int.Parse(tbTerm.Text) + 5).ToString();
        }





    }
}
