//using FactoryProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
     abstract class Factory
    {
        public string Name { get; set; }
        public Dictionary<int, Employee> Employees { get; set; }
        public int Quantity { get; set; }


        //List<Employee> employeesList = new List<Employee>();

        //public Factory(string name, Dictionary<int, Employee> employees, int quantity)
        //{
        //    Name = name;
        //    Employees = employees;
        //    Quantity = quantity;
        //}

        //public Factory()
        //{
                
        //}

       

    }
}
