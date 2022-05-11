using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject.Domains
{
    class Company
    {
        public Factory Factory { get; set; }
        public Warehouse Warehouse { get; set; }

        public Company()
        {
            
        }
    }
}
