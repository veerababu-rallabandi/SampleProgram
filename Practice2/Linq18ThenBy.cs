using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice2
{
    class Linq18ThenBy
    {
        
        static void Main(string[] args)
        {
            //This program about ThenBy or ThenByDescending

        
            //Method syntax --orderby-primary & ThenBy--secondary
            var res1 = college.getdatails().OrderBy(f => f.studentname).ThenBy(l => l.lastname).ToList();

            foreach(var i in res1)
            {
                Console.WriteLine(i.studentname+" "+i.lastname);
            }

            //Query syntax
            Console.WriteLine("using query syntax");
            var res2 = (from std in college.getdatails() orderby std.studentname, std.id descending select std).ToList();
            foreach(var i in res2)
            {
                Console.WriteLine(@"{0} {1}",i.id,i.studentname);
            }


            //using Method syntax
            Console.WriteLine("combination orderyby and ThenBy");
            var res3 = college.getdatails().OrderBy(f => f.branch).ThenBy(f => f.studentname).ThenByDescending(f => f.lastname).ToList();
            foreach(var i in res3)
            {
                Console.WriteLine($"{i.branch}:{i.id}:{i.studentname}:{i.lastname}");
            }

            //using Query syntax
            var res4 = (from stu in college.getdatails() orderby stu.id descending, stu.branch ascending, stu.lastname select stu).ToList();
            foreach(var i in res4)
            {
                Console.WriteLine($"{i.id}:{i.branch}:{i.lastname}:{i.studentname}");
            }


            //ThenBy or ThenByDescending using with where clause

            var res5 = college.getdatails().Where(f => f.branch == "MECs").OrderBy(x => x.studentname).ThenBy(i => i.id).ToList();

            //query syntax
            var res6 = (from stu in college.getdatails() where stu.id > 50 orderby stu.studentname ascending, stu.branch descending select stu).ToList();

            foreach(var i in res6)
            {
                Console.WriteLine(i.id+" "+i.studentname+" "+i.lastname+" "+i.branch);
            }

        }
    }
}
