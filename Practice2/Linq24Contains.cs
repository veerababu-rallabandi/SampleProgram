using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice2
{
    class Linq24Contains
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>() { 32, 22, 34, 36, 71, 25 };

            //using Method syntax
            var res1 = l.Contains(22);
            Console.WriteLine(res1);

            //Using Query syntax
            var res2 = (from i in l select i).Contains(22);
            Console.WriteLine(res2);

            //
            string[] s = { "veerababu", "madhu", "mahesh", "sampath" };

            //It is belongs to System.Collections.Generic
            bool res3 = s.Contains("madhu");
            Console.WriteLine(res3);

            //It is belongs to System.Linq
            var res5 = s.AsEnumerable().Contains("veerabau");
            Console.WriteLine(res5);

            var res4 = (from i in s select i).Contains("mahesh");
            Console.WriteLine(res4);

            //using custom type

            college c1 = new college() { id = 12, branch = "MCA", studentname = "veeru", lastname = "rallabandi" };
            
            var res6 = college.getdatails().Contains(c1);
            Console.WriteLine(res6);

            var res7 = (from i in college.getdatails() select i).Contains(c1);
            Console.WriteLine(res7);


            //using Method syntax

            List<college> ll = new List<college>();

            //only checks reference not values
            var res8 = ll.Contains(new college() { id = 19, branch = "MCA", studentname = "veeru", lastname = "rallabandi" });
            Console.WriteLine(res8);


           



        }
    }
}
