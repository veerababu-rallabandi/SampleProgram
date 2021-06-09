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
            //This line used to convert generic type to specified type at runtime
            dynamic d = l;

            /*
             * Actually IEnumerable interface has GetEnumerator() method, but dynamic type has not GetEnumerator() method..
             * So, convert dynamic variable to IEnumerable type..
             * GetEnumerator returns IEnumerator type.
             */
            IEnumerator s = (d as IEnumerable).GetEnumerator();

            /* IEnumerator has MoveNext() method in IEnumerable interface & it returns next to position is available or not
             * If available value return true otherwise false.
             * 
             */
            while (s.MoveNext())
            {
                //IEnumerator has current properity & it used to print the current position value
                Console.WriteLine(s.Current);
            }
        }
        static void Main(string[] args)
        {

            //create list with Generic type string
            List<string> l = new List<string>() { "veerababu", "madhu", "mahesh" };

            //pass l in foreachVeera()method
            foreachVeera(l);


            //creating List with int type
            List<int> ll = new List<int>() { 1, 2, 3 };
            //pass ll as parameter to foreachVeera()method
            foreachVeera(ll);

            //create stack with int type
            Stack<int> s = new Stack<int>();
            //add values to stack
            s.Push(23);
            s.Push(43);
            //pass stack s object as parameter to foreachVeera() method
            foreachVeera<Stack<int>>(s);

            //create queue q
            Queue<int> q = new Queue<int>();
            //add values to Queue
            q.Enqueue(32);
            q.Enqueue(50);
            //pass q object as parameter
            foreachVeera<Queue<int>>(q);

            //create list with string type
            List<string> lll = new List<string>() { "veerababu", "rallabandi" };
            //pass list object to foreachVeera() method
            foreachVeera(lll);

            //create array with int
            int[] a = new int[] { 1, 3, 5 };
            //pass a as parameter to foreachVeera()method
            foreachVeera<int []>(a);

            //create ArrayList
            ArrayList aa = new ArrayList() {2,45,78,89 };

            //pass ArrayList object as parameter to foreachVeera()method
            foreachVeera(aa);

         
        }

    }
}
