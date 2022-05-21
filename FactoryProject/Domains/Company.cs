using FactoryProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject.Domains
{
    class Company
    {
        public DateTime ThisDay { get; set; }
        public Factory Factory { get; set; }
        public Shop Shop { get; set; }

        public Company()
        {
            Factory = new Factory();
            Shop = new Shop();
            ThisDay = new DateTime();
        }
       
        public void Start()
        {
            ThisDay = DateTime.Today;
            
            Console.WriteLine(ThisDay);
            Factory.NewFactory();
            PrintService.FactoryInfo(Factory,ThisDay);
            PrintService.BestOfferDetails(Factory.Warehouse);
            for (int i = 1; i < 10; i++)
            {
                Factory.WorkingDay(Shop, ThisDay, i);
                Shop.ShopSales(Shop, ThisDay);
                Shop.InNeedOfChocolates(Factory.DailyProduction);
                ThisDay = ThisDay.AddDays(1);
            }
            
        }

    }
}
