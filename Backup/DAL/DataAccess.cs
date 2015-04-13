using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DAL
{
    public class DataAccess
    {
        carD c = new carD();
        public void saveSpeed(int speed)
        {
            try
            {
                StreamWriter w = new StreamWriter("D:\\car.txt");
                w.WriteLine(c.speed);
                w.Close();
            
            }
            catch (Exception)
            {

            }
        }
        public int getSpeed()
        {
            carD c = new carD();
            try
            {
                StreamReader r = new StreamReader("D:\\car.txt");
                c.speed = Convert.ToInt32(r.ReadLine());
                r.Close();
                return c.speed;
            }
            catch (Exception)
            {

               
            }

        }
    }
}
