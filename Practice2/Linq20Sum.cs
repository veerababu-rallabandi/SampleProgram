using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice2
{
    class Linq20Sum
    {
        static void Main(string[] args)
        {
            List<int> l1 = new List<int>() { 1, 2, 3, 5, 4, 6, 5 };
            List<int> l2 = new List<int>() { 3, 4, 5, 6, 9, 10 };

            //Method syntax
            int value = l2.Sum();

            //using Query syntax
            int value1 = (from num in l2 select num).Sum();
            Console.WriteLine(value+" and  "+value1);

            //Method syntax & filter
            int value2 = l1.Where(n => n > 2).Sum();
            Console.WriteLine(value2);

            //Query syntax & filter
            int value3 = (from n in l2 where n>5 select n).Sum();
            Console.WriteLine(value3);

            //Method syntax with predicate

            int value4 = l1.Sum(n => {
                if (n > 5)
                    return n;
                else
                    return 0;
            });

            Console.WriteLine("Method syntax with predicate value is"+value4);

            //custom type
            //Method syntax with custom

            int value5 = college.getdatails().Sum(n => n.id);
            Console.WriteLine(value5);

            //Query syntax with custom type
            int value6 = (from num in college.getdatails() select num).Sum(e => e.id);
            Console.WriteLine(value6);

            //using Method syntax
            var value7 = college.getdatails().Where(n => n.id > 50).Sum(n => n.id);
            Console.WriteLine(value7);

            //query syntax with where 
            var value8 = (from num in college.getdatails() where num.branch=="MECs" select num).Sum(n => n.id);
            Console.WriteLine(value8);

        }
    }
}
