using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject.Domains
{
    class ShopWarehouse
    {
        public int MaxCapacityBlackChoco { get; set; }
        public int MaxCapacityWhiteChoco { get; set; }
        public int MaxCapacityMilkChoco { get; set; }
        public List<BlackChocolate> ShopBlackChocolateList { get; set; }
        public List<WhiteChocolate> ShopWhiteChocolateList { get; set; }
        public List<MilkChocolate> ShopMilkChocolateList { get; set; }
        
        public ShopWarehouse()
        {
            MaxCapacityBlackChoco = 150;
            MaxCapacityWhiteChoco = 50;
            MaxCapacityMilkChoco = 50;
            ShopBlackChocolateList = new List<BlackChocolate>();
            ShopWhiteChocolateList = new List<WhiteChocolate>();
            ShopMilkChocolateList = new List<MilkChocolate>();
        }

        
    }
}
