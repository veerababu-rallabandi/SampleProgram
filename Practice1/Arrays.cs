using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class Arrays
    {
        protected internal void single()
        {
            //way 1
            int[] a1 = new int[5];
            foreach(int i in a1)
            {
                Console.WriteLine(i);
            }

            //way2
            int[] a2 = new int[3] { 1, 2, 3};
            foreach(int i in a2)
            {
                Console.WriteLine(i);
            }

            //way3
            int[] a3 = new int[] { 1, 2, 3 };
            foreach(int i in a3)
            {
                Console.WriteLine(i);
            }

            //way 4
            int[] a4 = { 1, 2, 3 };
            foreach(int i in a4)
            {
                Console.WriteLine(i);
            }

            //way 5
            int[] a5;
            a5 =new int[]{1,2,3};
            foreach(int i in a5)
            {
                Console.WriteLine(i);
            }
        }
        public void multi()
        {
            //way 1
            int[,] a1 = new int[3, 2];
            Console.WriteLine(a1[0,0]);
            Console.WriteLine(a1[1,1]);

            //way 2
            int[,] a2 = new int[3, 2] {
                                         {1,2 },
                                         {3,4 },
                                         {5,6 }
                                       };
            Console.WriteLine(a2[2,1]);

            //way 3
            int[,] a3 = new int[,] { { 2, 2 }, { 3, 4 } };
            foreach(int i in a3)
            {
                Console.WriteLine(i);

            }

            //way 4
            string[,] a4 = new string[,] {
                                            { "name","veerababu"},
                                            {"name","rallabandi" }
                                         };
            foreach(string i in a4)
            {
                Console.WriteLine(i);
            }

            //way 5
            int[,,] a5 = { {{1,2 },{3,4 } },
                          { { 5, 8 },{ 9, 10 } } };

            foreach(int i in a5)
            {
                Console.WriteLine(i);
            }
           
           
        }
        public void Jagged()
        {
            //way1
            int[][] a1 = new int[2][];
            a1[0] =new int[3]{ 1,2,3};
            a1[1] =new int[1]{4};
            foreach(int[] i in a1)
            {
                foreach(int j in i)
                {
                    Console.WriteLine(j);
                }
            }

            //way 2
            int[][,] a2 = new int[2][,];
            a2[0] = new int[,] { { 1,2,3},{4,5,6} };
            a2[1] = new int[,] { {10,11 }, {12,13 } };

            foreach (int[,] i in a2 )
            {
                foreach(int j in i)
                {
                    Console.WriteLine(j);
                }
            }

            

            
        }
        public void methods()
        {
            int[] a1 = new int[5] { 1, 2, 3, 4,5 };
            Array.Reverse(a1);
            foreach(int i in a1)
            {
                Console.WriteLine(i);
            }
            //copy array to array 
            int[] a2 = new int[3];
            Array.Copy(a1, a2, 2);
            foreach(int i in a2)
            {
                Console.WriteLine(i);
            }
            //index value
            Console.WriteLine($"index is {Array.IndexOf(a1, 2)}");

            //equal or not
            Console.WriteLine("equal method "+Array.Equals(a1, a2));

            int[] a11 = new int[3] { 1, 3, 6 };
            //sort the array
             Array.Sort(a11);
            foreach (int i in a11)
            {
                Console.WriteLine(i);
            }
            


            //Binarysearch-->if value not found  in array ,it return -(length+1), otherwise return index value.

            Console.WriteLine(Array.BinarySearch(a11, 2));

            //Binarysearch
            Console.WriteLine(Array.BinarySearch(a11,1,2,2));


            //Exists-->check whether array contains element or not ,returns true or false
            Console.WriteLine(Array.Exists(a1,ele=>ele==2));

            int[] arr = new int[5] { 10, 20, 30, 40, 50 };
            Console.WriteLine(arr.Length);
            object b= arr.Clone();
            Console.WriteLine(b);
            int[] arr1 = new int[6];
            arr.CopyTo(arr1, 1);
            Array.ForEach(arr, ele => Console.WriteLine(ele));

            Console.WriteLine( arr.GetEnumerator());
            Console.WriteLine(arr.GetHashCode());
            //Console.WriteLine(arr.GetLength(1));
            Console.WriteLine(arr.ToString());
           
            
        }
    }
}
