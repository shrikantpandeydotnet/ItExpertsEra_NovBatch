using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItExpertsEra_NovBatch
{
    public interface ITestInterface
    {
        // definition
        public int Sum(int a, int b);

        public void TestMethod();

        public void GoodMethod();
        public void GoodMethod2();


    }

    public interface ITestInterface2
    {
        // definition
        public int Difference(int a, int b);

        public void TestMethod2();

        public void GoodMethod();
        public void GoodMethod2();

    }

    public class Abc
    {
        public void TestABCMethod()
        {
            Console.WriteLine("I am class method");
        }
    }

    public class Abc2
    {
        public void TestABCMethod2()
        {
            Console.WriteLine("I am class method");
        }
    }


    public class TestClass : Abc, ITestInterface,  ITestInterface2
    {
        public int Difference(int a, int b)
        {
            return a - b;
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public void TestMethod()
        {
            Console.WriteLine("I am test method");
        }

        public void TestMethod2()
        {
            Console.WriteLine("I am test method 2");
        }

        public void GoodMethod()
        {
            Console.WriteLine("I am a Good Method");
        }

        void ITestInterface.GoodMethod2()
        {
            Console.WriteLine("I am first interface good method 2");
        }

        void ITestInterface2.GoodMethod2()
        {
            Console.WriteLine("I am second interface good method 2");
        }

        public void ChildMethod()
        {
            Console.WriteLine("Child Method");
        }
    }
}
