using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring an ArrayList with undefined amount of objects
            ArrayList myArrayList = new ArrayList();
            // Declaring an ArrayList with defined amount of objects
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);
            // delete element with specific value from the arrayList. If multiple of the same value
            //the first entry will be removed
            myArrayList.Remove(13);
            // delete element at specific posiion
            myArrayList.RemoveAt(0); // should remove the first entry
            // Count shows how many entries in arrayList
            Console.WriteLine(myArrayList.Count);
            double sum = 0;
            foreach(object obj in myArrayList)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if(obj is double)
                {
                    sum += (double)obj;
                }
                else if( obj is string)
                {
                    Console.WriteLine(obj);
                }

            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
