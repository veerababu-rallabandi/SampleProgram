using System;
using System.Collections.Generic;
using System.Text;

namespace Practice2
{
    class Practicepurpose4
    {
        static void Main(string[] args)
        {
            foreach(int i in Add<int>(2, 10))
            {
                Console.WriteLine(i);
            }
           
        }
        static IEnumerable<T> Add<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            dynamic res = 1;
            for(int i = 1; i < y; i++)
            {
                res = res + x;
                yield return res;

            } 
        }
        static IEnumerable<object> foreachVeera()
        {
            List<int> l = new List<int>() { 1, 2, 3, 45, 6 };
            foreach(object i  in l)
            {
                yield return i;
            }
        }
    }
}
