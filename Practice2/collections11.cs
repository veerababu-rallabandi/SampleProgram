using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Practice2
{
    class PersonDetails
    {
        public int id { get; set; }
        public string name { get; set; }
        public double height { get; set; }
    }

    class Person:IEnumerable
    {
        List<PersonDetails> list = new List<PersonDetails>();
        public void Add(PersonDetails pd)
        {
            list.Add(pd);
        }
        public PersonDetails this[int index]
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

            return new PersonEnumerator(this);
        }
    }

    //class sample111 : IEnumerable
    //{
    //    public IEnumerator GetEnumerator()
    //    {
    //        yield return "hello";
    //    }
    //}

    class PersonEnumerator : IEnumerator
    {
        Person orgcall;
        int currentIndex;
        PersonDetails currentEmployee;

        //constructor
        public PersonEnumerator(Person org)
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
            Person l = new Person(); //but arises error in foreach bcoz it has not GetEnumerator
            l.Add(new PersonDetails() { id = 19, name = "madhu" ,height=5.4});
            l.Add(new PersonDetails() { id = 20, name = "srinu",height=5.8 });

         

           
            

            //This program how working foreach() using GetEnumberator
            foreach(PersonDetails i in l)
            {
                Console.WriteLine(i.name+" "+i.id);
            }

            



            
        }
    }
}
