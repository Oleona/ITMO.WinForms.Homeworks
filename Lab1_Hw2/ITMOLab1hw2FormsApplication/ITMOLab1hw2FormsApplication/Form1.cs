using System;
using System.Drawing;
using System.Windows.Forms;

namespace ITMOLab1hw2FormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Green;
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();

            myPath.AddLines(new[]
                           {
                   new Point(0, Height / 2),
                   new Point(Width / 2, 0),
                   new Point(Width, Height / 2),
                   new Point(Width / 2, Height)

               });

            Region myRegion = new Region(myPath);
            this.Region = myRegion;

            GREENPEACE.Left = (this.ClientSize.Width - GREENPEACE.Width) / 2;
            GREENPEACE.Top = (this.ClientSize.Height - GREENPEACE.Height) / 2;
        }

        private void GREENPEACE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
