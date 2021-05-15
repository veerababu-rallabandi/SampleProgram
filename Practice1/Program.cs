using System;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StringFormat s = new StringFormat();
          //  s.Method1();
           // s.Method2();
            s.DateFormat();

            //Operators
            Operators o = new Operators();
            o.Arithemetic(10,20);
            o.Relational(10, 20);
            o.Logical(false, true);
            o.Bitwise(2, 3);
            o.Assignment(10, 20);
            o.Miscellaneous(10, 20);

            //Iteration
            Iteration i = new Iteration();
            i.iter1(3);
            i.iter2(3);
            i.iter3(3);
            i.iter4();

            Jumping j = new Jumping();
            j.jum1();
            j.jum2();
            j.jum3();
        }
    }
}
