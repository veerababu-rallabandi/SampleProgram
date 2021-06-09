using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice2
{
    class Employee12
    {
        public int salary { get; set; }
        public static List<Employee12> GetEmp()
        {
            List<Employee12> emp = new List<Employee12>()
            {
                 new Employee12() { salary = 25000 },
                 new Employee12() { salary = 30000 },
                 new Employee12() { salary = 450000 }

            };
            return emp;
            
        }
    }
    class Linq8where
    {
        static void Main(string[] args)
        {

            //Query syntax
            var res1 = from emp in Employee12.GetEmp() where emp.salary > 30000 select emp;
            foreach(var i in res1)
            {
                Console.WriteLine(i);
            }

            //Method Syntax

            var res2 = Employee12.GetEmp().Where(emp => emp.salary > 30000);
            foreach(var i in res2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
