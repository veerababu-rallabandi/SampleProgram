using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice2
{
    class Linq17OrderByDescending
    {
        public static object OrderByDescedning { get; private set; }

        static void Main(string[] args)
        {
            List<int> l1 = new List<int>() { 1, 2, 3, 5, 4, 6, 5 };
            List<int> l2 = new List<int>() { 3, 4, 5, 6, 9, 10 };

            //Method syntax
            var res1 = l1.OrderByDescending(n => n);

            //query syntax
            var res2 = (from i in l1 orderby i descending select i).ToList();

            foreach(int ele in res1)
            {
                Console.WriteLine(ele);
            }

            //complex type

            //Method syntax
            var res3 = college.getdatails().OrderByDescending(num =>num.id).ToList();
            foreach(var i in res3)
            {
                Console.WriteLine(i.studentname);
            }

            //query syntax
            var res4 = (from student in college.getdatails().OrderByDescending(n => n.id) select student).ToList(); 
            foreach(var i in res4)
            {
                Console.WriteLine(i.id);
            }

            //filter and method syntax
            var res5 = college.getdatails().Where(n => n.id > 50).OrderByDescending(n => n.studentname).ToList();

            //query syntax
            var res6 = (from std in college.getdatails() where std.studentname.Length > 5 orderby std.id descending select std).ToList();
            foreach(var i in res6)
            {
                Console.WriteLine(i.studentname+" is in "+i.branch);
            }
        }
    }
}
