using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    //   public delegate double adddelegate(int x, float y, double z);
    public delegate int adddelegate(int x);//anonymous purpose
    class Delegate4
    {
        //public static  double add11(int x,float y,double z)
        //{
        //    return x + y + z;
        //}
        //public static void add12(int x,float y)
        //{
        //    Console.WriteLine(x+y);
        //}
        //public bool compare(string s)
        //{
        //    if (s.Length > 5)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        public static bool compareto(string s,string s1)
        {
            if (s.Equals(s1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            // adddelegate obj = add11;

            //using func delegate

            // Func<int, float, double, double> obj = add11;

            //using lambda expressions
            //Func<int,float,double,double> obj=(a,b,c) =>
            //{
            //    return a + b + c;
            //};

            Func<int, float, double, double> obj = (x, y, z) => x + y + z;
            double res=obj.Invoke(12, 1.2f, 23.2);
            Console.WriteLine(res);



            //using action delegate
            //Action<int, float> obj1 = (x,y)=>
            //{
            //    Console.WriteLine(x+y);
            //};

            Action<int, float> obj1 = (x, y) => Console.WriteLine(x + y);
            
            obj1(10, 12.0f);//or obj1.invoke(12,12.0f);

            //using predicate delegate

            Delegate4 dd = new Delegate4();
            //  Predicate<string> obj2 = dd.compare;
            //using lambda expression

            Predicate<string> obj2 = (s) =>
            {
                if (s.Length > 5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            bool a=obj2.Invoke("veerababu");
            Console.WriteLine(a);


            //using func delegate with return bool type
            Func<string, string, bool> obj3 = compareto;
            bool res1= obj3("veera", "veeru");
            Console.WriteLine(res1);


            //anoynums method in delegate

            //adddelegate obj4 = new adddelegate(
            //                 delegate (int x)
            //                 {
            //                     return x * x;
            //                 }

            //                 );

            //Console.WriteLine("By using anonyomus method with delegate"+obj4(10));


            //using Lambda expressiong above above anonymous method
           
            adddelegate obj4 = r => r * r;
            int result = obj4.Invoke(10);
            Console.WriteLine(result);
        }

    }
}
