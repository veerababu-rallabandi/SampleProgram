using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Practice2
{
    class list<T> : IEnumerable
    {
        List<T> l = new List<T>();

        public void Add(T i)
        {
            l.Add(i);
        }
        public T this[int index]
        {
            get { return l[index]; }
        }
        public int count
        {
            get { return l.Count; }
        }
        public IEnumerator GetEnumerator()
        {
            return l.GetEnumerator();
        }
        
    }
    class list1<T> : IEnumerable
    {

        List<T> l = new List<T>();
        public void Add(T i)
        {
            l.Add(i);
        }
        public IEnumerator GetEnumerator()
        {
            return l.GetEnumerator();
        }
    }
    class Demo
    {
        static void Main(string[] args)
        {
            list1<int> l = new list1<int>() { 1, 3, 3 };
            list<string> ll = new list<string>() { "veerababu", "rallabandi", "madhu", "mahesh" };
            foreach(string i in ll)
            {
                Console.WriteLine(i);
            }

            List<int> lll = new List<int>() { 1, 2, 3, 4, 4 };
            IEnumerable<int> value= foreachVeera( lll);
            
           
        }
        public static IEnumerable<int> foreachVeera( List<int> l)
        {
            foreach (int i in l)
            {
                yield return i;
            }

        }
    }
}
