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
        public List<BlackChocolate> BlackChocolateList { get; set; }
        public List<WhiteChocolate> WhiteChocolateList { get; set; }
        public List<MilkChocolate> MilkChocolateList { get; set; }
        public double TotalIncome { get; set; }

        public Shop()
        {
            BlackChocolateList = new List<BlackChocolate>();
            WhiteChocolateList = new List<WhiteChocolate>();
            MilkChocolateList = new List<MilkChocolate>();
        }

        public void ShopSales(Shop shop, DateTime dateTime)
        {
            for (int i = 0; i < shop.BlackChocolateList.Count / 2; i++)
            {
                shop.BlackChocolateList.RemoveAt(i);
                TotalIncome = (BlackChocolateList[i].PricePerUnit) + TotalIncome;
            }
            for (int i = 0; i < (shop.MilkChocolateList.Count / 2); i++)
            {
                shop.MilkChocolateList.RemoveAt(i);
                TotalIncome = MilkChocolateList[i].PricePerUnit + TotalIncome;
            }
            for (int i = 0; i < (shop.WhiteChocolateList.Count / 2); i++)
            {
                shop.WhiteChocolateList.RemoveAt(i);
                TotalIncome = WhiteChocolateList[i].PricePerUnit + TotalIncome;
            }
            PrintService.ShopSales(shop, dateTime);
        }
    }
}
