using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Practice1
{
    class Thread2
    {
         static void Demo1()
         {
             for (int i = 0; i < 50; i++)
             {
                Console.WriteLine("Demo1:"+i);
             }
            Console.WriteLine("Demo1 thread is exiting");

         }
         static void Demo2()
         {
            for (int i = 0; i < 50; i++)
            {
                    Console.WriteLine("Demo2:"+i);
                if (i==25)
                {
                    Console.WriteLine("Thread sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("Thread woke up");
                }

            }
            Console.WriteLine("Demo2 thread is existing");
         }
           
         static void Demo3()
         {
             for (int i = 0; i < 50; i++)
             {
                Console.WriteLine("Demo3:"+i);
             }
            Console.WriteLine("Demo3 thread is exiting");
         }
         static void Main(string[] args)
         {
              //This class has 4 Threads, one is main thread,remaining below
            Thread t = new Thread(Demo1);
            Thread t1 = new Thread(Demo2);
            Thread t2 = new Thread(Demo3);
            t.Start();
            t1.Start();
            t2.Start();
            Console.WriteLine("Main thread is exiting");
             
                
         }
    }
}
