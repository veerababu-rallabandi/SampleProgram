using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Practice2
{
    class DemoCompare : IEqualityComparer<college>
    {
        public bool Equals([AllowNull] college x, [AllowNull] college y)
        {
            //If both reference are equal then return true
            if (object.ReferenceEquals(x, y))
            {
                return true;
            }
            //If one of the reference is null
            if(x is null || y is null)
            {
                return false;
            }
            return x.id == y.id && x.branch == y.branch && x.studentname == y.studentname && x.lastname == y.lastname;
        }

        public int GetHashCode([DisallowNull] college obj)
        {
            //If obje is null then return 0
           if(obj is null)
            {
                return 0;
            }

            int hashid = obj.id.GetHashCode();
            int namehashid = obj.studentname == null ? 0 : obj.studentname.GetHashCode();
            int last = obj.lastname == null ? 0 : obj.lastname.GetHashCode();
            int branc = obj.branch == null ? 0 : obj.branch.GetHashCode();

            return hashid ^ namehashid ^ last ^ branc;
        }
    }
    class Linq25Contains
    {
        static void Main(string[] args)
        {

            List<college> l = new List<college>()
            {
                new college(){id=43,studentname="veeru",lastname="rallabandi",branch="MCA"},
                new college(){id=51,studentname="maheshmadhu",lastname="goteti",branch="MCA3"}
            };

            //create instance of Democomparer
            DemoCompare d = new DemoCompare();

            //using Method syntax

            //It return true bcoz pass two arguments
            var res1 = l.Contains(new college() { id = 43, studentname = "veeru", lastname = "rallabandi", branch = "MCA" }, d);
            Console.WriteLine(res1);
            var stu = new college() { id = 55, studentname = "ravi", lastname = "kumara", branch = "MPC" };

            //using Query syntax
            var res2 = (from i in l select i).Contains(stu, d);
            Console.WriteLine(res2);

        }
    }
}
