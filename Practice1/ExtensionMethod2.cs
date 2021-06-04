using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    static class ExtensionMethod2
    {
        
        public static  void Demo3(this ExtensionMethod1 p,string s)
        {
            Console.WriteLine("I am Demo3 method in ExtensionMethod2 class "+s);

        }
        public static void Demo2(this ExtensionMethod1 p)
        {
            Console.WriteLine("I am Demo2 method in ExtendsionMethod2 class");
        }
        public static string prime(this Int32  x)
        {
            int c = 2;
            for(int i = 2; i <=(int)Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                {
                    c += 1;
                }
            }
            if (c == 2)
            {
                return $"{x} is prime number";
            }
            else
            {
                return $"{x} is not prime number";
            }
            
        }
        public static string reverse(this string p)
        {

            //int l = p.Length - 1;

            //for (int i = l; i >= 0; i--)
            //{
            //    s += p[i];
            //}

            string s = "";
            
            foreach (char i in p)
            {
                 s = i + s;
            }
            return s;
        }
        public static void show2(this structure p)
        {
            Console.WriteLine(p);
            Console.WriteLine("I am extension method in structure");
        }

        public static void ForEach<T>(this IEnumerable<T> l, Action<T> action)
        {
            foreach(T i in l)
            {
                action(i);
            }
        }


    }
}
