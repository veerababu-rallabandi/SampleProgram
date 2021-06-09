using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice2
{
    class Linq21Average
    {
        static void Main(string[] args)
        {
            //This program about Average and Count

            List<int> l1 = new List<int>() { 1, 2, 3, 5, 4, 6, 5 };
            List<int> l2 = new List<int>() { 3, 4, 5, 6, 9, 10 };

            //Method syntax
            var val1 = l1.Average();
            //query syntax
            var val2 = (from num in l2 select num).Average();
            Console.WriteLine(val1+" and "+val2);

            //Using Method syntax count

            int n1 = l1.Count();
            int n2 = (from i in l2 select i).Count();
            Console.WriteLine(n1+" "+n2);


            int n3 = l1.Where(n => n > 4).Count();
            int n4 = (from i in l2 where i > 3 select i).Count();
            Console.WriteLine(n3+" "+n4);

            //using Method 
            int n5 = college.getdatails().Count();
            //using Query syntax
            int n6 = (from num in l2 select num).Count();
            Console.WriteLine(n5+" "+n6);


            //Aggregate Method

            string[] str = { "veerababu", "madhu", "mahesh", "sampath", "avinash" };

            string result = str.Aggregate((s1, s2) =>s1+" , "+s2);
            Console.WriteLine(result);

            int val = l1.Aggregate((val1, val2) => val1 + val2);
            Console.WriteLine(val);

            List<int> l3 = new List<int>() { 1, 2, 3 };
            //using seed value is 2-->first 2*1=2-->2*2=4-->4*3=12
            int val3 = l3.Aggregate(2, (val1, val2) => val1 * val2);
            Console.WriteLine(val3);

            int val4 = college.getdatails().Aggregate<college, int>(0, (num, clg) => num = clg.id);
            Console.WriteLine(val4);
        }

    }
}
