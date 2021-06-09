using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice2
{
    public class Stu
    {
        public int id { get; set; }
        public string stream { get; set; }
        public List<string> program { get; set; }
        public static List<Stu> Getstudent()
        {
            return new List<Stu>()
            {
               new Stu(){id=43,stream="MCA",program=new List<string>(){ "java","python","C#" ,"java"} },
               new Stu(){id=13,stream="MCA",program=new List<string>(){"Java","python","C#"} },
               new Stu(){id=51,stream="MCA",program=new List<string>(){"python","c","c#"} },
               new Stu(){id=15,stream="MCA",program=new List<string>(){"java","python"} }
            };
        }
    }
    class Linq6SelectMany
    {
        static void Main(string[] args)
        {
            //This program about SelectMany
            List<string> l = new List<string>() { "veerababu", "rallabandi" };

            IEnumerable<char> first = l.SelectMany(x => x);

            var second = l.SelectMany(x => x);

            foreach (char i in first)
            {
                Console.WriteLine(i);
            }

            //Linq SelectMany operator
            IEnumerable<char> first1 = from str in l from ch in str select ch;

            foreach (char i in first1)
            {
                Console.WriteLine(i);
            }


            //1. using Method syntax on complex type
            List<string> res1 = Stu.Getstudent().SelectMany(x => x.program).ToList();
            foreach (string i in res1)
            {
                Console.WriteLine(i);
            }

            //2. using Query syntax on complex type 
            //  IEnumerable<char> res2 = from i in Stu.Getstudent() from j in i.stream select j;

            IEnumerable<string> res2 = from i in Stu.Getstudent() from j in i.program select j;
            foreach (string i in res2)
            {
                Console.WriteLine(i);
            }


            //using Distict() method to eliminate duplicate values
            //using Method syntax
            Console.WriteLine("After applying Distict Method:");
            List<string> res3 = Stu.Getstudent().SelectMany(x => x.program).Distinct().ToList();
            foreach (string i in res3)
            {
                Console.WriteLine(i);
            }

            //using Query syntax
            IEnumerable<string> res4 = (from i in Stu.Getstudent() from j in i.program select j).Distinct().ToList();


            foreach (string i in res4)
            {
                Console.WriteLine(i);
            }

            //how to retrieve student name & student stream

            //using Method syntax
            var res5 = Stu.Getstudent().SelectMany(i => i.program, (Stu, program) => new
            {
                studentid = Stu.id,
                studentstream = program
            }).ToList();

            foreach (var i in res5)
            {
                Console.WriteLine(i.studentid + " " + i.studentstream);
            }

            //using Query syntax
            Console.WriteLine("query syntax:");
            var res6 = (from i in Stu.Getstudent()
                        from j in i.program
                        select new
                        {
                            stuid = i.id,
                            stustream = j
                        }).ToList();
            foreach (var i in res6)
            {
                Console.WriteLine("student id " + i.stuid + " " + "student stream " + i.stustream);
            }
        }
    }
}
    
