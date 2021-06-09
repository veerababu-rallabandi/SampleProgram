using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice2
{
    class Linq7Where
    {
        static void Main(string[] args)
        {
            //This program about where in LInq

            List<int> l = new List<int>() { 1, 2, 3, 4, 5 };

            //Query syntax, using where
            IEnumerable<int> res1 = from i in l where i > 2 select i;

            foreach (int i in res1)
            {
                Console.WriteLine(i);
            }

            //Method syntax
            IEnumerable<int> res2 = from i in l where i > 3 select i;
            foreach(int i in res2)
            {
                Console.WriteLine(i);
            }


            //
            IEnumerable<int> filter = l.Where(i => chech(i));
            foreach(int i in filter)
            {
                Console.WriteLine(i);
            }

            //By using index

            List<int> ll = new List<int>() { 32, 45, 34, 23, 22, 65, 66 };


            //To print odd values
            //Method syntax

            var res3 = ll.Select((number, index) => new
            {
                Number = number,
                index = index

            }).Where(x => x.Number % 2 != 0).Select(data =>new
            {

                value=data.Number,
                originindex=data.index
            });

            //Query syntax to retrieve odd values

            var res4 = from i in l.Select((num, index) => new
            {
                Number = num,
                ind = index
            })
                       where i.Number % 2 != 0
                       select new
                       {
                           value = i.Number,
                           originindex = i.ind
                       };

            foreach(var i in res4)
            {
                Console.WriteLine(i.value+" "+i.originindex);
            }
        }
        static bool chech(int num)
        {
            if (num > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
