using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BO
{
    public class CarSpeedControl
    {
        DataAccess b = new DataAccess();

        public void saveSpeed(int speed)
        {
             b.saveSpeed(speed);
        }
        public int getSpeed()
        {
            return b.getSpeed();
        }
    }
}
