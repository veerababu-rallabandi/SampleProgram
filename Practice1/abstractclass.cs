using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    abstract class ABC
    {
        public abstract void show();
        public void Demo()
        {
            Console.WriteLine("I am NOn-abstract class");
        }
    }
    class abstractclass:ABC
    {
        public override void show()
        {
            Console.WriteLine("I am abstract class");
        }
    }
    
}
