using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice1
{
    class Thread7asynchronous
    {
        
        public static async void Test1()
        {
            int val =await Test2();
            Console.WriteLine("output of Test2: "+val);
        }
        public static Task<int> Test2()
        {
            //Thread.Sleep(5000);//wait for 5000ms
            //return 1;

            
            return Task.Run(() =>
            {
                Thread.Sleep(1000);
                return 1;
            });
        }
        static void Main(string[] args)
        {
            /*This program about async and await keywords..
             * Before using async and await keywords, wait for some time --5000ms
             * so, after using async and await keywords , problem is solve. using below
             */

            Console.WriteLine("program starting");
            Test1();
            //  Method1();
            for (int i = 0; i < 1500; i++)
            {
                Console.WriteLine("forloop : " + i);
            }
        }

        //public static async void Method1()
        //{
        //    await Task.Run(new Action(longTask));
        //    Console.WriteLine("Waiting...."); //wait until the longTask finishes
        //}
        //public static void longTask()
        //{
        //    Thread.Sleep(5000);
        //}



    }
}
