using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryProject;


namespace FactoryProject.Services
{
    class CreateFactory : Factory
    {
        public static Factory CFactory()
        {

            CreateFactory alimpinisis = new CreateFactory()
            {
                Name = "Alimpinisis AE",
                Employees = CreateEmployee.EmployeeList(),
                Quantity = 5000
            };

            return alimpinisis;
        }

    }
}
