using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice1
{
    class Linq1
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 22, 45, 34, 67, 32, 98, 32, 12 };

            var val = from i in a where i > 20 orderby i ascending select i;

            foreach(int i in val)
            {
                Console.WriteLine(i);
            }

            string[] s = { "veerababu", "madhu", "mahesh", "sampath" };

            var res = from i in s where i.Length > 5 select i;

            foreach(string i in res)
            {
                Console.WriteLine(i);
            }
            
           

        }
    }
}
