using FactoryProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dictionary = CreateEmployee.EmployeeList();

            //foreach (var emp in dictionary)
            //{
            //    Console.WriteLine(emp);
            //}

          

            Console.WriteLine(CreateFactory.CFactory().Name);
          
        }
    }
}
