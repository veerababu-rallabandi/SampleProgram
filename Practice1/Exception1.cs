using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class Exception1
    {
        static void Main(string[] args)
        {
            int a = 8;
            int b = 0;
            try
            {
               // double x = double.Parse(Console.ReadLine());
                int z = a / b;
                Console.WriteLine(z);
            }
           
            catch (ArithmeticException ex)
            {
              //  Console.WriteLine(ex.Source);
                Console.WriteLine(ex.Message);
            }
            //catch (FormatException ex1)
            //{
                
            //    Console.WriteLine(ex1.Message);
            //}
            //catch(Exception ex2)
            //{
            //    Console.WriteLine(ex2.Message);
            //}
            //catch
            //{
            //    Console.WriteLine("hello");
            //}


        }
    }
}
