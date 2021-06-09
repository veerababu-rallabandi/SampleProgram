using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Practice2
{
    class Linq12ExceptMethod
    {
        static void Main(string[] args)
        {
            List<int> l1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            List<int> l2 = new List<int>() { 1, 8, 9, 10, 3 };

            //Method syntax
            var res1 = l1.Except(l2).ToList();
            Console.WriteLine("only l1 elements print ,those are not in l2");
            foreach (int i in res1)
            {
                Console.WriteLine(i);
            }

            //Query Syntax
            var res2 = (from ele in l1 select ele).Except(l2).ToArray();
            Console.WriteLine("elements");
            foreach(var i in res2)
            {
                Console.WriteLine(i);
            }

            List<string> names = new List<string>(){ "veeru", "madhu", "mahesh" };
            List<string> names1 =new List<string>() { "sampath", "avinash" };

            //Method syntax
            //case-sensentive purpose
            var res3 = names.Except(names1, StringComparer.OrdinalIgnoreCase).ToList();
            foreach(var i in res3)
            {
                Console.WriteLine(i);
            }
            //query syntax
            var res4 = (from name in names select name).Except(names1, StringComparer.OrdinalIgnoreCase).ToList();
            foreach(var i in res4)
            {
                Console.WriteLine(i);
            }

        }
    }
}
