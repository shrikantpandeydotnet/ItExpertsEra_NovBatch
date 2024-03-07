using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItExpertsEra_NovBatch
{
    public class ExceptionHandlingExample
    {
        public void TestMethod(int var1)
        {
            try
            {
                int i = 10;
                int j = 0;

                int result = i / j;

                Console.WriteLine(result);

                try
                {
                    int a = 10;
                    int b = 0; 

                    int result2 = a / b;

                    Console.WriteLine(result2);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message.ToString());
                }


                if (var1 < 10)
                {
                    throw new ArgumentException("There is wrong argument passed in this method.");
                }

                Console.WriteLine(result);

            }
            catch(DivideByZeroException ex) 
            {
                Console.WriteLine(ex.Message);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Please send correct Argument in the method parameter");
            }
            catch (Exception ex)
            {

                Console.WriteLine("An exception occured. Please contact system admin " + ex.Message);
                Console.WriteLine("Stack Trace" + ex.StackTrace);

            }
            finally
            {
                Console.WriteLine(" I am finally block code and i will execute always");
            }

        }
    }
}
