using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryProject;
using FactoryProject.Domains;

namespace FactoryProject.Services
{
    class CreateFactory : Factory
    {
        public static Factory CFactory()
        {
            Warehouse warehouse = new Warehouse();
            CreateFactory alimpinisis = new CreateFactory()
            {
                Name = "Alimpinisis AE",
                Employees = CreateEmployee.EmployeeList(),
                Warehouse = warehouse
            };

            return alimpinisis;
        }

        public override string ToString()
        {
            return ($"Factory Name:{CreateFactory.CFactory().Name}\n\tHas a total of " +
                $"{CreateFactory.CFactory().Employees.Count} Employees, and {CreateFactory.CFactory().Warehouse} kilos row material");
        }
    }
}
