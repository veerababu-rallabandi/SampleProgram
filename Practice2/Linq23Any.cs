using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice2
{
    class Linq23Any
    {
        static void Main(string[] args)
        {
            //This program about Any in LINQ

            List<int> l = new List<int>() { 23, 30, 45, 21, 45 };

            //Using Method syntax
            var res1 = l.Any(n=>n>30);//Any one element sastifies condition return true otherwise false.
            Console.WriteLine(res1);

            //using Query syntax
            bool res2 = (from num in l select num).Any(n => n >= 45);
            var res3 = (from num in l select num).Any();
            Console.WriteLine(res2+" "+res3);


            var res4 = college.getdatails().Any(i=>i.id>50);
            Console.WriteLine(res4);

            //query syntax with cumstom type
            var res5 = (from i in college.getdatails() select i).Any(i => i.id > 30);
            Console.WriteLine(res5);

            //using filter with Method syntax
            var res6 = college.getdatails().Where(i => i.branch == "MPC").Any(i => i.studentname == "veerababu");
            Console.WriteLine(res6);

            //using filter with Query syntax
            var res7 = (from i in college.getdatails() where i.branch == "MECs" select i).Any(i => i.lastname.Length > 5);
            Console.WriteLine(res7);

            var res8 = college.getdatails().Where(i =>i.studentname.Any(i => i=='v')).ToList();
            foreach(var i in res8)
            {
                Console.WriteLine(i.studentname);
            }

            var res9 = (from i in college.getdatails() where i.branch.Any(i => i == 'M') select i).ToList();
            foreach(var i in res9)
            {
                Console.WriteLine(i.studentname);
            }





        }
    }
}
