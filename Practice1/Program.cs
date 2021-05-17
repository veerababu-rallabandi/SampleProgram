using System;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Methods
            Methods m = new Methods();
            m.Method1();
            m.Method2(10, 20);
            Console.WriteLine(m.Method3());
            Console.WriteLine(m.Method4("veeru"));
            //by using ref keyword
            int a = 10;
            Console.WriteLine("befor calling a:"+a);
            m.Method5(ref a);
            Console.WriteLine("after calling a:"+a);

            //By using out keyword
            int b = 10;
            Console.WriteLine("before calling b:"+b);
            m.Method6(out b);
            Console.WriteLine("after calling b:"+b);

            //By using params keyword
            m.Method7(1,2,3,4);
            m.Method7(1, "veeru", 1.3f, true);

            //By using in keyword-->read-only
            int c = 12;
            int d = 15;
            Console.WriteLine("before calling c is "+d);
            Console.WriteLine("before calling d is "+c);
            m.Method8(c,ref d);
            Console.WriteLine("after calling d is " +d);
            Console.WriteLine("after calling c is " +c);


            StringFormat s = new StringFormat();
          //  s.Method1();
           // s.Method2();
            s.DateFormat();
            s.NumberFormat();
            s.customFormat();

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
