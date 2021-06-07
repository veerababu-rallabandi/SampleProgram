using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    public delegate void twodelegate(int x, int y);
    class MultiDelegate
    {
        public void Sub(int a,int b)
        {
            Console.WriteLine("subtraction is {0}",a-b);
           // return a - b;
        }
        public void Mul(int a,int b)
        {
            Console.WriteLine("Multiplication is {0}",a*b);
            //return a * b;
        }
        static void Main(string[] args)
        {
            MultiDelegate md = new MultiDelegate();
            twodelegate td = new twodelegate(md.Sub); // or twodelegate td=md.Sub; --it is also used
           // Console.WriteLine(td.Invoke(20, 10));
           
           //Add Mul method  reference to delegate object. Already td has Add reference.
            td += md.Mul;

            //removes the reference of Mul method.
            td -= md.Mul; 

            td.Invoke(15, 5);
           // Console.WriteLine(td.Invoke(20, 10));

        }
    }
}
