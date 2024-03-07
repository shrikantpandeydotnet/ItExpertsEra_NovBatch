using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItExpertsEra_NovBatch
{

    public abstract class AbstractClassEx {

        public abstract void TestMethod();
        public abstract void TestMethod2(int a);
        public abstract void TestMethod3(int a, int b);
        public abstract void TestMethod4();
    }
    public abstract class AbstractClassExample
    {

        public AbstractClassExample()
        {
            Console.WriteLine("I am abstract class constructor");
        }

        public void TestMethod()
        {
            Console.WriteLine("I am a Test Method");
        }

        public void TestMethod22()
        {
            Console.WriteLine("I am a Test Method 22");
        }

        public abstract void TestMethod2();

        public abstract int Sum(int a, int b);
    }

    public class ChildClass1 : AbstractClassExample
    {
        public override void TestMethod2()
        {
            Console.WriteLine(" I am test method 2");
        }

        public override int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
