using System;
using System.Collections.Generic;
using System.Text;

namespace Practice2
{
    class student12
    {
        public string Name { get; set; }
        public int id { get; set; }
    }
    class collections10
    {
        //public static int compareName(student12 s1,student12 s2)
        //{
        //    return s1.Name.CompareTo(s2.Name);
        //}
        static void Main(string[] args)
        {

            student12 s1 = new student12() { Name = "veerababu", id = 12 };
            student12 s2 = new student12() { Name = "madhu", id = 13 };
            student12 s3 = new student12() { Name = "mahesh", id = 15 };
            student12 s4 = new student12() { Name = "sampath", id = 17 };

            List<student12> l = new List<student12>() { s1, s2, s3, s4 };


            //way 1
            //   Comparison<student12> obj = new Comparison<student12>(compareName);//comparison is delegate
            //   l.Sort(obj);//first call delegate, after call to compareName method..

            //way 2
            //l.Sort(compareName);//internally delegate is created (implicitly) 


            //way3- using anonymous method(remove above compareName() method.
            //l.Sort(delegate (student12 s1, student12 s2)
            //{
            //    return s1.Name.CompareTo(s2.Name);
            //});

            //way 4
            l.Sort((s1, s2) => s1.Name.CompareTo(s2.Name));
             

            
            foreach(var i in l)
            {
                Console.WriteLine(i.Name);
            }
        }
    }
}
