using System;
using System.Drawing;
using System.Windows.Forms;

namespace ITMOLab1Hw1FormsApplication
{
    public partial class roundForm : Form
    {
        public roundForm()
        {
            InitializeComponent();
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundForm_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath =new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(0, 0, this.Width, this.Height);
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }
    }
}
