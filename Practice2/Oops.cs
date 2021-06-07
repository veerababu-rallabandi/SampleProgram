using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
   
    abstract class Demo5654e
    {
        public abstract void say();
    }
    class Oops
    {

        
        //Encapsulation Example

        private string name;
        private int age;
        public string Name { get; set; }
        public int Age { get; set; }





        public void say()
        {
            Console.WriteLine("i am abstract");
        }

        //Abstraction purpose

        //private void say()
        //{
        //    Console.WriteLine("it is abstraction");
        //}
        public void hell()
        {
            Console.WriteLine("it is public information");
        }
        
    }
    
}
