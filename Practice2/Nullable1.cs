using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class Nullable1
    {

        static void Main(string[] args)
        {

            Nullable<int> c = 20;
            Console.WriteLine(c.GetType());

            //shorthand of Nullable type
            int? a = 10;
            int? b = null;
            Console.WriteLine(a.HasValue); //True bcoz a=10
            Console.WriteLine(b.HasValue);// False bcoz b=null

            Console.WriteLine(a.GetValueOrDefault());//If not null, return value--10
            Console.WriteLine(b.GetValueOrDefault());//If null, return 0 value

            int d = 10;
            int result = (int)a * d;  //arises some we cannot convert int? to int ,explicit typecasting
            Console.WriteLine(result);


            int[] arr = new int[3] { 3, 4, 5 };

            int?[] arr1 = new int?[2];
            arr1[0] = 3;
            arr1[1] = null;

            int?[] cc = new int?[2] { null, 39 };

            Console.WriteLine("Nullable array elements");
            foreach(int? i in cc)
            {
                Console.WriteLine(i.GetValueOrDefault());
            }

           




            //Compare Nullable type with Non-Nullable type is possible... 
            if (a == d)
            {
                Console.WriteLine("Equal");
            }

            int? result1 = a * d; //Implicitly convert to int? ,Nullable type...
            Console.WriteLine(result1.HasValue);
            

            //null-coalescing operator(??)
            int? r = b ?? 110;  //If a is null then 0 is assigned to r otherwise value is assigned to r
            Console.WriteLine(r);
            Console.WriteLine(r.Value);


            int? x = null;
            int y = 3;
            int z = x.GetValueOrDefault() * y;
            Console.WriteLine(z);

           
            Console.WriteLine(string.Format("{0,10} {1,-10}", "veerababu", "rallabandi"));


            int? bb = say(2, 3);
            Console.WriteLine(say(2,3));//callign method, it is return nullable
          

        }
        public static int? say(int a,int b)
        {
            return a * b;
        }

	
    }
}
