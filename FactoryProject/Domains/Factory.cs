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
        public ProductionWarehouse ProductionWarehouse { get; set; }

        public Factory()
        {
            Employees = new Dictionary<int, Employee>();
            Warehouse = new Warehouse();
            DailyProduction = new DailyProduction();
        }

        public void NewFactory()
        {
            Name = "Alimpinisis AE";
            Employees = CreateEmployee.EmployeeList();
            SupplyOffer bestOffer = Warehouse.BestOffer();
            Warehouse.RowMatterialsQuantity = bestOffer.OfferQuantity;
            Warehouse.RowMatterialQuality = bestOffer.RowMatterialQuality;
            Console.WriteLine($"The Warehouse has {Warehouse.RowMatterialsQuantity} kilos row materials");
        }

       

        public void WorkingDay()
        {
            DailyProduction.BlackChocoProduction();
            DailyProduction.MilkChocoProduction();
            DailyProduction.WhiteChocoProduction();
            double rowMatterialsUsed = DailyProduction.DailyRowMaterialsUsed(DailyProduction.BlackChocolateList[0].KiloPerUnit, DailyProduction.MilkChocolatesList[0].KiloPerUnit, DailyProduction.WhiteChocolatesList[0].KiloPerUnit);
            Warehouse.RowMatterialsQuantity = Warehouse.RowMatterialsQuantity - rowMatterialsUsed;
            //ProductionWarehouse productionWarehouse = new ProductionWarehouse();
              DailyProduction.ChocolatesToProductionWarehouse();
            Console.WriteLine($"After production day: {Warehouse.RowMatterialsQuantity}");
        }

        

        //public override string ToString()
        //{
        //    return ($"Factory Name:{Name}\n\tHas a total of " +
        //        $"{Employees.Count} Employees, and {Warehouse} kilos row material with {Warehouse.RowMatterialQuality} Quality!");
        //}
    }
}
