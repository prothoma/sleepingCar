using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Drawing;

namespace Entity
{
    public class carD
    {
        public int speed;

        Pen drawPen = new Pen(Color.Black, 1);
        Pen drawPen2 = new Pen(Color.Black, 2);

        Brush brBLK = new SolidBrush(Color.Black);
        Brush brBLU = new SolidBrush(Color.Blue);
        Brush brLSG = new SolidBrush(Color.LightSlateGray);
        Brush brDKG = new SolidBrush(Color.DarkGray);
        Brush brDMG = new SolidBrush(Color.DimGray);
        Brush brCRB = new SolidBrush(Color.CornflowerBlue);
        Brush brRED = new SolidBrush(Color.Red);
        Brush brGRY = new SolidBrush(Color.Gray);
        Brush brDSG = new SolidBrush(Color.DarkSlateGray);

        Brush brGrass = new SolidBrush(Color.DimGray);
        Brush brRoad = new SolidBrush(Color.Gray);
        Brush brLoop = new SolidBrush(Color.DarkGray);
        
        Brush br1 = new SolidBrush(Color.Orchid);
        
        


        public void drawRect0(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Point r1p1 = new Point(0, 0);
            Point r1p2 = new Point(800, 0);
            Point r1p3 = new Point(800, 600);
            Point r1p4 = new Point(0, 600);
            Point[] p = { r1p1, r1p2, r1p3, r1p4 };
            e.Graphics.FillPolygon(brRoad, p);
        }

        public void drawRect1(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Point r1p1 = new Point(0, 0);
            Point r1p2 = new Point(300, 0);
            Point r1p3 = new Point(300, 175);
            Point r1p4 = new Point(0, 175);
            
            Point[] p = { r1p1, r1p2, r1p3, r1p4 };
            e.Graphics.FillPolygon(brGrass, p);

        }
        public void drawRect2(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Point r1p1 = new Point(500, 0);
            Point r1p2 = new Point(800, 0);
            Point r1p3 = new Point(800, 175);
            Point r1p4 = new Point(500, 175);
            Point[] p = { r1p1, r1p2, r1p3, r1p4 };
            e.Graphics.FillPolygon(brGrass, p);
        }
        public void drawRect3(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Point r1p1 = new Point(0, 425);
            Point r1p2 = new Point(300, 425);
            Point r1p3 = new Point(300, 570);
            Point r1p4 = new Point(0, 570);
            Point[] p = { r1p1, r1p2, r1p3, r1p4 };
            e.Graphics.FillPolygon(brGrass, p);
        }
        public void drawRect4(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Point r1p1 = new Point(500, 425);
            Point r1p2 = new Point(800, 425);
            Point r1p3 = new Point(800, 570);
            Point r1p4 = new Point(500, 570);
            Point[] p = { r1p1, r1p2, r1p3, r1p4 };
            e.Graphics.FillPolygon(brGrass, p);
        }


       /* public void drawLoop(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.FillEllipse(brLoop, 383, 281, 40, 40);
            e.Graphics.FillEllipse(brBLK, 400, 295, 10, 10);
        }*/


        public void carDrawUp_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            
            Point P1 = new Point(25, 8);
            Point P2 = new Point(28, 3);
            Point PS1 = new Point(31, 1);

            Point PS2 = new Point(48, 1);
            Point P3 = new Point(52, 3);
            Point P4 = new Point(55, 8);

            Point P5 = new Point(55, 23);
            Point P6 = new Point(57, 25);
            Point P7 = new Point(57, 30);
            Point P8 = new Point(55, 33);
            
            Point P9 = new Point(55, 50);
            Point P10 = new Point(57, 55);
            Point P11 = new Point(57, 60);
            Point P12 = new Point(55, 63);
            Point PS9 = new Point(55, 63);
            Point PS10 = new Point(57, 68);
            Point PS11 = new Point(57, 73);
            Point PS12 = new Point(55, 76);

            Point P13 = new Point(55, 87);
            Point P14 = new Point(48, 89);
            Point P15 = new Point(33, 89);
            Point P16 = new Point(25, 87);
            
            Point P17 = new Point(25, 63);
            Point P18 = new Point(23, 60);
            Point P19 = new Point(23, 55);
            Point P20 = new Point(25, 50);
            Point PS17 = new Point(25, 76);
            Point PS18 = new Point(23, 73);
            Point PS19 = new Point(23, 68);
            Point PS20 = new Point(25, 63);
            
            Point P21 = new Point(25, 33);
            Point P22 = new Point(23, 30);
            Point P23 = new Point(23, 25);
            Point P24 = new Point(25, 23);



            Point aP1 = new Point(28, 18);
            Point aP2 = new Point(34, 14);
            Point aP3 = new Point(46, 14);
            Point aP4 = new Point(52, 18);
            Point aP5 = new Point(52, 30);
            Point aP6 = new Point(28, 30);

            Point aP7 = new Point(52, 50);
            Point aP8 = new Point(28, 50);

            Point aP9 = new Point(50, 53);
            Point aP10 = new Point(50, 83);
            Point aP11 = new Point(47, 86);
            Point aP12 = new Point(33, 86);
            Point aP13 = new Point(30, 83);
            Point aP14 = new Point(30, 53);
            

            //array
            Point[] PA = { P1, P2, PS1, PS2, P3, P4, P8, P13, P14, P15, P16, P1 };

            Point[] WR0 = { P5, P6, P7, P8, P5 };
            Point[] WL0 = { P21, P22, P23, P24, P21 };
            
            Point[] WR1 = { P9, P10, P11, P12, P9 };
            Point[] WR2 = { PS9, PS10, PS11, PS12, PS9 };
            
            Point[] WL1 = { P17, P18, P19, P20, P17 };
            Point[] WL2 = { PS17, PS18, PS19, PS20, PS17 };

            Point[] PA2 = { aP1, aP2, aP3, aP4, aP5, aP6, aP1 };
            
            Point[] PA3 = { aP6, aP8, aP7, aP5, aP6 };

            Point[] PA4 = { aP9, aP10, aP11, aP12, aP13, aP14, aP9 };
            
            //color
            var p = sender as Panel;
            var g = e.Graphics;
            
            g.FillPolygon(brRED, PA);
            g.FillPolygon(brDSG, PA2);
            g.FillPolygon(brRED, PA3);
            g.FillPolygon(brBLK, PA4);

            g.FillPolygon(brDMG, WR0);
            g.FillPolygon(brDMG, WR1);
            g.FillPolygon(brDMG, WR2);
            g.FillPolygon(brDMG, WL0);
            g.FillPolygon(brDMG, WL1);
            g.FillPolygon(brDMG, WL2);

            //skeleton
            e.Graphics.DrawLines(drawPen, PA);

            e.Graphics.DrawLines(drawPen, WR0);
            e.Graphics.DrawLines(drawPen, WL0);

            e.Graphics.DrawLines(drawPen, WR1);
            e.Graphics.DrawLines(drawPen, WR2);

            e.Graphics.DrawLines(drawPen, WL1);
            e.Graphics.DrawLines(drawPen, WL2);

            e.Graphics.DrawLines(drawPen, PA2);

            e.Graphics.DrawLines(drawPen, PA3);

            e.Graphics.DrawLines(drawPen, PA4);

        }


        public void carDrawDown_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

            Point P1 = new Point(25, 82);
            Point P2 = new Point(28, 87);
            Point PS1 = new Point(31, 89);

            Point PS2 = new Point(48, 89);
            Point P3 = new Point(52, 87);
            Point P4 = new Point(55, 82);

            Point P5 = new Point(55, 67);
            Point P6 = new Point(57, 65);
            Point P7 = new Point(57, 60);
            Point P8 = new Point(55, 57);

            Point P9 = new Point(55, 40);
            Point P10 = new Point(57, 35);
            Point P11 = new Point(57, 30);
            Point P12 = new Point(55, 27);
            Point PS9 = new Point(55, 27);
            Point PS10 = new Point(57, 22);
            Point PS11 = new Point(57, 17);
            Point PS12 = new Point(55, 14);

            Point P13 = new Point(55, 3);
            Point P14 = new Point(48, 1);
            Point P15 = new Point(33, 1);
            Point P16 = new Point(25, 3);

            Point P17 = new Point(25, 27);
            Point P18 = new Point(23, 30);
            Point P19 = new Point(23, 35);
            Point P20 = new Point(25, 40);
            Point PS17 = new Point(25, 14);
            Point PS18 = new Point(23, 17);
            Point PS19 = new Point(23, 22);
            Point PS20 = new Point(25, 27);

            Point P21 = new Point(25, 57);
            Point P22 = new Point(23, 60);
            Point P23 = new Point(23, 65);
            Point P24 = new Point(25, 67);



            Point aP1 = new Point(28, 72);
            Point aP2 = new Point(34, 76);
            Point aP3 = new Point(46, 76);
            Point aP4 = new Point(52, 72);
            Point aP5 = new Point(52, 60);
            Point aP6 = new Point(28, 60);

            Point aP7 = new Point(52, 40);
            Point aP8 = new Point(28, 40);

            Point aP9 = new Point(50, 37);
            Point aP10 = new Point(50, 7);
            Point aP11 = new Point(47, 4);
            Point aP12 = new Point(33, 4);
            Point aP13 = new Point(30, 7);
            Point aP14 = new Point(30, 37);


            //array
            Point[] PA = { P1, P2, PS1, PS2, P3, P4, P8, P13, P14, P15, P16, P1 };

            Point[] WR0 = { P5, P6, P7, P8, P5 };
            Point[] WL0 = { P21, P22, P23, P24, P21 };

            Point[] WR1 = { P9, P10, P11, P12, P9 };
            Point[] WR2 = { PS9, PS10, PS11, PS12, PS9 };

            Point[] WL1 = { P17, P18, P19, P20, P17 };
            Point[] WL2 = { PS17, PS18, PS19, PS20, PS17 };

            Point[] PA2 = { aP1, aP2, aP3, aP4, aP5, aP6, aP1 };

            Point[] PA3 = { aP6, aP8, aP7, aP5, aP6 };

            Point[] PA4 = { aP9, aP10, aP11, aP12, aP13, aP14, aP9 };

            //color
            var p = sender as Panel;
            var g = e.Graphics;

            g.FillPolygon(brRED, PA);
            g.FillPolygon(brDSG, PA2);
            g.FillPolygon(brRED, PA3);
            g.FillPolygon(brBLK, PA4);

            g.FillPolygon(brDMG, WR0);
            g.FillPolygon(brDMG, WR1);
            g.FillPolygon(brDMG, WR2);
            g.FillPolygon(brDMG, WL0);
            g.FillPolygon(brDMG, WL1);
            g.FillPolygon(brDMG, WL2);

            //skeleton
            e.Graphics.DrawLines(drawPen, PA);

            e.Graphics.DrawLines(drawPen, WR0);
            e.Graphics.DrawLines(drawPen, WL0);

            e.Graphics.DrawLines(drawPen, WR1);
            e.Graphics.DrawLines(drawPen, WR2);

            e.Graphics.DrawLines(drawPen, WL1);
            e.Graphics.DrawLines(drawPen, WL2);

            e.Graphics.DrawLines(drawPen, PA2);

            e.Graphics.DrawLines(drawPen, PA3);

            e.Graphics.DrawLines(drawPen, PA4);

        }

        public void carDrawLeft_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

            Point P1 = new Point(8, 25);
            Point P2 = new Point(3, 28);
            Point PS1 = new Point(1, 31);

            Point PS2 = new Point(1, 48);
            Point P3 = new Point(3, 52);
            Point P4 = new Point(8, 55);

            Point P5 = new Point(23, 55);
            Point P6 = new Point(25, 57);
            Point P7 = new Point(30, 57);
            Point P8 = new Point(33, 55);

            Point P9 = new Point(50, 55);
            Point P10 = new Point(55, 57);
            Point P11 = new Point(60, 57);
            Point P12 = new Point(63, 55);
            Point PS9 = new Point(63, 55);
            Point PS10 = new Point(68, 57);
            Point PS11 = new Point(73, 57);
            Point PS12 = new Point(76, 55);

            Point P13 = new Point(87, 55);
            Point P14 = new Point(89, 48);
            Point P15 = new Point(89, 33);
            Point P16 = new Point(87, 25);

            Point P17 = new Point(63, 25);
            Point P18 = new Point(60, 23);
            Point P19 = new Point(55, 23);
            Point P20 = new Point(50, 25);
            Point PS17 = new Point(76, 25);
            Point PS18 = new Point(73, 23);
            Point PS19 = new Point(68, 23);
            Point PS20 = new Point(63, 25);

            Point P21 = new Point(33, 25);
            Point P22 = new Point(30, 23);
            Point P23 = new Point(25, 23);
            Point P24 = new Point(23, 25);



            Point aP1 = new Point(18, 28);
            Point aP2 = new Point(14, 34);
            Point aP3 = new Point(14, 46);
            Point aP4 = new Point(18, 52);
            Point aP5 = new Point(30, 52);
            Point aP6 = new Point(30, 28);

            Point aP7 = new Point(50, 52);
            Point aP8 = new Point(50, 28);

            Point aP9 = new Point(53, 50);
            Point aP10 = new Point(83, 50);
            Point aP11 = new Point(86, 47);
            Point aP12 = new Point(86, 33);
            Point aP13 = new Point(83, 30);
            Point aP14 = new Point(53, 30);


            //array
            Point[] PA = { P1, P2, PS1, PS2, P3, P4, P8, P13, P14, P15, P16, P1 };

            Point[] WR0 = { P5, P6, P7, P8, P5 };
            Point[] WL0 = { P21, P22, P23, P24, P21 };

            Point[] WR1 = { P9, P10, P11, P12, P9 };
            Point[] WR2 = { PS9, PS10, PS11, PS12, PS9 };

            Point[] WL1 = { P17, P18, P19, P20, P17 };
            Point[] WL2 = { PS17, PS18, PS19, PS20, PS17 };

            Point[] PA2 = { aP1, aP2, aP3, aP4, aP5, aP6, aP1 };

            Point[] PA3 = { aP6, aP8, aP7, aP5, aP6 };

            Point[] PA4 = { aP9, aP10, aP11, aP12, aP13, aP14, aP9 };

            //color
            var p = sender as Panel;
            var g = e.Graphics;

            g.FillPolygon(brRED, PA);
            g.FillPolygon(brDSG, PA2);
            g.FillPolygon(brRED, PA3);
            g.FillPolygon(brBLK, PA4);

            g.FillPolygon(brDMG, WR0);
            g.FillPolygon(brDMG, WR1);
            g.FillPolygon(brDMG, WR2);
            g.FillPolygon(brDMG, WL0);
            g.FillPolygon(brDMG, WL1);
            g.FillPolygon(brDMG, WL2);

            //skeleton
            e.Graphics.DrawLines(drawPen, PA);

            e.Graphics.DrawLines(drawPen, WR0);
            e.Graphics.DrawLines(drawPen, WL0);

            e.Graphics.DrawLines(drawPen, WR1);
            e.Graphics.DrawLines(drawPen, WR2);

            e.Graphics.DrawLines(drawPen, WL1);
            e.Graphics.DrawLines(drawPen, WL2);

            e.Graphics.DrawLines(drawPen, PA2);

            e.Graphics.DrawLines(drawPen, PA3);

            e.Graphics.DrawLines(drawPen, PA4);

        }




        public void carDrawRight_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

            Point P1 = new Point(82, 25);
            Point P2 = new Point(87, 28);
            Point PS1 = new Point(89, 31);

            Point PS2 = new Point(89, 48);
            Point P3 = new Point(87, 52);
            Point P4 = new Point(82, 55);

            Point P5 = new Point(67, 55);
            Point P6 = new Point(65, 57);
            Point P7 = new Point(60, 57);
            Point P8 = new Point(57, 55);

            Point P9 = new Point(40, 55);
            Point P10 = new Point(35, 57);
            Point P11 = new Point(30, 57);
            Point P12 = new Point(27, 55);
            Point PS9 = new Point(27, 55);
            Point PS10 = new Point(22, 57);
            Point PS11 = new Point(17, 57);
            Point PS12 = new Point(14, 55);

            Point P13 = new Point(3, 55);
            Point P14 = new Point(1, 48);
            Point P15 = new Point(1, 33);
            Point P16 = new Point(3, 25);

            Point P17 = new Point(27, 25);
            Point P18 = new Point(30, 23);
            Point P19 = new Point(35, 23);
            Point P20 = new Point(40, 25);
            Point PS17 = new Point(14, 25);
            Point PS18 = new Point(17, 23);
            Point PS19 = new Point(22, 23);
            Point PS20 = new Point(27, 25);

            Point P21 = new Point(57, 25);
            Point P22 = new Point(60, 23);
            Point P23 = new Point(65, 23);
            Point P24 = new Point(67, 25);



            Point aP1 = new Point(72, 28);
            Point aP2 = new Point(76, 34);
            Point aP3 = new Point(76, 46);
            Point aP4 = new Point(72, 52);
            Point aP5 = new Point(60, 52);
            Point aP6 = new Point(60, 28);

            Point aP7 = new Point(40, 52);
            Point aP8 = new Point(40, 28);

            Point aP9 = new Point(37, 50);
            Point aP10 = new Point(7, 50);
            Point aP11 = new Point(4, 47);
            Point aP12 = new Point(4, 33);
            Point aP13 = new Point(7, 30);
            Point aP14 = new Point(37, 30);


            //array
            Point[] PA = { P1, P2, PS1, PS2, P3, P4, P8, P13, P14, P15, P16, P1 };

            Point[] WR0 = { P5, P6, P7, P8, P5 };
            Point[] WL0 = { P21, P22, P23, P24, P21 };

            Point[] WR1 = { P9, P10, P11, P12, P9 };
            Point[] WR2 = { PS9, PS10, PS11, PS12, PS9 };

            Point[] WL1 = { P17, P18, P19, P20, P17 };
            Point[] WL2 = { PS17, PS18, PS19, PS20, PS17 };

            Point[] PA2 = { aP1, aP2, aP3, aP4, aP5, aP6, aP1 };

            Point[] PA3 = { aP6, aP8, aP7, aP5, aP6 };

            Point[] PA4 = { aP9, aP10, aP11, aP12, aP13, aP14, aP9 };

            //color
            var p = sender as Panel;
            var g = e.Graphics;

            g.FillPolygon(brRED, PA);
            g.FillPolygon(brDSG, PA2);
            g.FillPolygon(brRED, PA3);
            g.FillPolygon(brBLK, PA4);

            g.FillPolygon(brDMG, WR0);
            g.FillPolygon(brDMG, WR1);
            g.FillPolygon(brDMG, WR2);
            g.FillPolygon(brDMG, WL0);
            g.FillPolygon(brDMG, WL1);
            g.FillPolygon(brDMG, WL2);

            //skeleton
            e.Graphics.DrawLines(drawPen, PA);

            e.Graphics.DrawLines(drawPen, WR0);
            e.Graphics.DrawLines(drawPen, WL0);

            e.Graphics.DrawLines(drawPen, WR1);
            e.Graphics.DrawLines(drawPen, WR2);

            e.Graphics.DrawLines(drawPen, WL1);
            e.Graphics.DrawLines(drawPen, WL2);

            e.Graphics.DrawLines(drawPen, PA2);

            e.Graphics.DrawLines(drawPen, PA3);

            e.Graphics.DrawLines(drawPen, PA4);

        }
    }
}
