using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class First2
    {
        public String Name;
        public int id;
    }
    class student : First2
    {
        public void get()
        {
            Console.WriteLine($"student Details :{Name} and {id}");
        }
    }
    class Teacher : First2
    {

        public void get()
        {
            
            Console.WriteLine($"Teacher Details: {Name} and {id}");
        }
    }
    class HierachicalInheritance:Teacher
    {
        static void Main(string[] args)
        {
            HierachicalInheritance hi = new HierachicalInheritance();
            hi.Name = "veerababu";
            hi.id = 23;
            hi.get();
        }
    }
}
