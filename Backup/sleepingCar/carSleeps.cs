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
        private int speed;
        private int theta;

        enum carDirection {
            Left, Right, Up, Down, Stable
        }

        private carDirection cDrct;

        carD entityOb = new carD();

        public carSleep()
        {
            InitializeComponent();


            //panel1.Paint += paintCar;
            //Controls.Add(panel1);
            
            bP01 = new Point(250, 150);
            x = 25;
            y = 15;
            speed = 2;
            cDrct = carDirection.Stable;
        }

        Point bP01, bP02,bP03, bP04, bP05, bP06, bP07, bP08; 


        private int getTheta() {
            return theta;
        }
        private void setTheta(int _theta) {
            theta += _theta;
        }

        private int getSpeed() {
            return speed;
        }
        private void setSpeed(int _speed) {
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
            this.panel1.Location = new Point(bP01.X + getBaseX(), bP01.Y + getBaseY());
            panel1.Invalidate();
            //Pen penOb = new Pen(Color.LightSlateGray, 2);
            
        }

        private void drawInterval_Tick(object sender, EventArgs e)
        {
            if (cDrct == carDirection.Left) {

                setBaseX(getSpeed()*(-1));
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

            Invalidate();
        }

        private void carSleep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) {
                cDrct = carDirection.Left;
                this.panel1.Paint += new PaintEventHandler(entityOb.carDrawLeft_Paint);
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawRight_Paint);
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawUp_Paint);
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawDown_Paint);

            }
            else if (e.KeyCode == Keys.Right) {
                cDrct = carDirection.Right;
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawLeft_Paint);
                this.panel1.Paint += new PaintEventHandler(entityOb.carDrawRight_Paint);
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawUp_Paint);
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawDown_Paint);
            }
            else if (e.KeyCode == Keys.Up) {
                cDrct = carDirection.Up;
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawLeft_Paint);
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawRight_Paint);
                this.panel1.Paint += new PaintEventHandler(entityOb.carDrawUp_Paint);
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawDown_Paint);
            }
            else if (e.KeyCode == Keys.Down) {
                cDrct = carDirection.Down;
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawLeft_Paint);
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawRight_Paint);
                this.panel1.Paint -= new PaintEventHandler(entityOb.carDrawUp_Paint);
                this.panel1.Paint += new PaintEventHandler(entityOb.carDrawDown_Paint);
            }
            else if (e.KeyCode == Keys.Space) {
                cDrct = carDirection.Stable;
            }
        }
        CarSpeedControl s = new CarSpeedControl();
        private void savebtn_Click(object sender, EventArgs e)
        {
            carD c = new carD();
            try
            {

                c.speed= Convert.ToInt32(textBox1.Text);
                s.saveSpeed(c.speed);
              

            }
            catch (Exception)
            {

            }
        }
    }
}
