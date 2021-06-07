using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    public delegate void simpledelegate(int x, int y);
    class Delegate2
    {
        public void Mul(int a,int b)
        {
            Console.WriteLine($"Multiplication is :{a*b}");
        }
        public void Div(int a,int b)
        {
            Console.WriteLine($"Division is :{a/b}");
        }
        static void Main(string[] args)
        {
            Delegate2 dd = new Delegate2();
            sample(dd.Mul, 10, 20);
            sample(dd.Div, 20, 10);


        }
        static void sample(simpledelegate d,int a,int b)
        {
            d(a, b);
        }
        
    }
}
