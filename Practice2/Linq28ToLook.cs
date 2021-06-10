using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice2
{
    class Linq28ToLook
    {
        static void Main(string[] args)
        {
            //using Method syntax

            var res1 = Student.GET().ToLookup(s=>s.branch);

            foreach(var i in res1)
            {
                // Console.WriteLine(i.Key+" "+i.Key.Count());
                Console.WriteLine(i.Count());
                foreach(var j in i)
                {
                   
                    Console.WriteLine(j.name+":"+j.branch+" : "+j.rollnum+" : "+j.Gender);
                }
            }

            //using query syntax
            var res2 = (from st in Student.GET() select st).ToLookup(s => s.Gender);
            foreach(var i in res2)
            {
                Console.WriteLine(i.Count());
                foreach(var j in i)
                {
                    Console.WriteLine(j.name+" "+j.branch);
                }
            }

            //way 2
            var res3 = Student.GET().ToLookup(s => s.branch).OrderByDescending(c => c.Key).Select(st => new
            {

                key = st.Key,
                Students = st.OrderBy(x => x.name)
            }) ;

            foreach(var st in res3)
            {
                Console.WriteLine(st.Students.Count());

                foreach(var j in st.Students)
                {
                    Console.WriteLine($"{j.name} : {j.branch}  : {j.rollnum} : {j.Gender}");
                }
            }

            //way 3--using ToLookup with multiple keys

            /*ToLookup - uses  group students by branch first, and then gender
             * branch in Descending order & gender in ascending order
             * finally, we sort the data in each group by the name in ascending order.
             * 
             */
            var res4=Student.GET().ToLookup(n=>new { n.branch, n.rollnum }).OrderByDescending(x => x.Key.branch).ThenBy(y => y.Key.rollnum).Select(g=>new
            {

                Branch=g.Key.branch,
                id=g.Key.rollnum,
                Student10=g.OrderBy(x=>x.name)

            });

            foreach(var i in res4)
            {
                foreach(var j in i.Student10)
                {
                    Console.WriteLine($"Name is {j.name}:rollnumber : {j.rollnum}:Branch: {j.branch} Gender :{j.Gender}");
                }
            }

        }
    }
}
