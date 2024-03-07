using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItExpertsEra_NovBatch
{
    internal class MethodOverridingExample
    {
    }


    public partial class A
    {
        public virtual void TestMethod()
        {
            Console.WriteLine(" I am test method");
        }

        public void TestMethod2()
        {
            Console.WriteLine("I am parent class test method 2");
        }
    }

    public class B : A
    {

        public override void TestMethod()
        {
            Console.WriteLine("I am child class test method");
        }


        public new void TestMethod2()
        {
            Console.WriteLine("I am child class Test Method 2");
        }

    }

    public class C : B
    {
        public sealed override void TestMethod()
        {
            Console.WriteLine("I am C Test Method");
        }
    }

    public class D : C
    {
        //public sealed override void TestMethod()
        //{
        //    Console.WriteLine("I am C Test Method");
        //}
    }
}
