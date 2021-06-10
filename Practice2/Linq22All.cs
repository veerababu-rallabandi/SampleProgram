using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice2
{
    class Linq22All
    {
        static void Main(string[] args)
        {

            //This program about All in Linq

            List<int> l = new List<int>() { 1, 2, 3, 44, 32, 45, 23 };
            var res = l.All(n=>n>20);
            Console.WriteLine(res);//return false , all elements not sastify condition
            List<int> l1 = new List<int>() { 1, 2, 3, 44, 32, 45, 23 };
            Console.WriteLine(l1.All(i=>i>0));//true

            string[] s = { "veerababu", "mahesh", "madhu" };
            Console.WriteLine(s.All(name=>name.Length>5));

            //using Method syntax with complex type

            var res1 = college.getdatails().All(n => n.studentname.Length > 6);
            Console.WriteLine(res1);

            //using Query syntax with complex type
            var res2 = (from i in college.getdatails() select i).All(i => i.id > 30);//above id is 30(all students)
            Console.WriteLine(res2);

            //filter with Method syntax
            var res3 = college.getdatails().Where(i => i.branch=="MECs").All(i => i.lastname.Length > 5);
            Console.WriteLine(res3);

            //Query syntax
            var res4 = (from i in college.getdatails() where i.branch != "MECs" select i).All(i => i.studentname.Length > 5);
            Console.WriteLine(res4);



        }
    }
}
