﻿using FactoryProject.Domains;
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
        public ProductionWarehouse ProductionWarehouse { get; set; }
    

        public Factory()
        {
            Employees = new Dictionary<int, Employee>();
            Warehouse = new Warehouse();
            DailyProduction = new DailyProduction();
            ProductionWarehouse = new ProductionWarehouse();
        }

        public void NewFactory()
        {
            Name = "Alimpinisis AE";
            Employees = Employee.EmployeeList();
            SupplyOffer bestOffer = Warehouse.BestOffer();
            Warehouse.RowMatterialsQuantity = bestOffer.OfferQuantity;
            Warehouse.RowMatterialQuality = bestOffer.RowMatterialQuality;
            Warehouse.BestOfferPrice = bestOffer.PricePerKilo;
        }
        
        public void WorkingDay(Shop shop, DateTime dateTime)
        {
            Console.WriteLine($"\nThe Warehouse has {Warehouse.RowMatterialsQuantity} kilos row materials");

            
                DailyProduction.ChocolatesProduction();
                PrintService.ProductionReport(DailyProduction, dateTime);
                double rowMatterialsUsed = DailyProduction.DailyRowMaterialsUsed(DailyProduction.BlackChocolateList[0].KiloPerUnit, DailyProduction.MilkChocolatesList[0].KiloPerUnit, DailyProduction.WhiteChocolatesList[0].KiloPerUnit);
                Warehouse.RowMatterialsQuantity = Warehouse.RowMatterialsQuantity - rowMatterialsUsed;
                DailyProduction.ChocolatesToProductionWarehouseAndShop(ProductionWarehouse, shop);
                DailyProduction.BlackChocolateList.Clear();
                DailyProduction.MilkChocolatesList.Clear();
                DailyProduction.WhiteChocolatesList.Clear();
            
            PrintService.ProductionWarehouseReport(ProductionWarehouse);
            PrintService.ShopWarehouseReport(shop);
        }
   
    }
}
