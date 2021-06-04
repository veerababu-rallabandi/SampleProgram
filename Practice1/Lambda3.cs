using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; //using namespace to fetch select

namespace Practice1
{
    class Lambda3
    {
       
        static void Main(string[] args)
        {
            List<int> l = new List<int>() {3,6,7,4,8,2,3 };

            //using Lambda expression to calculate square of each number
            var result=l.Select(x => x * x);

            //using Lambda expression to find all numbers divisible by 2
            var final=l.FindAll(x => x % 2 == 0);
            foreach(var i in final)
            {
                Console.WriteLine(i);
            }

           // l.ForEach(x=> x + 5);

            

           
        }
    }
}
