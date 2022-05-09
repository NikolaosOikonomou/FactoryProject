using FactoryProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Factory
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
        public int Quantity { get; set; }

        //List<Employee> employeesList = new List<Employee>();

        public Factory(string name, List<Employee> employees, int quantity)
        {
            Name = name;
            Employees = employees;
            Quantity = quantity;
        }
        
    }
}
