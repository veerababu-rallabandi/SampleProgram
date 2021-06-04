using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Practice1
{
    class Thread3
    {
        static void Demo()
        {
            for(int i = 0; i < 50; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Demo1(object m)
        {
            int n = Convert.ToInt32(m);
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            //constructor

            //way1

            //ThreadStart obj = new ThreadStart(Demo);
            //Thread t = new Thread(obj);
            //t.Start();

            //Way2

            //ThreadStart obj = Demo;
            //Thread t = new Thread(obj);
            //t.Start();


            //way 3(by using Aynomous method)
            //ThreadStart obj = delegate () { Demo(); };
            //Thread t = new Thread(obj);
            //t.Start();


            //way 4 (by using lambda expression)

            //ThreadStart obj = () => Demo();
            //Thread t = new Thread(obj);
            //t.Start();

            //parameterized delegate

            ParameterizedThreadStart obj = new ParameterizedThreadStart(Demo1);
            Thread t = new Thread(obj);
            t.Start(45);

           

            

        }
    }
}
