using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
   public  class MyException : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "divided by -1";
            }
        }
        //public MyException(string name):base(name)
        //{

        //}
    }
    class Exception3
    {
        static void Main(string[] args)
        {
            int a = 8;
            int b = -1;
            try
            {

                int z = a / b;
                if (b == -1)
                {
                    throw new MyException();
                }
              //  Console.WriteLine(divide(1,1));
            }
            catch (MyException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch(DivideByZeroException ex2)
            {
                Console.WriteLine("Divided by zero");
               // Console.WriteLine(divide(10,1));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            finally
            {
                Console.WriteLine("good bye");
            }
        }
        //public static int divide(int a,int b)
        //{
        //    if(a<0 || b < 0)
        //    {
        //        throw new Exception("Negative values not allowed");
        //    }
        //    if (a == b)
        //    {
        //        throw new MyException("Numerator and dimenator are equal");
        //    }
        //    return a/b;
        //}
    }
}
