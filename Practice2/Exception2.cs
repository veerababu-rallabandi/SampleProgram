using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class Exception2
    {
        static void Main(string[] args)
        {

            try
            {
                try
                {
                    int[] a = new int[5] { 1, 2, 3, 4, 5 };
                    for(int i = 0; i <= a.Length; i++)
                    {
                        Console.WriteLine(a[i]);
                    }
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Good afternoon");
                }
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }

        }
    }
}
