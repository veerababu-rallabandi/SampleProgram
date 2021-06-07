using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class Decisionmaking
    {
        public void @if(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("a is big");
            }
        }
        public void ifelse(int a, int b)
        {
            if (a < b)
            {
                Console.WriteLine("a is big");
            }
            else
            {
                Console.WriteLine("b is big");
            }
        }
        public void nested(int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("a is large");
                }
                else
                {
                    Console.WriteLine("c is large");
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("b is large");
                }
                else
                {
                    Console.WriteLine("c is large");
                }
            }
        }
        public void ifelse1(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("a is greater than b");
            }
            else if (a == b)
            {
                Console.WriteLine("Both are equal");
            }
            else
            {
                Console.WriteLine("b is greater than a");
            }
        }
        public void ternary(int a, int b, int c)
        {
            int r = a > b ? a > c ? a : c : b > c ? b : c;
            Console.WriteLine(r);
        }
        public void Switch(int a)
        {
            switch (a)
            {
                case 1:
                    Console.WriteLine("It is 1");
                    break;
                case 2:
                    Console.WriteLine("It is 2");
                    break;
                default:
                    Console.WriteLine("It is default");
                    break;

            }
        }

    }
}
