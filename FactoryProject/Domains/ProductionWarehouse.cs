using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject.Domains
{
    /// <summary>
    /// The factory's warehouse
    /// </summary>
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
        
        /// <summary>
        /// Refilling Shop's Warehouse when needed for Black chocolates
        /// </summary>
        /// <param name="shopWarehouse"></param>
        public void RefillBlackChocolate(ShopWarehouse shopWarehouse)
        {
            for (int i = shopWarehouse.ShopBlackChocolateList.Count; i <= shopWarehouse.MaxCapacityBlackChoco - 1; i++)
            {
                shopWarehouse.ShopBlackChocolateList.Add(WarehouseBlackChocolateList[i]);
                WarehouseBlackChocolateList.RemoveAt(i);
            }
        }

        /// <summary>
        /// Refilling Shop's Warehouse when needed for White chocolates
        /// </summary>
        /// <param name="shopWarehouse"></param>
        public void RefillWhiteChocolate(ShopWarehouse shopWarehouse)
        {
            for(int i = shopWarehouse.ShopWhiteChocolateList.Count; i <= shopWarehouse.MaxCapacityWhiteChoco - 1; i++)
            {
                shopWarehouse.ShopWhiteChocolateList.Add(WarehouseWhiteChocolatesList[i]);
                WarehouseWhiteChocolatesList.RemoveAt(i);
            }
        }

        /// <summary>
        /// Refilling Shop's Warehouse when needed for Milk chocolates
        /// </summary>
        /// <param name="shopWarehouse"></param>
        public void RefillMilkChocolate(ShopWarehouse shopWarehouse)
        {
            for (int i = shopWarehouse.ShopMilkChocolateList.Count; i <= shopWarehouse.MaxCapacityMilkChoco - 1; i++)
            {
                shopWarehouse.ShopMilkChocolateList.Add(WarehouseMilkChocolatesList[i]);
                WarehouseMilkChocolatesList.RemoveAt(i);
            }
        }

        /// <summary>
        /// Checks if the company can create more shops
        /// </summary>
        /// <param name="shops"></param>
        public void NewShopCheck(List<Shop> shops)
        {
            if(WarehouseBlackChocolateList.Count > 1765)
            {
                shops.Add(new Shop());
                
            }

        }
    }
}
