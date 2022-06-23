using FactoryProject.Domains;
using FactoryProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
     class Factory
    {
        public string Name { get; set; }
        public Dictionary<int, Employee> Employees { get; set; }
        public Warehouse Warehouse { get; set; }
        public DailyProduction DailyProduction { get; set; }
        
      

        public Factory()
        {
            Employees = new Dictionary<int, Employee>();
            Warehouse = new Warehouse();
            DailyProduction = new DailyProduction();
        }

        public void NewFactory()
        {
            Name = "Alimpinisis AE";
            Employees = Employee.EmployeeList();
            Warehouse.BestOfferStored = Warehouse.BestOffer();
            Warehouse.RowMatterialsQuantity = Warehouse.BestOfferStored.OfferQuantity;
            Warehouse.RowMatterialQuality = Warehouse.BestOfferStored.RowMatterialQuality;
            Warehouse.BestOfferPrice = Warehouse.BestOfferStored.PricePerKilo;
        }
        
        /// <summary>
        /// Represents a factory working day
        /// </summary>
        /// <param name="shop"></param>
        /// <param name="dateTime"></param>
        /// <param name="index"></param>
        public void WorkingDay(Shop shop, DateTime dateTime, int index)
        {
            Console.WriteLine($"\nThe Warehouse has {Warehouse.RowMatterialsQuantity} kilos row materials");
            if (index == 1)
            {
                DailyProduction.ChocolatesProduction();
                PrintService.ProductionReport(DailyProduction, dateTime);
                DailyProduction.ChocolatesToProductionWarehouseAndShop(DailyProduction.ProductionWarehouse, shop.ShopWarehouse);
            }
            else
            {
                if (DailyProduction.ProductionWarehouse.WarehouseBlackChocolateList.Count > 1500)
                    return;
                else
                {
                    DailyProduction.ChocolatesProduction();
                    PrintService.ProductionReport(DailyProduction, dateTime);
                    DailyProduction.ChocolatesToProductionWarehouse(DailyProduction.ProductionWarehouse);
                }
            }
            double rowMatterialsUsed = DailyProduction.DailyRowMaterialsUsed(DailyProduction.BlackChocolateList[0].KiloPerUnit, DailyProduction.MilkChocolatesList[0].KiloPerUnit, DailyProduction.WhiteChocolatesList[0].KiloPerUnit);
            Warehouse.RowMatterialsQuantity = Warehouse.RowMatterialsQuantity - rowMatterialsUsed;
            if (Warehouse.RowMatterialsQuantity <= (Warehouse.RowMatterialsQuantity * 0.2))
                Warehouse.RowMatterialsQuantity = Warehouse.BestOfferStored.OfferQuantity;

            DailyProduction.BlackChocolateList.Clear();
            DailyProduction.MilkChocolatesList.Clear();
            DailyProduction.WhiteChocolatesList.Clear();
            
            PrintService.ProductionWarehouseReport(DailyProduction.ProductionWarehouse);
            PrintService.ShopWarehouseReport(shop.ShopWarehouse);
        }
   
    }
}
