using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class Dictionary
    {
        public void Method1()
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "veeru");
            d.Add(2, "madhu");
            d.Add(3, "mahesh");
            d.Add(4, "mahesh");

            Console.WriteLine($"exist is  {d.ContainsKey(7)}");
            Console.WriteLine($"exist is {d.ContainsValue("veeru")}");
            Console.WriteLine($"{d.EnsureCapacity(5)}");

            foreach (int i in d.Keys)
            {
                Console.WriteLine(i);
            }
            foreach (string i in d.Values)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(d.Count);

            Console.WriteLine(d.Equals(d));


            Console.WriteLine(d.GetHashCode());

            Console.WriteLine(d.Remove(1));
            foreach (int i in d.Keys)
            {
                Console.WriteLine(i);
            }

            // add element,key added return true,otherwise false
            Console.WriteLine(d.TryAdd(1, "veeru"));
            string s = d[1];

            //matched returns true otherwise false
            Console.WriteLine(d.TryGetValue(1, out s));

            //remove key , value returns true otherwise false
            Console.WriteLine(d.Remove(1, out s));
            d.Add(5, "");

            //properties

            IEqualityComparer<int> f = d.Comparer;
            Console.WriteLine(f);

            

        }
    }
}
