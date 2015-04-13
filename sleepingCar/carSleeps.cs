using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Entity;
using BO;

namespace sleepingCar
{
    public partial class carSleep : Form
    {
        private int x;
        private int y;
        
        enum carDirection {
            Left, Right, Up, Down, Stable
        }

        private carDirection cDrct;

        carD entityOb = new carD();
        CarSpeedControl s = new CarSpeedControl();
        

        public carSleep()
        {
            InitializeComponent();
            //panel1.Paint += paintCar;
            //Controls.Add(panel1);

            Paint += new PaintEventHandler(entityOb.drawRect0);
            Paint += new PaintEventHandler(entityOb.drawRect1);
            Paint += new PaintEventHandler(entityOb.drawRect2);
            Paint += new PaintEventHandler(entityOb.drawRect3);
            Paint += new PaintEventHandler(entityOb.drawRect4);

            //Paint += new PaintEventHandler(entityOb.drawLoop);

            //this.panel1.BackColor = System.Drawing.Color.Transparent;

            bP01 = new Point(0, 0);
            x = 50;
            y = 260;
            cDrct = carDirection.Stable;
        }

        Point bP01;


        private int getSpeed() {
            int temp = s.getSpeed();
            return temp;
        }
        private void setSpeed(int _speed) {
            s.saveSpeed(_speed);
        }

        private int getBaseX() {
            return x;
        }
        private int getBaseY() {
            return y;
        }
        private void setBaseX(int _x){
            x += _x;
        }
        private void setBaseY(int _y)
        {
            y += _y;
        }

        

        private void paintCar(object sender, PaintEventArgs e)
        {
            //panel1.CreateGraphics();
            this.panel1.Location = new Point(bP01.X+ getBaseX(),bP01.Y+ getBaseY());
            panel1.Invalidate();
            
        }

        private void collisionReaction()
        {
            if (cDrct == carDirection.Left)
            {
                setBaseX(getSpeed() * (1));
                cDrct = carDirection.Right;
            }
            else if (cDrct == carDirection.Right)
            {
                setBaseX(getSpeed() * -1);
                cDrct = carDirection.Left;
            }
            else if (cDrct == carDirection.Up)
            {
                setBaseY(getSpeed() * (1));
                cDrct = carDirection.Down;
            }
            else if (cDrct == carDirection.Down)
            {
                setBaseY(getSpeed() * -1);
                cDrct = carDirection.Up;
            }
        }


        private void drawInterval_Tick(object sender, EventArgs e)
        {
            if (s.detCollison(getBaseX(), getBaseY(), getBaseX() + 90, getBaseY() + 90) == 1 && (cDrct == carDirection.Left || cDrct == carDirection.Right))
            {
                collisionReaction();
            }
            else if (s.detCollison(getBaseX(), getBaseY(), getBaseX() + 90, getBaseY() + 90) == 1 && (cDrct == carDirection.Up || cDrct == carDirection.Down))
            {
                collisionReaction();
            }

            else
            {
                if (cDrct == carDirection.Left)
                {
                    setBaseX(getSpeed() * (-1));
                }
                else if (cDrct == carDirection.Right)
                {
                    setBaseX(getSpeed() * 1);
                }
                else if (cDrct == carDirection.Up)
                {
                    setBaseY(getSpeed() * (-1));
                }
                else if (cDrct == carDirection.Down)
                {
                    setBaseY(getSpeed() * 1);
                }
            }

            Invalidate();
        }


        private void carSleep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) {
                cDrct = carDirection.Left;
                //this.panel1.Width = 67;
                //this.panel1.Height = 35;
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawRight_Paint);
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawUp_Paint);
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawDown_Paint);
                this.panel1.Paint += new PaintEventHandler(entityOb.carDrawLeft_Paint);
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawRight_Paint);
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawUp_Paint);
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawDown_Paint);
            }
            else if (e.KeyCode == Keys.Right) {
                cDrct = carDirection.Right;
                //this.panel1.Width = 67;
                //this.panel1.Height = 35;
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawLeft_Paint);
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawUp_Paint);
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawDown_Paint);
                this.panel1.Paint += new PaintEventHandler(entityOb.carDrawRight_Paint);
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawLeft_Paint);
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawUp_Paint);
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawDown_Paint);
            }
            else if (e.KeyCode == Keys.Up) {
                cDrct = carDirection.Up;
                //this.panel1.Width = 35;
                //this.panel1.Height = 67;
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawLeft_Paint);
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawRight_Paint);
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawDown_Paint);
                this.panel1.Paint += new PaintEventHandler(entityOb.carDrawUp_Paint);
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawLeft_Paint);
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawRight_Paint);
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawDown_Paint);
            }
            else if (e.KeyCode == Keys.Down) {
                cDrct = carDirection.Down;
                //this.panel1.Width = 35;
                //this.panel1.Height = 67;
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawLeft_Paint);
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawRight_Paint);
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawUp_Paint);
                this.panel1.Paint += new PaintEventHandler(entityOb.carDrawDown_Paint);
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawLeft_Paint);
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawRight_Paint);
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawUp_Paint);
            }
            else if (e.KeyCode == Keys.Space) {
                cDrct = carDirection.Stable;
            }
        }



        private void kmhourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s.saveSpeed(5);
        }

        private void kmhourToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            s.saveSpeed(10);
        }

        private void kmhourToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            s.saveSpeed(20);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
