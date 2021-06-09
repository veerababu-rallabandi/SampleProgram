using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Practice2
{
    class Linq19Reverse
    {
        static void Main(string[] args)
        {
            //This program about reverse method in linq.

            List<int> l1 = new List<int>() { 1, 2, 3, 5, 4, 6, 5 };
            List<int> l2 = new List<int>() { 3, 4, 5, 6, 9, 10 };

            //using System.Linq reverse
            IEnumerable<int> a = l1.Reverse<int>();
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }

            //System.Collections.Generic reverse
            l2.Reverse();
            foreach(int i in l2)
            {
                Console.WriteLine(i);
            }


            //query syntax-mixed synatax
            var res1 = (from ele in l1 select ele).Reverse();
            foreach(var i in res1)
            {
                Console.WriteLine(i);
            }


            //AsEnumerable is used to convert IEnumberable type.
            //AsQueryable is used to convert IQueryable type.
            IEnumerable<int> res2 = l1.AsEnumerable().Reverse();
            IQueryable<int> res3 = l2.AsQueryable().Reverse();

            foreach(var i in res2)
            {
                Console.WriteLine(i);
            }

        }
    }
}
