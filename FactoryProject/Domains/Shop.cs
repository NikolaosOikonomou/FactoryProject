using FactoryProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject.Domains
{
    class Shop
    {
        public ShopWarehouse ShopWarehouse { get; set; }
        public Random Random { get; set; }
        public double TotalIncome { get; set; }

        public Shop()
        {
            ShopWarehouse = new ShopWarehouse();
            Random = new Random();
        }

        public void ShopSales(Shop shop, DateTime dateTime, int shopCounter)
        {
            
            for (int i = 0; i < (shop.ShopWarehouse.ShopBlackChocolateList.Count / 2) ; i++)
            {
                shop.ShopWarehouse.ShopBlackChocolateList.RemoveAt(i);
                TotalIncome = (shop.ShopWarehouse.ShopBlackChocolateList[i].PricePerUnit) + TotalIncome;
            }
            for (int i = 0; i < (shop.ShopWarehouse.ShopMilkChocolateList.Count / 2); i++)
            {
                shop.ShopWarehouse.ShopMilkChocolateList.RemoveAt(i);
                TotalIncome = shop.ShopWarehouse.ShopMilkChocolateList[i].PricePerUnit + TotalIncome;
            }
            for (int i = 0; i < (shop.ShopWarehouse.ShopWhiteChocolateList.Count / 2); i++)
            {
                shop.ShopWarehouse.ShopWhiteChocolateList.RemoveAt(i);
                TotalIncome = shop.ShopWarehouse.ShopWhiteChocolateList[i].PricePerUnit + TotalIncome;
            }
            PrintService.ShopsInformation(shop, dateTime, shopCounter);
        }

        public void InNeedOfChocolates(DailyProduction dailyProduction)
        {
            if (ShopWarehouse.ShopBlackChocolateList.Count <= (dailyProduction.BlackChocoPerDay * 0.5) * 0.25)
                dailyProduction.ProductionWarehouse.RefillBlackChocolate(ShopWarehouse);

            if (ShopWarehouse.ShopWhiteChocolateList.Count <= (dailyProduction.WhiteChocoPerDay * 0.5) * 0.25)
                dailyProduction.ProductionWarehouse.RefillWhiteChocolate(ShopWarehouse);

            if (ShopWarehouse.ShopMilkChocolateList.Count <= (dailyProduction.MilkChocoPerDay * 0.5) * 0.25)
                dailyProduction.ProductionWarehouse.RefillMilkChocolate(ShopWarehouse);
        }
    }
}
