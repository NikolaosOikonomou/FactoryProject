using FactoryProject.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject.Services
{
    class PrintService
    {
        public static void FactoryInfo(Factory factory, DateTime dateTime)
        {
            Console.WriteLine($"Factory was created at {dateTime}!\nFactory Name is: {factory.Name} and has {factory.Employees.Count}" +
                $" Employees.\nEmployees information:");
            foreach (Employee employee  in factory.Employees.Values)
            {
                Console.WriteLine($" {employee}");
            }
        }

        public static void BestOfferDetails(Warehouse warehouse)
        {
            Console.WriteLine($"Current Season Best Offer : {warehouse.BestOfferPrice} Price per kilo, " +
                $"{warehouse.RowMatterialsQuantity} Quantity and Quality {warehouse.RowMatterialQuality}.\n");
        }

        public static void ProductionReport(DailyProduction dailyProduction, DateTime dateTime)
        {
            Console.WriteLine($"At {dateTime} our Factory produce {dailyProduction.BlackChocolateList.Count} Black Chocolates," +
                $"{dailyProduction.MilkChocolatesList.Count} Milk Chocolates and {dailyProduction.WhiteChocolatesList.Count} " +
                $"White Chocolates.\n");
        }

        public static void ProductionWarehouseReport(ProductionWarehouse productionWarehouse)
        {
            Console.WriteLine($"After distribution, Production Warehouse now has {productionWarehouse.WarehouseBlackChocolateList.Count} Black Chocolates" +
               $", {productionWarehouse.WarehouseMilkChocolatesList.Count} Milk Chocolates and" +
               $" {productionWarehouse.WarehouseWhiteChocolatesList.Count} White Chocolates.");
        }

        public static void ShopWarehouseReport(ShopWarehouse shopWarehouse)
        {
            Console.WriteLine($"Shop now has {shopWarehouse.ShopBlackChocolateList.Count} Black Chocolates," +
                $" {shopWarehouse.ShopMilkChocolateList.Count} Milk Chocolates and {shopWarehouse.ShopWhiteChocolateList.Count} White Chocolates.");
        }

        public static void ShopSales(Shop shop, DateTime dateTime)
        {
            Console.WriteLine($"Shop total income for  {dateTime}  is : {shop.TotalIncome} ");
        }
    }
}
