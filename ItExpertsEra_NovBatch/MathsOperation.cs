using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItExpertsEra_NovBatch
{
    public class MathsOperation
    {
        //int = datatype
        // var1 = variable name, its depend on developer.
        // = -> assignment right to left.
        // value = this is the value that we want to store or assign in the variable. 
        int var1 = 10;


        // integer : 1, 2, 3, 10, 20
        public int Sum(int num1, int num2)
        {
            int result = num1 + num2;

            return result;
        }

        public int Sum(int[] arrayInt) // {2, 4}, {4, 8} = 18 answer
        {
            int result = 0;

            foreach (int value in arrayInt) // 5, 10, 15, 10, 25
            {
                result = result + value; // 5, 15, 30, 40, 65
            }

            return result;
        }

        public string[] GetAllStrings(string var1, string var2, string var3)
        {
            string[] result = new string[3]; // [] = big bracket, {} = curly bracket, () = bracket, small bracket

            result[0] = var1;
            result[1] = var2;
            result[2] = var3;

            return result;
        }
    }
}
