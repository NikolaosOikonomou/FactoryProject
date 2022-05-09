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
            var list = CreateEmployee.EmployeeList();

            foreach (var emp in list)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
