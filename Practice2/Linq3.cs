using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Practice2
{
    class student
    {
        public string Name { get; set; }
        public int age { get; set; }
    }
    class Emp
    {
        public string Name { get; set; }
        public int id { get; set; }
    }
    class Linq3
    {
        static void Main(string[] args)
        {
            List<string> l = new List<string>() { "veerababu", "madhu" };

            List<student> s = new List<student>()
            {
                new student(){Name="veerababu",age=23},
                new student() { Name = "madhu", age = 22 },
                new student(){Name="ravi",age=19}

            };

            //IEnumberable or IEnumberable<T>
            IEnumerable<student> val = from i in s where i.age > 20 select i;
            foreach(var i in val)
            {
                Console.WriteLine(i);
            }

            IEnumerable<string> d = from i in l where i.Length > 5 select i;
            foreach(string i in d)
            {
                Console.WriteLine(i);
            }

            //IQueryable
            List<int> lll = new List<int>() { 1, 2, 3, 45, 34 };
            //lll.AsQueryable()
           // IQueryable<int>  = .AsQueryable<int>;

            IQueryable<student> s1 = s.AsQueryable().Where(i => i.age> 21);

            foreach(var i in s1)
            {
                Console.WriteLine(i.age);
            }



            //Difference b/w IEnumberable & IQueryable

            //IEnumberable

            List<Emp> ep = new List<Emp>()
            {
                new Emp(){Name="veerababu",id=7},
                new Emp(){Name="madhu",id=6},
                new Emp(){Name="mahesh",id=3}
            };

            IEnumerable<Emp> o = ep.Where(x => x.id > 5).ToList<Emp>();//filter
            Console.WriteLine("IEnumberable purpose");
            foreach(var i in o)
            {
                Console.WriteLine(i.id);
            }

            //IQueryable
            IQueryable<Emp> q = ep.AsQueryable<Emp>().Where(x => x.id > 5);//with filter
            Console.WriteLine("IQueryable purpose");
            foreach(var i in q)
            {
                Console.WriteLine(i.id);
            }

        }
    }
}
