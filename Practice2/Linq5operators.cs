using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice2
{
    class LinqDemo
    {
        public string name;
        public int id;
        public static List<LinqDemo> Getdetails()
        {
            List<LinqDemo> l = new List<LinqDemo>()
            {
                new LinqDemo(){name="veerababu",id=43},
                new LinqDemo(){name="madhu",id=13},
                new LinqDemo(){name="mahesh",id=51}
            };
            return l;
        }
    }
    class Linq5operators
    {
        static void Main(string[] args)
        {
            //Projection operators--select, selectMany

            //Way1

            //using Query syntax
            /*At this point , Query is just created not executed. 
             * In order to execute apply some methods such ToList() or foreach etc....
             */
            IEnumerable<LinqDemo> t = (from i in LinqDemo.Getdetails() select i);

            foreach (LinqDemo i in t)
            {
                Console.WriteLine(i.name + " " + i.id);
            }

            //By using ToList() method above code--it converts into List<LinqDemo>

            //  LinqDemo[] tt = (from i in LinqDemo.Getdetails() select i).ToArray();


            /*At this point, Query is created as well as executed. as applied ToList() on query.
             */
            List<LinqDemo> tt = (from i in LinqDemo.Getdetails() select i).ToList();

            foreach (LinqDemo i in tt)
            {
                Console.WriteLine(i.name + " " + i.id);
            }

            //way 2
            //How to select specific elements
            List<LinqDemo> ttt = (from i in LinqDemo.Getdetails() where i.name.Length > 5 select i).ToList();
            Console.WriteLine("Query syntax--select operator");
            foreach (LinqDemo i in ttt)
            {
                Console.WriteLine(i.name + " " + i.id);
            }

            //using Method syntax
            IEnumerable<int> t4 = LinqDemo.Getdetails().Select(i => i.id);
            Console.WriteLine("only prints id");
            foreach (int i in t4)
            {
                Console.WriteLine(i);
            }

            //Ex3-way3


            //Query syntax
            IEnumerable<LinqDemo> t5 = (from i in LinqDemo.Getdetails()
                                        select new LinqDemo()
                                        {
                                            name = i.name,
                                            id = i.id
                                        });

            foreach (var i in t5)
            {
                Console.WriteLine(i.id + " " + i.name);
            }

            //Method syntax 
            List<LinqDemo> t6 = LinqDemo.Getdetails().Select(i => new LinqDemo()
            {
                name = i.name,
                id = i.id

            }).ToList();

            Console.WriteLine("by using Method syntax");
            foreach (var i in t6)
            {
                Console.WriteLine(i.id + " " + i.name);
            }




            /*select data to another class using LINQ select operator.
             */

            //Query syntax
            Console.WriteLine("data from another class");
            Console.WriteLine("enter lastname ");
            IEnumerable<Linq5operatorsInfo> t7 = (from i in LinqDemo.Getdetails()
                                                  select new Linq5operatorsInfo()
                                                  {
                                                      name = i.name,
                                                      id = i.id,
                                                      last = Console.ReadLine()//additional add properity in LInq5operatorsInfo class.

                                                  });
          //  Console.WriteLine("using another properities");
            foreach (Linq5operatorsInfo i in t7)
            {
                Console.WriteLine(i.id + " " + i.name + " " + i.last);
            }
            //Method syntax
            Console.WriteLine("enter salaries");
            var t8 = LinqDemo.Getdetails().Select(i => new Linq5operatorsInfo()
            {
                id = i.id,
                name = i.name,
                salary = int.Parse(Console.ReadLine()) //add new properity to LInq5operatorsinfo class.
            }).ToList();

            foreach (Linq5operatorsInfo i in t8)
            {
                Console.WriteLine(i.id + " " + i.name + " " + i.salary);
            }


            //using Anonymous type in Linq

            //Query syntax
            Console.WriteLine("using anonyomous type in LInq");
            var query = (from i in LinqDemo.Getdetails()
                         select new
                         {
                             id = i.id,
                             name = i.name
                         });
            foreach (var i in query)
            {
                Console.WriteLine(i.id + " " + i.name);
            }

            //Method syntax
            var query1 = LinqDemo.Getdetails().Select(i => new {
                id = i.id,
                name = i.name
            });
            foreach (var i in query1)
            {
                Console.WriteLine(i.id + " " + i.name);
            }



            //perform calculation on data selected using LINQ select operator

            Console.WriteLine("perform calculations ");
            var query3 = (from i in LinqDemo.Getdetails() select new {
                id = i.id + 10,
                name = "student name is" + i.name
            });
            foreach (var i in query3)
            {
                Console.WriteLine(i.id + " " + i.name);
            }

            //Method syntax
            var query4 = LinqDemo.Getdetails().Select(i => new
            {
                id = i.id + 20,
                name = "student name is " + i.name
            });

            foreach (var i in query4)
            {
                Console.WriteLine(i);
            }

            //select values using index in linq

            Console.WriteLine("By using index in linq");
            var query5 = (from i in LinqDemo.Getdetails().Select((value, index) => new { value ,index })
            select new
            {
                indexpos=i.index,
                name=i.value.name,
                id=i.value.id
            }).ToList();

            foreach(var i in query5)
            {
                Console.WriteLine(i.name+" "+i.id);
            }


            //Method syntax
            var query6 = LinqDemo.Getdetails().Select((value, index) => new
            {
                name=value.name+" is BV raju college",
                id=value.id

            });

            foreach(var i in query6)
            {
                Console.WriteLine($"{i.name} {i.id}");
            }

        }
    }
}
