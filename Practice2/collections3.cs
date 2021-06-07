using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Practice1
{
    class collections3
    {
        static void Main(string[] args)
        {
            //Queue in Generic mode(FIFO)


            Queue<string> q = new Queue<string>();
            q.Enqueue("veera");
            q.Enqueue("babu");
            q.Enqueue("rallabandi");
            Console.WriteLine(q.Count);
            Console.WriteLine(q.Peek());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Contains("veera"));
            string[] ss = q.ToArray();
            foreach(string i in ss)
            {
                Console.WriteLine(i);
            }
            string[] s1 = new string[10];
            q.CopyTo(s1, 2);

            //0,1 in s1 array empty bcoz starts with copy from 2 index
            foreach(string i in s1)
            {
                Console.WriteLine(i);
            }


            //Queue in Non-generic mode.

            Console.WriteLine("Non-generic queue");
            Queue qq = new Queue();
            qq.Enqueue(10);
            qq.Enqueue("veerababu");
            qq.Enqueue(1.2f);
            qq.Enqueue(23.3m);

            Console.WriteLine(qq.Peek());
            Console.WriteLine(qq.Count);
            object[] oo=qq.ToArray();

            foreach(object i in oo)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(qq.Dequeue());
            Console.WriteLine(qq.Peek());
        }
    }
}
