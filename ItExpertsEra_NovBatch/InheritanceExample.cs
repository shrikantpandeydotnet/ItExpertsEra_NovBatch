using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItExpertsEra_NovBatch
{
    public class InheritanceExample
    {
      
    }

    public class Parent
    {
        public void ParentMethod()
        {
            Console.WriteLine(" I am parent method");
        }
    }

    public class Child : Parent
    {
        public void ChildMethod()
        {
            Console.WriteLine(" I am child class method");
        }
    }

    public class GrandChild : Child
    {
        public void GrandChildMethod()
        {
            Console.WriteLine("I am GrandChild Method");
        }
    }


    public class Child2 : Parent
    {

        public void Child2Method()
        {
            Console.WriteLine("This is child 2 method");
        }
    }
    

    public class GrandChld2: Child2
    {
        public void GrandChildMethod2()
        {
            Console.WriteLine("I am Grand Child 2 mehtod");
        }
    }

    public class GrandChld3 : Child2
    {
        public void GrandChildMethod3()
        {
            Console.WriteLine("I am Grand Child 2 mehtod");
        }
    }
}
