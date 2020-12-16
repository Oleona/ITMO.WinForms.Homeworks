using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Quadratic : Form
    {
        public Quadratic()
        {
            InitializeComponent();
        }


        private void btnDecide_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);


            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                rtbResult.Text= "Discriminant is less than zero. No roots.";
            }
            else if (discriminant == 0)
            {
                double x = (-b / (2 * a));
                rtbResult.Text = "Discriminant is zero. The root is " + x + ".";
            }

            else if (discriminant > 0)
            {
                double x1 = ((-b - Math.Sqrt(discriminant)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(discriminant)) / (2 * a));
                rtbResult.Text = "Discriminant is " + discriminant + "\n" + ". First root " + x1+ "\n" + ". Second root " + x2 + ".";
            }

        }
    }
}
