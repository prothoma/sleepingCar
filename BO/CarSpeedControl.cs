using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace BO
{
    public class CarSpeedControl
    {
        DataAccess b = new DataAccess();

        public void saveSpeed(int speed)
        {
            int temp = speed;
             b.saveSpeed(temp);
        }
        public int getSpeed()
        {
            return b.getSpeed();
        }


        Rectangle rect1 = new Rectangle(-100, -100, 400, 280);
        Rectangle rect2 = new Rectangle(900, -100, 400, 280);
        Rectangle rect3 = new Rectangle(-100, 760, 400, 250);
        Rectangle rect4 = new Rectangle(900, 760, 400, 250);

        Point loopCircle = new Point(360, 260);

        public int detCollison(int x1, int y1, int x2, int y2)
        {
            Rectangle carPanel = new Rectangle(x1, y1, x2, y2);
            Point carMiddle = new Point(x1 + 40, x2 + 40);

            /*double xDist = (loopCircle.X - x1) * (loopCircle.X - x1);
            double yDist = (loopCircle.Y - y1) * (loopCircle.Y - y1);
            double distance = Math.Pow((xDist + yDist), .5);

            if (distance <= 60)
            {
                return 1;
            }*/
            if (carPanel.IntersectsWith(rect1))
            {
                return 1;
            }
            else if (carPanel.IntersectsWith(rect2))
            {
                return 1;
            }
            else if (carPanel.IntersectsWith(rect3))
            {
                return 1;
            }
            else if (carPanel.IntersectsWith(rect4))
            {
                return 1;
            }
            
            return 0;
        }
    }
}
