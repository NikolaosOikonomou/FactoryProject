using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject.Services
{
    class CreateEmployee
    {
        public static Dictionary<int, Employee> EmployeeList()
        {
            Dictionary<int, Employee> listOfTheEmployees = new Dictionary<int, Employee>();
            var employee = new Employee(11, "Nikolaos Nikolaidis", WorkPosition.ShopWorker);
            listOfTheEmployees.Add(1, employee);
            employee = new Employee(12, "Kostas Tezas", WorkPosition.ShopWorker);
            listOfTheEmployees.Add(2, employee);
            employee = new Employee(13, "Thanasis Mastoras", WorkPosition.ShopWorker);
            listOfTheEmployees.Add(3, employee);
            employee = new Employee(14, "Timos Tims", WorkPosition.ShopWorker);
            listOfTheEmployees.Add(4, employee);
            employee = new Employee(15, "Spyros Rafil", WorkPosition.ShopWorker);
            listOfTheEmployees.Add(5, employee);
            employee = new Employee(16, "Peris Fousekis", WorkPosition.ShopWorker);
            listOfTheEmployees.Add(6, employee);

            return listOfTheEmployees;
        }
    }
}
