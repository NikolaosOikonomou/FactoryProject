//using FactoryProject.Services;
using FactoryProject.Domains;
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
        public Warehouse Warehouse { get; set; }
        public DailyProduction DailyProduction { get; set; }

        public Factory()
        {

        }

    }
}
