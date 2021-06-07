using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Practice1
{
    class student11:IComparable<student11>
    {
        public int id { get; set; }
        public string name { get; set; }
        public int mark { get; set; }

        public int CompareTo([AllowNull] student11 other)
        {
            if (this.id > other.id)
            {
                return 1;
            }
            else if (this.id < other.id)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
    class studentcompare : IComparer<student11>
    {
      
        public int Compare([AllowNull] student11 x, [AllowNull] student11 y)
        {
            if (x.mark > y.mark)
            {
                return 1;
            }
            else if (x.mark < y.mark)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
    class collections5
    {
        static void Main(string[] args)
        {
            student11 s = new student11() { id = 2, name = "srinivas" , mark=32};
            student11 s1 = new student11() { id = 1, name = "veerababu", mark=35 };
            student11 s2 = new student11() { id = 0, name = "madhu", mark=31};

            List<student11> l = new List<student11>() { s,s1, s2 };

            studentcompare obj = new studentcompare();
            l.Sort(obj);//don't pass obj is parameter , result based on id, not markd

           // l.Sort();//exception arises no need to compare objects,so using IComparable interface
           // l.Reverse();

            foreach(student11 i in l)
            {
                Console.WriteLine(i.id +" "+i.name+" "+i.mark);
            }
        }
    }
}
