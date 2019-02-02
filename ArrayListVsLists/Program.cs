using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListVsLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //immutable - limited to one type has to have a defined limit
            int[] scores = new int[] { 99, 96, 87, 76 };

            List<int> list = new List<int> { 1, 2, 3, 4 };
            list.Add(0);// adds to end of list
            list.Add(32);
            list.Sort(); //sorts by comparing the entries
            list.RemoveRange(2, 2);//first number is index and second is the amount to remove


            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(list.Contains(4));//looks for an entry that has that value and gives a true/false

            int index = list.FindIndex(x => x == 4); // finds where the value is at in the list
            Console.WriteLine(list[index]);
            list.RemoveAt(index); // removes at that index
            list.ForEach(i => Console.WriteLine(i));

            // can contain more then 1 type very hard to keep code clean
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("two");
            arrayList.Add("3");
            arrayList.Add(new Number { n = 4 });

            foreach(object o in arrayList)
            {
                Console.WriteLine(o);
            }

            Console.ReadLine();
        }
    }

    class Number
    {
        public int n { get; set; }
        public override string ToString()
        {
            return n.ToString();
        }
    }
}
