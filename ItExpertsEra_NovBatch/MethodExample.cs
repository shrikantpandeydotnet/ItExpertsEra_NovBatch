using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItExpertsEra_NovBatch
{
    public class MethodExample
    {

        // Default method with void return type. 

        public void TestMethod()
        {
            Console.WriteLine("I am a test method and i am a default method");
        }

        // methods with parameters

        public void Sum(int num1, int num2)
        {
            int result = num1 + num2;

            Console.WriteLine(result);
        }

        public int Sum2(int num1, int num2)
        {
            int result = num1 + num2;

            return result;
        }

        public string Add(string val1, string val2)
        {
            string result = val1 + val2; // concatenate " Tanushree" + "Aggarwal" = TanushreeAggarwal

            return result;
        }

        // Method wih Array as Parameter. 

        public int SumArray(int[] arrayValue)
        {
            int result = 0; 

            foreach (int value in arrayValue)
            {
                result += value;
            }

            return result;
        }

        // method with return type as array
    }
}
