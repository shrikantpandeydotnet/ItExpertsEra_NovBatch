using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItExpertsEra_NovBatch
{
    public class GenericCollectionExample
    {
        public void ListExample()
        {
            // Define. 

            List<int> lstInteger = new List<int>();

            // insert

            lstInteger.Add(1);
            lstInteger.Add(21);
            lstInteger.Add(3);
            lstInteger.Add(123);
            lstInteger.Add(123);

            // Read 

            int value1 = lstInteger[0];
            int value2 = lstInteger[1];
            int value3 = lstInteger[2];
            int value4 = lstInteger[3];
            int value5 = lstInteger[4];

            // Insert

            lstInteger.Insert(1, 50);

            // Update

            lstInteger[3] = 100;

            // Count

            int count = lstInteger.Count();

            // Exist 

            bool isExist = lstInteger.Contains(50);

            // Remove

            lstInteger.Clear();


        }

        public void DictionaryExample()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            // Add

            dict.Add(1, "Tanushree");
            dict.Add(2, "Shrikant");
            dict.Add(3, "Rajni");

            // Read 

            string value1 = dict[1];
            string value2 = dict[2];
            string value3 = dict[3];

            // update

            dict[2] = "Rahul";

            // Read all the keys and print it.
            foreach (int key in dict.Keys)
            {
                Console.WriteLine(key);
            }

            // Read all the keys and print it.
            foreach (string value in dict.Values)
            {
                Console.WriteLine(value);
            }


            // Count 

            int count = dict.Count();

            bool isExist = dict.ContainsKey(1);

            // Remove

            dict.Clear();




        }

        public void GenericStackExample()
        {
            Stack<int> stackInt = new Stack<int>();

            // push

            stackInt.Push(1);
            stackInt.Push(10);
            stackInt.Push(100);
            stackInt.Push(1000);

            // peek 
            int value1 = stackInt.Peek();
            int value2 = stackInt.Peek();

            // pop

            int valuepop1 = stackInt.Pop();
            int valuepop2 = stackInt.Pop();

            // clear

            stackInt.Clear();
        }

        public void GenericQueueExample() // FIFO
        {

            Queue<string> queuestring = new Queue<string>();

            // enqueue.

            queuestring.Enqueue("hello");
            queuestring.Enqueue("hello2");
            queuestring.Enqueue("hello3");
            queuestring.Enqueue("hello4");

            // peek 

            string value1 = queuestring.Peek();
            string value2 = queuestring.Peek();
            string value3 = queuestring.Peek();
            string value4 = queuestring.Peek();

            // dequeue 

            string valuedequeue1 = queuestring.Dequeue();
            string valuedequeue2 = queuestring.Dequeue();
            string valuedequeue3 = queuestring.Dequeue();
            string valuedequeue4 = queuestring.Dequeue();


            // count
             
            int count = queuestring.Count;

            // clear

            queuestring.Clear();
        }
    }
}
