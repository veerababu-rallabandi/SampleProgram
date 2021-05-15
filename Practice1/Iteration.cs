using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class Iteration
    {
        public void iter1(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("hello");
            }
        }
        public void iter2(int n)
        {
            int i = 0;
            while (i < n)
            {
                Console.WriteLine("I am while");
                i += 1;
            }
        }
        public void iter3(int n)
        {
            int i = 0;
            do
            {
                Console.WriteLine("I am do-while");
                i += 1;
            } while (i < n);
        }
        public void iter4()
        {
            int[] a = new int[3] { 1, 2, 3 };
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }

    }
}
