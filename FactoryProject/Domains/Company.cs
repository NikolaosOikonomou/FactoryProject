using FactoryProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject.Domains
{
    /// <summary>
    /// The main entity
    /// </summary>
    class Company
    {
        public DateTime ThisDay { get; set; }
        public Factory Factory { get; set; }
        public List<Shop> Shops { get; set; }
        public double IncomeOfAllShops { get; set; }

        public Company()
        {
            Factory = new Factory();
            Shops = new List<Shop>();
            ThisDay = new DateTime();
            IncomeOfAllShops = 0;
        }
       
        public void Start()
        {
            ThisDay = DateTime.Today;
            
            Console.WriteLine(ThisDay);
            Factory.NewFactory();
            PrintService.FactoryInfo(Factory,ThisDay);
            PrintService.BestOfferDetails(Factory.Warehouse);
            Shops.Add(new Shop());
            for (int i = 1; i < 150; i++) //Represents the days
            {
                var shopCounter = 1;
                foreach (Shop shop in Shops)
                {
                    Factory.WorkingDay(shop, ThisDay, i);
                    shop.ShopSales(shop, ThisDay, shopCounter);
                    shop.InNeedOfChocolates(Factory.DailyProduction);
                    shopCounter++;
                    IncomeOfAllShops = IncomeOfAllShops + shop.TotalIncome;
                }
                Console.WriteLine($"The total income for the Company in {ThisDay} is {IncomeOfAllShops}");
                Console.WriteLine($"Our Company has {Shops.Count} Shops");
                Factory.DailyProduction.ProductionWarehouse.NewShopCheck(Shops);
                ThisDay = ThisDay.AddDays(1);
            }
            
        }

    }
}
