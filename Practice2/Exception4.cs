using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class Exception4
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = -1;
                if (b == -1)
                {
                    throw new ApplicationException("b is negative value");
                  
                }
                Console.WriteLine(a/b);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
