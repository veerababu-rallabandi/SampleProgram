using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice2
{
    class Linq27GroupbyMultiple
    {
        static void Main(string[] args)
        {
            //using Method syntax

            var res1 = Student.GET().GroupBy(x => new { x.branch, x.Gender }).OrderByDescending(s => s.Key.branch).ThenBy(s => s.Key.Gender).Select(g => new
            {
                Branch = g.Key.branch,
                gender = g.Key.Gender,
                Student = g.OrderBy(x => x.name)
            });

            foreach(var n in res1)
            {
                Console.WriteLine( n.Branch+" "+n.gender);
              
            }

            //using Query syntax

            var res2 = from stu in Student.GET()
                       group stu by new
                       {
                           stu.branch,
                           stu.Gender
                       } into stugrp
                       orderby stugrp.Key.branch descending, stugrp.Key.Gender ascending
                       select new
                       {
                           Branch = stugrp.Key.branch,
                           gen = stugrp.Key.Gender,
                           Student = stugrp.OrderBy(x => x.name)
                       };

            foreach(var i in res2)
            {
                Console.WriteLine($"Branch : {i.Branch} , Gender : {i.gen} & no.of students :{i.Student.Count()}");

                foreach(var j in i.Student)
                {
                    Console.WriteLine(j.name+" :"+j.branch);
                }
            }
        }
    }
}
