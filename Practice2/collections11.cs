using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Practice2
{
    class Employee
    {
        public string name { get; set; }
        public int id { get; set; }
    }

    class Dummy:IEnumerable
    {
        List<Employee> list = new List<Employee>();
        public void Add(Employee Emp)
        {
            list.Add(Emp);
        }
        public Employee this[int index]
        {
            get { return list[index]; }
        }
        public int Count
        {
            get { return list.Count; }
        }
        public IEnumerator GetEnumerator()
        {
            //  return list.GetEnumerator();//by using list.getEnumerator foreach working

            //using custom GetEnumberator

            return new DummyEnumerator(this);
        }
    }

    class DummyEnumerator : IEnumerator
    {
        Dummy orgcall;
        int currentIndex;
        Employee currentEmployee;

        //constructor
        public DummyEnumerator(Dummy org)
        {
            orgcall = org;
            currentIndex = -1;//MoveNext() starts from -1->0 1 2(Before first so using -1);
        }
        public object Current => currentEmployee;

        public bool MoveNext()
        {
            if (++currentIndex>= orgcall.Count)
            {
                return false;//It return false element is not existing. in collections
            }
            else
            {
                currentEmployee = orgcall[currentIndex];
            }
            return true;//If return true element is existing in collections
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }


    
    class collections11
    {
        static void foreachveera()
        {

        }
        static void Main(string[] args)
        {

            
            /*This program create own GetEnumerator ,GetEnumerator only work on collections, not own class
             * That's why I am going to create own GetEnumerator
             */
            // List<Employee> l = new List<Employee>();

            //By using custom class
            Dummy l = new Dummy(); //but arises error in foreach bcoz it has not GetEnumerator
            l.Add(new Employee() { id = 19, name = "madhu" });
            l.Add(new Employee() { id = 20, name = "srinu" });

           
            

            //This program how working foreach() using GetEnumberator
            foreach(Employee i in l)
            {
                Console.WriteLine(i.name+" "+i.id);
            }


            
        }
    }
}
