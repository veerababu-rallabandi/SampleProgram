using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Practice1
{
    class Thread4
    {
        static void Demo1()
        {
            for(int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Demo1: "+i);
                //if (i == 25)
                //{
                //    Thread.Sleep(6000);
                //}
            }
            Console.WriteLine("Demo1 exiting");
        }
        static void Demo2()
        {
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Demo2 :" + i);
            }
            Console.WriteLine("Demo2 exiting");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread started");
            Thread t1 = new Thread(Demo1);//automatically instance of ThreadStart delegate pass
            Thread t2 = new Thread(Demo2);
            t1.Start();
            t2.Start();

            //by using join() method execute all child thread until not execute main thread
            t1.Join();
            t1.Join(3000);//Main thread only wait for 3000ms
            Console.WriteLine("Main thread is Exiting");

        }
    }
}
