using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryProject;
using FactoryProject.Domains;

namespace FactoryProject.Services
{
    class CreateFactory : Factory
    {
        public static Factory Factory()
        {
            Warehouse warehouse = new Warehouse();
            SupplyOffer bestOffer = Warehouse.BestOffer();
            warehouse.RowMatterials = bestOffer.Quantity;
            warehouse.RowMatterialQuality = bestOffer.RowMatterialQuality;
            DailyProduction dailyProduction = new DailyProduction();
            //dailyProduction.ProductionRowMaterial = warehouse.RowMatterials;
            Factory alimpinisis = new CreateFactory()
            {
                Name = "Alimpinisis AE",
                Employees = CreateEmployee.EmployeeList(),
                Warehouse = warehouse,
                DailyProduction = dailyProduction

            };

            return alimpinisis;
        }

        public override string ToString()
        {
            return ($"Factory Name:{Name}\n\tHas a total of " +
                $"{Employees.Count} Employees, and {Warehouse} kilos row material with {Warehouse.RowMatterialQuality} Quality!" +
                $"\n\tTherefore the dailyproduction line has {DailyProduction.ProductionRowMaterial} kilos of row materials ready" +
                $" to become chocolates!");
        }
    }
}
