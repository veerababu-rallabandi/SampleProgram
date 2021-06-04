using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;//non-generic purpose

namespace Practice1
{
    class collections2
    {
        static void Main(string[] args)
        {
            //stack in generic mode

            Stack<int> s1 = new Stack<int>();
            s1.Push(1);
            s1.Push(2);
            s1.Push(5);

            Console.WriteLine(s1.Peek());
            Console.WriteLine(s1.Count);
            Console.WriteLine(s1.Contains(6));
            int[] aa=s1.ToArray();
            Console.WriteLine("arrray elements");
            foreach(int i in aa)
            {
                Console.WriteLine(i);
            }
            Stack<int>.Enumerator ee= s1.GetEnumerator();
            Console.WriteLine(ee.MoveNext());
            Console.WriteLine(ee.Current);

            int val=s1.Pop();
            Console.WriteLine(val);

            s1.Clear();


            //Stack in Non-Generic mode

            Stack s2 = new Stack(4);
            s2.Push(32);
            s2.Push(3);
            Console.WriteLine(s2.Pop());
            s2.Push(34);
            Console.WriteLine(s2.Count);
            Console.WriteLine(s2.Peek());
            Console.WriteLine(s2.Contains(32));
            object[] arr1 = new object[4];
            s2.CopyTo(arr1, 0);
            s2.Push("veerababu");
            s2.Push('a');
            s2.Push(3.2f);

            Console.WriteLine(s2.Peek());
            object[] arr2=s2.ToArray();
            foreach(object i in arr2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(s2.Count);

        }
    }
}
