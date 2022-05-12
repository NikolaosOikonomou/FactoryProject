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
        public Factory Factory { get; set; }
        public Shop Shop { get; set; }

        public Company()
        {
            Factory = new Factory();
            Shop = new Shop();
        }

        public void Start()
        { 
            Factory.NewFactory();
            Factory.WorkingDay();
            Console.ReadKey();
            //DailyProduction dailyProduction = new DailyProduction();
            //dailyProduction.ChocolatesToProductionWarehouse();

            //Factory.DailyProduction.MilkChocolatesList.Clear();
            //Factory.DailyProduction.WhiteChocolatesList.Clear();
            //Factory.DailyProduction.BlackChocolateList.Clear();
        }



        public override string ToString()
        {
            return ($"Factory Name:{Factory.Name}\n\tHas a total of " +
                $"{Factory.Employees.Count} Employees, and {Factory.Warehouse} kilos row material " +
                $"with {Factory.Warehouse.RowMatterialQuality} Quality!" +
                $"\nDailyProduction\t BlackChoco:{Factory.DailyProduction.BlackChocolateList.Count}" +
                $"             \n\t\t WhiteChoco: {Factory.DailyProduction.MilkChocolatesList.Count}" +
                $"             \n\t\t MilkChoco: {Factory.DailyProduction.MilkChocolatesList.Count}");
        }
    }
}
