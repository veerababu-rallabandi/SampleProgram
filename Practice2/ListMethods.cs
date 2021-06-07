using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class ListMethods
    {
        public void Methods()
        {   
            //way-1
            List<int> l = new List<int>();

            //way-2
            List<int> l1 = new List<int>() {2,5,4};
            Console.WriteLine($"capacity is { l1.Capacity}");

            l1.Add(6);
            l1.Add(2);
            Console.WriteLine($"capacity is {l1.Capacity}") ;

            Console.WriteLine($"count is {l1.Count}");

            l1.Sort();
            foreach(int i in l1)
            {
                Console.WriteLine(i);
            }
            int r=l1.BinarySearch(5);
            Console.WriteLine($"index is {r}");
            Console.WriteLine(l1.BinarySearch(50));// may not found -(no.of element+1)=-6

            //insert element at specified position
            l1.Insert(1, 3);

            Console.WriteLine($"{l1.Contains(5)}");
            Console.WriteLine(l1.Contains(54));


            Console.WriteLine(l1.IndexOf(6));

            int[] a = new int[10];

            //copyto is used to copy list elements into array.
            l1.CopyTo(a);
            Console.WriteLine(a.Length);


            //ToArray
            int[] b=l1.ToArray();
            foreach(int i in b)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine($"equalto : { l1.Equals(l1)}");

            //If condition true, first occurence of list is return, otherwise 0 return.
            Console.WriteLine($"first occuren of list:{l1.Find(ele=>ele==5)}");
            Console.WriteLine($"{l1.Find(ele=>ele==399)}");


            Console.WriteLine(l1.ToString());

            Console.WriteLine(l1.FindAll(ele=>ele==6));

           bool t= l1.Exists(ele=>ele==55);
            Console.WriteLine("value is "+t);

            //reverse
            Console.WriteLine("reverse of elements");
            l1.Reverse();//6 5 4  2 3 2
            foreach(int i in l1)
            {
                Console.WriteLine(i);
            }

            l1.ForEach(item => Console.WriteLine(item));

            //findindex
            Console.WriteLine("FindIndex: ");
            Console.WriteLine(l1.FindIndex(0,6,ele=>ele==55));

            Console.WriteLine($"Findlast :{l1.FindLast(ele => ele == 5)}");

            //range
            l1.AddRange(l1);
            Console.WriteLine("addrange after elements");
            foreach(int i in l1)
            {
                Console.WriteLine(i);
            }

           List<int> ll= l1.GetRange(0, 4);
            Console.WriteLine("elements frrom ll list");
            foreach(int i in ll)
            {
                Console.WriteLine(i);
            }
            List<int> l2 = new List<int>() { 44, 55 };
            ll.InsertRange(0, l2);
            Console.WriteLine("elements from ll list ");
            foreach(int i in ll)
            {
                Console.WriteLine(i);
            }

            //checks all elements, spefies all elements condition , return true, otherwise false
            Console.WriteLine(ll.TrueForAll(ele => ele > 1));

            //AsReadonly
            foreach(int i in ll)
            {
                Console.WriteLine(i);
            }

            
            IList<int> list=ll.AsReadOnly();
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("changes done");
            Console.WriteLine("element is "+list[0]);
            




            
        }
    }
}
