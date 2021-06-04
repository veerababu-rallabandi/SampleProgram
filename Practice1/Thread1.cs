using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Practice1
{
    class Thread1
    {

        static void Demo1()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i);
                if (i == 25)
                {
                    Console.WriteLine("Main thread is sleep");
                    Thread.Sleep(6000);//6 seconds sleep
                    Console.WriteLine("main thread woke up");
                }
            }

        }
        static void Demo2()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {

            //This class has only single Thread.
            Thread t = Thread.CurrentThread;
            t.Name = "My Thread";
            Console.WriteLine("current thread is"+Thread.CurrentThread.Name);
            Demo1();
            Demo2();

        }
    }
}
