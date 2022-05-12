using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject.Domains
{
    class Shop
    {
        public List<BlackChocolate> BlackChocolate { get; set; }
        public List<WhiteChocolate> WhiteChocolate { get; set; }
        public List<MilkChocolate> MilkChocolate { get; set; }
    }
}
