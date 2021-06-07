using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Practice1
{
    class Linq2
    {
        static void Main(string[] args)
        {

            //Data source
            List<string> l = new List<string>() {"veerababu","rallabandi"};

            //Linq query using Query syntax
            var val = from i in l where i.Length > 5 select i;

            //Execution
            foreach(var i in val)
            {
                Console.WriteLine(i);
            }



            //LInq query using Method syntax

            var val1 = l.Where(i => i.Length > 5).ToList();
            
            foreach(var i in val1)
            {
                Console.WriteLine(i);
            }


            //LINQ query using mixed syntax

            List<int> ll = new List<int>() { 1, 2, 3, 4, 5, 6 };
            var val2 = (from i in ll where i > 5 select i).Sum();
            Console.WriteLine(val2);
        }

    }
}
