using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItExpertsEra_NovBatch
{
    public class AccessModifier
    {

        // Access Modifier.

        public int varpublicInt = 10;

        private string varprivateString = "test";

        internal bool varinternalBool = false;

        protected int varprotectedInteger = 32;

        public void TestMethod()
        {
            varpublicInt = 24223;

            varprivateString = "test2";

            varinternalBool = true;

            varprotectedInteger = 42;
        }

        public void TestMethod2()
        {
            varpublicInt = 20;
            varprivateString = "sdfsfs";
            varinternalBool = false;
            varprotectedInteger = 34;
        }
    }
}
