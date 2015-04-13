using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;

namespace Entity
{
    public class carD
    {
        public int speed;

        Pen drawPen = new Pen(Color.LightSlateGray, 2);

        public void carDrawUp_Paint(object sender, System.Windows.Forms.PaintEventArgs e){
            
            Point P1 = new Point(50, 50);
            Point P2 = new Point(100, 50);
            Point P3 = new Point(150, 130);
            Point P4 = new Point(150, 200);
            Point P5 = new Point(0, 200);
            Point P6 = new Point(0, 130);
            Point[] P = { P1, P2, P3, P4, P5, P6, P1 };

            Graphics g = e.Graphics;
            e.Graphics.DrawLines(drawPen, P);
        }

        public void carDrawDown_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

            Point P1 = new Point(0, 50);
            Point P2 = new Point(150, 50);
            Point P3 = new Point(150, 130);
            Point P4 = new Point(100, 200);
            Point P5 = new Point(50, 200);
            Point P6 = new Point(0, 130);
            Point[] P = { P1, P2, P3, P4, P5, P6, P1 };

            Graphics g = e.Graphics;
            e.Graphics.DrawLines(drawPen, P);
        }

        public void carDrawLeft_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

            Point P1 = new Point(50, 50);
            Point P2 = new Point(50, 100);
            Point P3 = new Point(130, 150);
            Point P4 = new Point(200, 150);
            Point P5 = new Point(200, 0);
            Point P6 = new Point(130, 0);
            Point[] P = { P1, P2, P3, P4, P5, P6, P1 };

            Graphics g = e.Graphics;
            e.Graphics.DrawLines(drawPen, P);
        }

        public void carDrawRight_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

            Point P1 = new Point(50, 0);
            Point P2 = new Point(130, 0);
            Point P3 = new Point(200, 50);
            Point P4 = new Point(200, 100);
            Point P5 = new Point(130, 150);
            Point P6 = new Point(50, 150);
            Point[] P = { P1, P2, P3, P4, P5, P6, P1 };

            Graphics g = e.Graphics;
            e.Graphics.DrawLines(drawPen, P);
        }

    }
}
