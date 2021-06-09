using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice2
{
    class Linq20Max
    {
        static void Main(string[] args)
        {
            //This program about Max in LInq..

            List<int> l1 = new List<int>() { 1, 2, 3, 5, 4, 6, 5 };
            List<int> l2 = new List<int>() { 3, 4, 5, 6, 9, 10 };

            //using Method syntax
            int val1 = l1.Max();
            Console.WriteLine("Maximum value is : "+val1);
            int val2 = l1.Min();
            Console.WriteLine("Minimum value is : "+val2);

            //using query syntax
            int val3 = (from num in l1 select num).Max();
            Console.WriteLine("max value is:"+val3);
            int val4 = (from num in l2 select num).Min();
            Console.WriteLine("min value is :"+val4);


            //using Filter also

            //Method syntax
            int val5 = l1.Where(n => n > 3).Max();
            Console.WriteLine(val5);
            int val6 = l2.Where(n => n > 2).Min();
            Console.WriteLine(val6);

            //Query syntax
            Console.WriteLine((from num in l1 where num>3 select num).Max());
            Console.WriteLine("Max value is"+(from num in l2 where num>2 select num).Min());


            //Linq Max & MIn with predicate
            //using Method syntax
            int val7 = l1.Max(n => {
                if (n > 3)
                    return n;
                else
                    return 0;
            });

            int val8 = college.getdatails().Where(n => n.branch=="MECs").Max(n=>n.id);
            int val9 = (from num in college.getdatails() where num.branch == "MPC" select num).Min(n=>n.id);
            Console.WriteLine(val8+" and "+val9);


        }
    }
}
