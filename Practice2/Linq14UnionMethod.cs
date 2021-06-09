using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice2
{
    class Linq14UnionMethod
    {
        static void Main(string[] args)
        {
            //This program about union -->combine element from both datasources
            List<int> l1 = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> l2 = new List<int>() { 3, 4, 6, 7, 8 };

            //Method syntax
            var res1 = l1.Union(l2).ToList();
            Console.WriteLine("union --combine elements from both data sources");
            foreach(int i in res1)
            {
                Console.WriteLine(i);
            }

            //Query syntax
            var res2 = (from ele in l1 select ele).Union(l2).ToList();
            foreach(int i in res2)
            {
                Console.WriteLine(i);
            }
            
           
        }
    }
}
