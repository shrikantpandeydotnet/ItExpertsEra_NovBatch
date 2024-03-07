using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItExpertsEra_NovBatch
{
    public partial class PartialClassExample
    {
        public void TestMethod()
        {
            Console.WriteLine("i am first partial class. ");
        }
    }

    public partial class A
    {
        public void Method1()
        {

        }
    }

    public partial class A
    {
        public void Method1(int a)
        {

        }

    }
}
