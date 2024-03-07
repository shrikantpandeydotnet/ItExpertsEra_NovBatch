using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItExpertsEra_NovBatch
{
    public class Cars
    {

        string modelNo;
        // old way of creating property 

        public string Model
        {
            get
            {
                return modelNo; 
            }
            set
            {
                modelNo = value;
            }
        }

        public string Name 
        { 
            get; 
            set; 
        }

        public string Color { get; set; }

        public int NoOfSeats { get; set; }

        public bool IsHatchBack { get; set; }

        // Read only property. 


        public int MyProperty { get; private set; }

        public void TestMethod()
        {
            MyProperty = 100;
        }
    }
}
