using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice2
{
    public class Student
    {
        internal object id;

        public string name { get; set; }
        public int rollnum { get; set; }
        public string branch { get; set; }
        public string Gender { get; set; }

        public static List<Student> GET()
        {
            return new List<Student>()
            {

                new Student(){name="srinu",rollnum=12,branch="B.Tech",Gender="Male"},
                new Student(){name="veeru",rollnum=32,branch="MCA",Gender="Male"},
                new Student(){name="madhu",rollnum=13,branch="MCA",Gender = "Male"},
                new Student(){name="ravi",rollnum=44,branch="civil",Gender = "Male"},
                new Student(){name="mahesh",rollnum=45,branch="B.Tech",Gender="Male"},
                new Student(){name="jenny",rollnum=46,branch="civil",Gender="Femeale"}

            };
        }
    }
    class Linq26GroupBy
    {
        static void Main(string[] args)
        {
            //using Method syntax


            //first--groups branch--MCA, B.Tesch, civil
            var res1 = Student.GET().GroupBy(n => n.branch);

           // var res2 = Student.GET().GroupBy(s => s.name);
            foreach(var i in res1)
            {
                Console.WriteLine(i.Key);
                foreach(var j in i)
                {
                    Console.WriteLine(j.name+":"+j.branch);
                }
            }


            //using Query syntax
            IEnumerable<IGrouping<string,Student>> res3=(from num in Student.GET() group num by num.branch);

            foreach(var i in res3)
            {
                Console.WriteLine(i.Key);
                foreach(var j in i)
                {
                    Console.WriteLine($"Name is {j.name} and branch is {j.branch}");
                }
            }


            //using Method syntax
            var res4 = Student.GET().GroupBy(s => s.branch)
                //First sorting the data based on key in Descending order
                .OrderByDescending(s => s.Key).Select(st => new
            {
                key = st.Key,
                //sorting data based on name in descending order
                Student=st.OrderBy(s=>s.name)
            }) ;

            foreach(var i in res4)
            {
                Console.WriteLine(i.key);
                Console.WriteLine(i.key.Count());
               
            }

            //using query syntax
            var res5 = (from stu in Student.GET()
                        group stu by stu.branch into stuGroup
                        orderby stuGroup.Key descending
                        select new
                        {
                            key=stuGroup.Key,
                            Student=stuGroup.OrderBy(x=>x.name)
                        });

            //Iterate each group
            foreach(var i in res5)
            {
                Console.WriteLine($"key is {i.key} & count is {i.Student.Count()}");
                foreach(var j in i.Student)
                {
                    Console.WriteLine($"name is {j.name} & branch is {j.branch}");
                }
            }



        }
    }
}
