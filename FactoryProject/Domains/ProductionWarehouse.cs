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
        
        public void RefillBlackChocolate(ShopWarehouse shopWarehouse)
        {
            for (int i = shopWarehouse.ShopBlackChocolateList.Count; i <= shopWarehouse.MaxCapacityBlackChoco - 1; i++)
            {
                shopWarehouse.ShopBlackChocolateList.Add(WarehouseBlackChocolateList[i]);
                WarehouseBlackChocolateList.RemoveAt(i);
            }
        }

        public void RefillWhiteChocolate(ShopWarehouse shopWarehouse)
        {
            for(int i = shopWarehouse.ShopWhiteChocolateList.Count; i <= shopWarehouse.MaxCapacityWhiteChoco - 1; i++)
            {
                shopWarehouse.ShopWhiteChocolateList.Add(WarehouseWhiteChocolatesList[i]);
                WarehouseWhiteChocolatesList.RemoveAt(i);
            }
        }

        public void RefillMilkChocolate(ShopWarehouse shopWarehouse)
        {
            for (int i = shopWarehouse.ShopMilkChocolateList.Count; i <= shopWarehouse.MaxCapacityMilkChoco - 1; i++)
            {
                shopWarehouse.ShopMilkChocolateList.Add(WarehouseMilkChocolatesList[i]);
                WarehouseMilkChocolatesList.RemoveAt(i);
            }
        }

    }
}
