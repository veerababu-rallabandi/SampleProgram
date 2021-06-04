using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Practice1
{
    class Thread5
    {
        /*By using lock(this) --only allow one thread, not allow multiple thread. By using
         * lock to overcome multiple threads executed at a time.
         * Multiple thread wait for resouces until one thread completed..
         */
        //public void dis()
        //{
        //    lock (this)
        //    {
        //        Console.Write("csharp is");
        //        Thread.Sleep(5000);
        //        Console.WriteLine(" a language");
        //    }

        //}

        //Thread Priority 

        static long c1, c2; //by default is 0
        public static void inc1()
        {
            while (true)
            {
                c1 += 1;
            }
        }
        public static void inc2()
        {
            while (true)
            {
                c2 += 1;
            }

        }
        static void Main(string[] args)
        {
            //This class about Thread locking
          //  Thread5 t = new Thread5();
            //  t.dis();
            //t.dis();
            //Thread t1 = new Thread(t.dis);
            //Thread t2 = new Thread(t.dis);
            //Thread t3 = new Thread(t.dis);
            //t1.Start();
            //t2.Start();
            //t3.Start();


            //Thread priority

            Thread t1 = new Thread(inc1);
            Thread t2 = new Thread(inc2);

            t1.Priority = ThreadPriority.Lowest;   //default thread priority is NOrmal..
            t2.Priority = ThreadPriority.Highest; 

            t1.Start();
            t2.Start();

            Console.WriteLine("Main Thread is going to sleep" );
            Thread.Sleep(10000);
            Console.WriteLine("Main Thread is woke up");
            try
            {
                t1.Abort();
                t2.Abort();//It means terminate
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          

            t1.Join();
            t2.Join();

            Console.WriteLine($"count for c1 is {c1} \n count for c2 is {c2}");
            //c2 is highest value print greater than c1 value
        }
    }
}
