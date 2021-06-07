using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace Practice1
{
    class Thread6
    {
        static void inc1()
        {
            long count1 = 0;
            for(int i = 0; i <= 100000000; i++)
            {
                count1 += 1;
            }
            Console.WriteLine("inc1 count is "+count1);
        }
        static void inc2()
        {
            long count2 = 0;
            for (int i = 0; i <= 100000000; i++)
            {
                count2 += 1;
            }
            Console.WriteLine("inc2 count:"+count2);
        }

        static void Main(string[] args)
        {

            /*This program compare Multi thread and single thread model perfomance
             * single Thread time taken is 372(for eg)ms
             * Multi Thread time taken is 31ms
             */

            Thread t1 = new Thread(inc1);
            Thread t2 = new Thread(inc2);
            Stopwatch s1 = new Stopwatch();
            Stopwatch s2 = new Stopwatch();

            //single Thread Model
            s1.Start();
            inc1();
            inc2();
            s1.Stop();

            //Multi Thread Model
            s2.Start();
            t1.Start();
            t2.Start();
            s2.Stop();

            t1.Join();
            t2.Join();
            Console.WriteLine("Time taken to complete the work in single model : "+s1.ElapsedMilliseconds);
            Console.WriteLine("Time taken to complete the work in Multi thread model : "+s2.ElapsedMilliseconds);
        }
    }
}
