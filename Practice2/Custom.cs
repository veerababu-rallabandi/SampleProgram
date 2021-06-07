using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class Custom
    {
        static void foreachVeera<T>(T l )
        {
            dynamic d = l;

            // IEnumerator s = ((IEnumerable)d).GetEnumerator();

            IEnumerator s = (d as IEnumerable).GetEnumerator();
            while (s.MoveNext())
            {
                Console.WriteLine(s.Current);
            }
        }
        //static void foreachveera<T>(T a)
        //{
        //    dynamic d = a;
        //    foreach(dynamic i in d)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        static void Main(string[] args)
        {
            // string[] s = new string[] { "veerababu", "madhu", "mahesh" };
            List<string> l = new List<string>() { "veerababu", "madhu", "mahesh" };
            //  foreachVeera(l);
            //List<int> ll = new List<int>() { 1, 2, 3 };
            //foreachVeera(ll);
            //  foreachveera<List<object>>(new List<object> { 1, 2, 5 });
            // foreachVeera<List<int>>(new List<int> {4,5,7 });

            foreachVeera<object>(l);

            Stack<int> s = new Stack<int>();
            s.Push(23);
            s.Push(43);
            foreachVeera<Stack<int>>(s);

            Queue<int> q = new Queue<int>();
            q.Enqueue(32);
            q.Enqueue(50);
            foreachVeera<Queue<int>>(q);

            List<string> ll = new List<string>() { "veerababu", "rallabandi" };
            foreachVeera(ll);

           
        }
    }
}
