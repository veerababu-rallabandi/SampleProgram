using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice2
{
    public class Employee123
    {
        public string name { get; set; }
        public int id { get; set; }
        public static List<Employee123> getdata()
        {
            List<Employee123> l = new List<Employee123>()
            {
                new Employee123(){name="veerababu",id=12},
                new Employee123(){name="srinu",id=14},
                new Employee123(){name="avinash",id=16},
                new Employee123(){name="veerababu",id=15}
            };
            return l;
        }

    }
    class Linq10Setoperators
    {
        public static IEqualityComparer<Employee123> Linq1Distinct1 { get; private set; }

        static void Main(string[] args)
        {
            //This program about setoperators in LINQ

            //1.Distinct
            List<int> l = new List<int>() { 1, 2, 2, 2, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 9 };

            //Using MEthod syntax
            var res1 = l.Distinct();

            foreach(int i in res1)
            {
                Console.WriteLine(i);
            }

            //Using Query syntax
            var res2 = (from i in l select i).Distinct();
            foreach(int i in res2)
            {
                Console.WriteLine(i);
            }

            //using 2nd overloaded method 
            List<string> ll = new List<string>() { "veerababu", "babu", "rallabandi","babu" };

            var res3 = ll.Distinct(StringComparer.OrdinalIgnoreCase);

            foreach(var i in res3)
            {
                Console.WriteLine(i);
            }

            //using Method syntax

            Console.WriteLine("Different names");
            var res4 = (Employee123.getdata().Select(x => x.name)).Distinct().ToList();
            foreach(var i in res4)
            {
                Console.WriteLine(i);
            }

            //query syntax
            Console.WriteLine("using Query syntax");
            var res5 = (from name in Employee123.getdata() select name).Distinct().ToList();
            foreach(var i in res5)
            {
                Console.WriteLine(i.name);
            }



            //There is one problem in below to all elememnts ,distinct not work
            var res6 = Employee123.getdata().Distinct().ToList();
            Console.WriteLine("values:");
            foreach(var i in res6)
            {
                Console.WriteLine(i.name+" "+i.id);
            }


            //By using separate class ,it has override method

            Console.WriteLine("after values");
            //Creating an instance of StudentComparer
            Linq11Distinct1 lq = new Linq11Distinct1();

            var res7 = Employee123.getdata().Distinct(lq).ToList();
            foreach(var i in res7)
            {
                Console.WriteLine(i.name);
            }
            

        }
    }
}
