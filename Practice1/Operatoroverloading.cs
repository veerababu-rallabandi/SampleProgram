using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class Matrix
    { 
        public int a,b,c,d;
        public Matrix(int a,int b,int c,int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public static Matrix operator +(Matrix obj1, Matrix obj2)
        {
            Matrix obj = new Matrix(obj1.a + obj2.a, obj1.b + obj2.b, obj1.c + obj2.c, obj1.d + obj2.d);
            return obj;
        }
        public static Matrix operator -(Matrix obj1,Matrix obj2)
        {
            Matrix obj = new Matrix(obj1.a - obj2.a, obj2.a - obj2.b, obj1.a -obj2.b, obj1.d - obj2.d);
            return obj;
        }
        //overriding the Tostring() method...
        public override string ToString()
        {
            //return "hello world";
            return a + " " + b + "\n" + c + " " + d;
        }
    }
    class Operatoroverloading
    {
        
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix(10, 12, 3, 6);
            Matrix m2 = new Matrix(2, 2, 4, 5);
            Matrix result = m1 + m2;
            Matrix result1 = m1 - m2;
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(result);
            Console.WriteLine(result1);
           
        }
    }
}
