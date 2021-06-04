using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Practice1
{
    class collections4
    {
        static void Main(string[] args)
        {
            //Hashtable in Non-generic mode

            Hashtable ht = new Hashtable();
            ht.Add(1, "veerababu");
            ht.Add("babu", 7333);
            ht.Add("ravi", "babu");
            Console.WriteLine(ht.ContainsKey("babu"));
            Console.WriteLine(ht.ContainsValue(7333));
            Console.WriteLine(ht.Contains("ravi"));
            Console.WriteLine(ht.Count);
            Console.WriteLine(ht.IsFixedSize);
            Console.WriteLine(ht.IsReadOnly);
            ht.Remove(1);
            IDictionaryEnumerator dd = ht.GetEnumerator();

            while (dd.MoveNext())
            {
                Console.WriteLine("value is "+dd.Value);
            }

            List<int> l = new List<int>();//Generic type of list
            l.Add(12);
            l.Add(2);

            //Bit Array

            BitArray bt = new BitArray(1);
            Console.WriteLine(bt.Length);
            bt.Set(0, true);
            //  bt.Xor()

            byte[] bb = { 2 };
            BitArray bt1 = new BitArray(bb);

            BitArray result = bt1.And(bt1);
            Console.WriteLine("result is "+result);
            


            //Hashset is generic collection

            HashSet<int> hs = new HashSet<int>();
            hs.Add(12);
            hs.Add(12);
            Console.WriteLine(hs.Count);
            Console.WriteLine(hs.Contains(32));
            HashSet<int>.Enumerator ee = hs.GetEnumerator();


            LinkedList<int> ll = new LinkedList<int>();
            ll.AddLast(12);
            ll.AddFirst(20);
            

           


        }
    }
}
