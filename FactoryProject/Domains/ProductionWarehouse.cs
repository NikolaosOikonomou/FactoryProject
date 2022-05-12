using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject.Domains
{
    class ProductionWarehouse
    {
        public List<BlackChocolate> WarehouseBlackChocolateList { get; set; }
        public List<WhiteChocolate> WarehouseWhiteChocolatesList { get; set; }
        public List<MilkChocolate> WarehouseMilkChocolatesList { get; set; }

        public ProductionWarehouse()
        {
            WarehouseBlackChocolateList = new List<BlackChocolate>();
            WarehouseWhiteChocolatesList = new List<WhiteChocolate>();
            WarehouseMilkChocolatesList = new List<MilkChocolate>();
        }
        
     

    }
}
