using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class sample
    {
        private string name;
        private string loc;
        public string Location
        {
            get { return loc; }
            set { loc = value; }
        }
        public string Name
        {
            get
            {
                return name.ToUpper();
            }
            set
            {
                name = value;
            }
        }
    }
    class Demo
    {
       // private string name;
        //private string loc;
        public string Name
        {
            get;set;
        }
        public string Location { get; set; }
    }
    class Properity
    {
        public void Method1()
        {
            
            //normal way
            sample s = new sample();
            s.Name = "veerababu";
            s.Location = "Bhimavaram";
            Console.WriteLine($"Name is {s.Name} and city is {s.Location}");

            //Auto implemented properity
            Demo d = new Demo();
            d.Name = "veera";
            d.Location = "BVRM";
            Console.WriteLine($"Name is {d.Name} and city is {d.Location}");

        }
    }
}
