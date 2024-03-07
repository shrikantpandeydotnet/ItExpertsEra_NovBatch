using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItExpertsEra_NovBatch
{
    public class MethodOverloadingExample
    {
        public void Sum()
        {
            Console.WriteLine("I am default method");
        }

        public void Sum(int a)
        {
            Console.WriteLine("I am a method with parameter " + a);
        }

        public void Sum(string a)
        {
            Console.WriteLine("I am a method with parameter " + a);
        }

        public void Sum(double a, double b)
        {
            Console.WriteLine(a + b);
        }

    }
}
