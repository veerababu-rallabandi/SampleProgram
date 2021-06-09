using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice2
{
    class Linq9Oftype
    {
        static void Main(string[] args)
        {
            //This program about oftype operator in LINQ

            List<object> l = new List<object>() { "veerababu", 34, 54, 54.0f, "srinu", "madhu", 76 };

            //Using Method syntax
            List<int> res1 = l.OfType<int>().ToList();
            foreach(int i in res1)
            {
                Console.WriteLine(i);
            }

            //Query syntax

            var res2 = (from i in l where i is Int32 select i).ToList(); //May be using string class
            //to print string values
            foreach(string i in res2)
            {
                Console.WriteLine(i);
            }



            //using ofType and is -->To retrieve numbers and names

            //Method syntax
            var res3 = l.OfType<int>().Where(x => x > 30).ToList();
            foreach(int i in res3)
            {
                //to print integer values
                Console.WriteLine(i);
            }

            //Query syntax
            var res4 = (from i in l where i is string && i.ToString().Length > 3 select i).ToList();
            Console.WriteLine("To print string values");
            foreach(var i in res4)
            {
                Console.WriteLine(i);
            }
        }
    }
}
