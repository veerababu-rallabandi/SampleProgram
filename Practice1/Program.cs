using System;

namespace Practice1
{
    class Program
    {
        public struct user
        {
            public string name;
            public int age;
        }
        struct person
        {
            public  string name;
            public  int age;
        }
        struct person1
        {
            public string name;
            public  int age;
           public person1(string name,int age)
            {
                this.name = name;
                this.age = age;
            }
        }
        struct person2
        {
            public int a;
            public person2(int a)
            {
                this.a = a;
            }
           
        }
        struct home
        {
           public static int a { get; set; }
        }
       
        static void Main(string[] args)
        {


            //using properties
            Properity ppp = new Properity();
            ppp.Method1();
            //enum 
            Enumexample e = new Enumexample();
            e.Method1();

            home.a = 10;
            Console.WriteLine($"value is {home.a}");
            var n=@"""I don't know do "" he said";
            Console.WriteLine(n);

            Dictionary dt = new Dictionary();
            dt.Method1();

            Console.WriteLine();
            
           

            person2 pp = new person2();
            Console.WriteLine(pp.a);
            person2 pp1 = new person2(10);
            Console.WriteLine(pp1.a);
            //struct
            user ss;
            user sss = new user();
            ss.name ="veeru";
            ss.age =22;
            Console.WriteLine($"Name is {ss.name} \nage is {ss.age}");

            user s2;
            s2.name = "veera";
            s2.age = 25;
            Console.WriteLine(ss.GetHashCode());
            Console.WriteLine(s2.GetHashCode());

            //struct way 2
           
            
            person p = new person();
            p.name = "veerababu";
            p.age = 25;
            

            Console.WriteLine($"way2: Name is {p.name}\nage is {p.age}");

            person1 p1 = new person1("rallabandi", 23);
            Console.WriteLine($"way3: Name is {p1.name}\nage is {p1.age}");



            
            
            //ListMethods
            ListMethods l = new ListMethods();
            l.Methods();

            //Array
            Arrays arr = new Arrays();
            //sigledimensional
            arr.single();

            //multidimensional
            arr.multi();

            //Jagged array
            arr.Jagged();

            //Array Methods
            arr.methods();
            
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
