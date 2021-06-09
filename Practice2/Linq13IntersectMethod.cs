using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice2
{
    class Linq13IntersectMethod
    {
        static void Main(string[] args)
        {
            List<int> l1 = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> l2 = new List<int>() { 1, 2, 34, 5, 6, 7 };

            //Method syntax  -Intersec--common element from both data sources.
            var res1 = l1.Intersect(l2).ToList();
            foreach(var i in res1)
            {
                Console.WriteLine(i);
            }

            //Query syntax
            var res2 = (from ele in l1 select ele).Intersect(l2).ToList();
            foreach(var i in res2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
