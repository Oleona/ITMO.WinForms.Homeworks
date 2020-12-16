using System;
using System.Windows.Forms;

namespace WWinAsynchDelegate
{
    public partial class Form1 : Form
    {
       bool Cancel;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле должно содержать цифры");
            }

        }
       

        public delegate void SetProgressDelegate(int val);

        public void SetProgress(int val)
        {
            if (progressBar1.InvokeRequired)
            {
                var del = new SetProgressDelegate(SetProgress);
                this.Invoke(del, new object[] { val });
            }
            else
            {
                progressBar1.Value = val;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int seconds = int.Parse(textBox1.Text);

            var del = new TimeConsumingMethodDelegate(TimeConsumingMethod);
            del.BeginInvoke(seconds, null, null);
        }

        private delegate void TimeConsumingMethodDelegate(int seconds);

        private void TimeConsumingMethod(int seconds)
        {
            for (int j = 1; j <= seconds; j++)
            {
                System.Threading.Thread.Sleep(1000);
                SetProgress(j * 100 / seconds);
                if (Cancel)
                    break;
            }
            if (Cancel)
            {
                MessageBox.Show("Cancelled");
                Cancel = false;
            }
            else
            {
                MessageBox.Show("Complete");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cancel = true;
        }
    }
}
