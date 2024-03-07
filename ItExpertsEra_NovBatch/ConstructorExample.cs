using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItExpertsEra_NovBatch
{
    public class ConstructorExample
    {

        public int varInt;

        // static keyword

        public static int varStaticInt;

        public static void TestMethod()
        {
            Console.WriteLine("I am static method");

            varStaticInt = 10;
        }

        public  void TestMethod2()
        {
            Console.WriteLine("I am static method");

            varStaticInt = 10;

            varInt = 200;
        }

        // Default Constructor
        public ConstructorExample()
        {
            varInt = 10;
        }


        // Parameterized Constructor
        public ConstructorExample(int var1)
        {
            varInt = var1;
        }

        public ConstructorExample(int var1, int var2)
        {
            varInt = var1 + var2;
        }

        // Copy Constructor 

        public ConstructorExample(ConstructorExample consEx)
        {
            varInt = consEx.varInt;
        }

        // static constructor

        static ConstructorExample()
        {
            varStaticInt = 1000;
        }
    }
}
