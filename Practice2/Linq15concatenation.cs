using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice2
{
    class Linq15concatenation
    {
        static void Main(string[] args)
        {
            //This program about concenation method

            //Using concat method--doesn't remove duplicate elements
            List<int> l1 = new List<int>() { 1, 2, 3, 4, 4 };
            List<int> l2 = new List<int>() { 1, 2, 7, 8, 3, 5 };

            var res1 = l1.Concat(l2);
            foreach(int i in res1)
            {
                Console.WriteLine(i);
            }

            //using union operator--remove duplicate element
            Console.WriteLine("union elements:\n");
            var res2 = l1.Union(l2);
            foreach(int i in res2)
            {
                Console.WriteLine(i);
            }

            //any one of the list is null--arises an exception ,for suppose l1=null;
         //   List<int> l3 = null;
          //  var res3 = l1.Union(l3);
        }
    }
}
