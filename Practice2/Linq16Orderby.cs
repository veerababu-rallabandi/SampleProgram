using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice2
{
    public class college
    {
        public string studentname { get; set; }
        public string branch { get; set; }
        public int id { get; set; }
        public string lastname { get; set; }

        public static List<college> getdatails()
        {
            List<college> student = new List<college>()
            {
                new college(){studentname="veerababu",branch="MECs",id=73,lastname="rallabandi"},
                new college(){studentname="madhu",branch="MECs",id=33,lastname="gangumolu"},
                new college(){studentname="avinash",branch="MPC",id=112,lastname="madilla"},
                new college(){studentname="mahesh",branch="Mpcs",id=90,lastname="dasari"},
                new college(){studentname="avinash",branch="MECs",id=55,lastname="paritla"}

            };
            return student;
        }

    }
    class Linq16Orderby
    {
        static void Main(string[] args)
        {
            //This program about orderBy method in Linq..

            List<int> l1 = new List<int>() { 10, 20, 1, 3, 5, 8, 11, 23, 19 };

            Console.WriteLine("Before sorting");
            foreach(int i in l1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("After sorting, using Method syntax:");
            //sorting data in ascending order..
            //Using Method syntax
            var res1 = l1.OrderBy(n => n);
            foreach(int i in res1)
            {
                Console.WriteLine(i);
            }

            //Using query syntax
            var res2 = (from num in l1 orderby num select num).ToList();

            var res3 = (from i in l1 select i).OrderBy(n => n); //Mixed syntax--Method+Query

            List<string> l2 = new List<string>() { "veerababu", "avinash", "madhu", "mahesh" };
            var res4 = (from name in l2 orderby name descending select name).ToList();//By default ascending..
            Console.WriteLine("Using query syntax");
            foreach(var i in res4)
            {
                Console.WriteLine(i);
            }


            //using method & query syntax on complex type

            //Method syntax

            var res5 = college.getdatails().OrderBy(n => n.branch).ToList();


            //query syntax
            var res6 = from student in college.getdatails() orderby student.id,student.branch select student;
            foreach(var i in res6)
            {
                Console.WriteLine($"{i.id} {i.studentname} {i.branch}");
            }


            //filtering and orderby --Note : where is used to before orderby

            //Method syntax
            var res7 = college.getdatails().Where(n => n.id > 50).OrderBy(n => n.studentname.StartsWith('m')).ToList();
            foreach(var i in res7)
            {
                Console.WriteLine(i.studentname+" "+i.id);
            }

            //Query syntax
            var res8 = (from student in college.getdatails() where student.branch.ToUpper() == "MECS" orderby student.studentname select student).ToList();
            foreach(var i in res8)
            {
                Console.WriteLine(i.branch);
            }
        }
    }
}
