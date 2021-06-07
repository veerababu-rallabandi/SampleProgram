using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class Operators
    {
        public void Arithemetic(int a, int b)
        {
            Console.WriteLine("Arithemetic");
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            Console.WriteLine();
        }
        public void Relational(int a, int b)
        {
            Console.WriteLine("Relational");
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);
            Console.WriteLine();
        }
        public void Logical(bool a, bool b)
        {
            Console.WriteLine("Logical");
            Console.WriteLine(a && b);
            Console.WriteLine(a || b);
            Console.WriteLine(!(a && b));
            Console.WriteLine();
        }
        public void Bitwise(int a, int b)
        {
            Console.WriteLine("Bitwise");
            Console.WriteLine(a & b);
            Console.WriteLine(a | b);
            Console.WriteLine(a ^ b);
            Console.WriteLine(a << 2);
            Console.WriteLine(a >> 2);
            Console.WriteLine(~a);
            Console.WriteLine();
        }
        public void Assignment(int a, int b)
        {
            Console.WriteLine("Assignment");
            Console.WriteLine(a += b);
            Console.WriteLine(a -= b);
            Console.WriteLine(a %= b);
            Console.WriteLine();
        }
        public void Miscellaneous(int a, int b)
        {
            Console.WriteLine("Miscellaneous");
            Console.WriteLine(sizeof(int));
            Console.WriteLine(a > b ? "big" : "small");
            Console.WriteLine();
        }
    }
}
