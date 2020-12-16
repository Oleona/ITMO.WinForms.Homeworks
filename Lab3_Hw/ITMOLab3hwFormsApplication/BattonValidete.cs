using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMOLab3hwFormsApplication
{
    public class BattonValidete : System.Windows.Forms.Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs pe)
        {
            Font font1 = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
                base.OnPaint(pe);
            Graphics g = pe.Graphics;
            g.FillEllipse(Brushes.Green, new Rectangle(0, 0, 100, 50));
            string text1 = "Проверить";
            g.DrawString(text1, font1, Brushes.Blue, new Rectangle(7,14, 100, 50));
        }
    }

}
