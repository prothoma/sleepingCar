using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Entity;

namespace DAL
{
    public class DataAccess
    {
        carD c = new carD();
        public void saveSpeed(int speed)
        {
            try
            {
                c.speed = speed;
                string temp = Convert.ToString(c.speed);
                File.WriteAllText("F:\\car.txt", temp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int getSpeed()
        {
            try
            {
                string input = File.ReadAllText("F:\\car.txt");
                c.speed = Convert.ToInt32(input);
                return c.speed;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
