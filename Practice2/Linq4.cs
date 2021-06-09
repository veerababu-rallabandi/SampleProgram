using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice2
{
    class Linq4
    {
        static void Main(string[] args)
        {

            //Extension method
            List<int> l = new List<int>() { 1, 2, 3, 4, 5,6,9 };
            IEnumerable<int> s = Enumerable.Where(l, n => n%3==0);
            foreach(int i in s)
            {
                Console.WriteLine(i);
            }
        }
    }
}
