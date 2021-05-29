using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    public class DemoException:ApplicationException
    {
        public override string Message
        {
            get
            {
                return "divided by -1";
            }
        }
    }
    public  class MyException :Exception
    {
        
        public MyException(string name) : base(name)
        {

        }
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
                if(true)
                {
                    //throw new DemoException();
                    throw new ApplicationException("some");
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //catch(DemoException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //try2
            try
            {
                Console.WriteLine(divide(1,-1));
            }
            catch (MyException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch(DivideByZeroException ex2)
            {
                Console.WriteLine("Divided by zero");
               Console.WriteLine(divide(10,1));
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
        public static int divide(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                throw new Exception("negative values not allowed");
            }
            if (a == b)
            {
                throw new MyException("numerator and dimenator are equal");
            }
            return a / b;
        }
    }
}
