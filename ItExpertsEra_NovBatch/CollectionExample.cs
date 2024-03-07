using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItExpertsEra_NovBatch
{
    public class CollectionExample
    {

        public void ArrayListExample()
        {
            // ArrayList

            // Define. 
            ArrayList objArrayList = new ArrayList();

            // Insert 
            objArrayList.Add(1);
            objArrayList.Add("Shrikant");
            objArrayList.Add(false);
            objArrayList.Add(DateTime.Now);

            // Read value from ArrayList

            int value1 = Convert.ToInt32(objArrayList[0]);
            string value2 = Convert.ToString(objArrayList[1]);
            bool value3 = Convert.ToBoolean(objArrayList[2]);
            DateTime value4 = Convert.ToDateTime(objArrayList[3]);

            // update arraylist

            objArrayList[2] = "Tanshree";

            // Insert in between arraylist

            objArrayList.Insert(1, "Shivani");

            // Remove from ArrayList

            objArrayList.Remove("Tanushree");

            // Remove using index
            objArrayList.RemoveAt(1);

            // count

            int count = objArrayList.Count;

            // value exist or not

            bool isValueExis = objArrayList.Contains("Shrikant");

            // clear arraylist

            objArrayList.Clear();
        }

        public void HashTableExample()
        {
            // Define 

            Hashtable objHashTable = new Hashtable();

            // Insert

            objHashTable.Add(1, "Tanushree");
            objHashTable.Add("Second", 10.20);
            objHashTable.Add(3, false);
            objHashTable.Add(4, DateTime.Now);

            // Read the value. 

            string value1 = Convert.ToString(objHashTable[1]);
            decimal value2 = Convert.ToDecimal(objHashTable["Second"]);
            bool value3 = Convert.ToBoolean(objHashTable[3]);
            DateTime value4 = Convert.ToDateTime(objHashTable[4]);

            // Update

            objHashTable[3] = "Shrikant";

            // Remove
            objHashTable.Remove("Second");

            // Count

            int count = objHashTable.Count;

            // exist

            bool isexist = objHashTable.Contains(6);
            bool isexist2 = objHashTable.ContainsKey(4);
            bool isexist3 = objHashTable.ContainsValue(10.20);

            // Clear all


            objHashTable.Clear();


        }

        public void StackExample() // Last In First Out
        {
            // Define 

            Stack objStack = new Stack();

            // Push
            objStack.Push(1);
            objStack.Push("Shrikant");
            objStack.Push(false);
            objStack.Push(DateTime.Now);

            // Read 

            DateTime valuepeek1 = Convert.ToDateTime(objStack.Peek()); // return last value but don't delete.
            DateTime valuepeek2 = Convert.ToDateTime(objStack.Peek()); // return last value but don't delete.
            DateTime valuepeek3 = Convert.ToDateTime(objStack.Peek()); // return last value but don't delete.
            DateTime valuepeek4 = Convert.ToDateTime(objStack.Peek()); // return last value but don't delete.
            DateTime valuepeek5 = Convert.ToDateTime(objStack.Peek()); // return last value but don't delete.
            DateTime valuepeek6 = Convert.ToDateTime(objStack.Peek()); // return last value but don't delete.
            DateTime valuepeek7 = Convert.ToDateTime(objStack.Peek()); // return last value but don't delete.


            DateTime value1 = Convert.ToDateTime(objStack.Pop()); // read from stack and delete. 
           bool value2 = Convert.ToBoolean(objStack.Pop()); // read from stack and delete. 
           string value3 = Convert.ToString(objStack.Pop()); // read from stack and delete. 
           int value4 = Convert.ToInt32(objStack.Pop()); // read from stack and delete.
                                                         // 
            // count
            int count = objStack.Count;
        }

        public void QueueExample() // First In First Out
        {
            // Define

            Queue objQueue = new Queue();

            // Insert

            objQueue.Enqueue(1);
            objQueue.Enqueue(true);
            objQueue.Enqueue("Tanushree");
            objQueue.Enqueue(DateTime.Now);

            // Get value from Queue

            int valuepeek1 = Convert.ToInt32(objQueue.Peek()); // only returns first value but don't delete. 
           int value1 = Convert.ToInt32(objQueue.Dequeue()); // return first value and delete. 
           bool value2 = Convert.ToBoolean(objQueue.Dequeue()); // return first value and delete. 
           string value3 = Convert.ToString(objQueue.Dequeue()); // return first value and delete. 
           DateTime value4 = Convert.ToDateTime(objQueue.Dequeue()); // return first value and delete. 
        }
    }
}
