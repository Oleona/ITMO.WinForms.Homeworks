
using System.ComponentModel;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ITMOLab3hwFormsApplication
{
    public partial class Validate : UserControl
    {
        public Validate()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"\.\w{3,4}?\r?$";            
            Regex regex = new Regex(pattern);
            if (textBox1.Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                bool isMatch = Regex.IsMatch(textBox1.Text, pattern, RegexOptions.IgnoreCase);
                if (isMatch)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Файл задан неверно");
                }
            }
        }
    }

}

