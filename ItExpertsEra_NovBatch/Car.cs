using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItExpertsEra_NovBatch
{
    public class Car
    {
        int speed = 20;
        public void Accelerator(int pressure)
        {
             speed = pressure * 10;

            Console.WriteLine("Speed of the car is " + speed);
        }

        public void Break(int pressure)
        {
             speed = pressure / 10;

            Console.WriteLine("Speed of the car is " + speed);
        }

        public void Clutch(int pressure)
        {
            speed = pressure;

            Console.WriteLine("Speed of the car is " + speed);
        }
    }
}
