using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class collections1
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();

            a.Add(12);
            a.Add(32);
            a.Add(21);
            a.Add(45);
            a.Sort();
            Console.WriteLine(a.Capacity);
            Console.WriteLine(a.BinarySearch(32));
            Console.WriteLine(a.SyncRoot);
            object[] o=a.ToArray();
            foreach(object i in o)
            {
                Console.WriteLine(i);
            }
            foreach(object i in a)
            {
                Console.WriteLine(i);
            }

            Array v = a.ToArray();
            foreach(object i in v)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(a.Count);

            Console.WriteLine(a.Contains(21));
            //elements
            
            foreach(int i in a.GetRange(0,3))
            {
                Console.WriteLine(i);
            }

            IEnumerator aa = a.GetEnumerator();
            IEnumerator aaa = a.GetEnumerator(0, 2);
            Console.WriteLine(aaa.MoveNext());
            Console.WriteLine(aaa.Current);
            Console.WriteLine(aa.MoveNext());
            Console.WriteLine(aa.Equals(aaa));

            Console.WriteLine(a.IndexOf(21));
            a.Insert(1,10);
            a.Reverse();
            foreach(object i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(a.IsFixedSize);
            Console.WriteLine(a.LastIndexOf(45));
            a.Remove(45);
            foreach(object i in a)
            {
                Console.WriteLine(i);
            }



            //sortedList in generic

            Console.WriteLine("sortedList in generic mode");


            SortedList<int, string> s = new SortedList<int, string>();
            s.Add(1, "veera");
            s.Add(2, "madhu");
            s.Add(0, "veerababu");
            foreach(int i in s.Keys)
            {
                Console.WriteLine(s[i]);
            }

            foreach(string i in s.Values)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(s.Count);
            s.RemoveAt(0);
            foreach(string i in s.Values)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(s.ContainsValue("madhu"));
            Console.WriteLine(s.ContainsKey(1));
            Console.WriteLine(s.ContainsKey(4));
            Console.WriteLine(s.IndexOfValue("veerab"));


            //sortedLIst in Non-generic mode

            Console.WriteLine("sortedList in Non-generic mode");
            SortedList ss = new SortedList();


            //sorted table automatically sorted based on keys.
            ss.Add(1, "veera");
            ss.Add(2, "srinu");
            ss.Add(0, "sai");
            foreach(object i in ss.Keys)
            {
                Console.WriteLine(i);
            }
            foreach(object i in ss.Values)
            {
                Console.WriteLine(i);
            }
            object m=ss.Clone();
            Console.WriteLine(m);
        }
    }
}
