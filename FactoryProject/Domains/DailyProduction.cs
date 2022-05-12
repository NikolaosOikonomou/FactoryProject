using FactoryProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject.Domains
{
    class DailyProduction
    {

        public int BlackChocoPerDay { get; set; }
        public int WhiteChocoPerDay { get; set; }
        public int MilkChocoPerDay { get; set; }
        public int TotalProducationPerDay { get; set; }  
        //public ProductionWarehouse ProductionWarehouse { get; set; }
        public List<BlackChocolate> BlackChocolateList { get; set; }
        public List<WhiteChocolate> WhiteChocolatesList { get; set; }
        public List<MilkChocolate> MilkChocolatesList { get; set; } 


        public DailyProduction()
        {
            
            BlackChocoPerDay = 300;
            WhiteChocoPerDay = 100;
            MilkChocoPerDay = 100;
            BlackChocolateList = new List<BlackChocolate>();
            WhiteChocolatesList = new List<WhiteChocolate>();
            MilkChocolatesList = new List<MilkChocolate>();
            TotalProducationPerDay = BlackChocoPerDay + WhiteChocoPerDay + MilkChocoPerDay;
        }

        public void BlackChocoProduction()
        {
            for (int i = 0; i < BlackChocoPerDay; i++)  
            {
                BlackChocolateList.Add(new BlackChocolate());
            }
        }
        public void WhiteChocoProduction()
        {
            for (int i = 0; i < WhiteChocoPerDay; i++)
            {
                WhiteChocolatesList.Add(new WhiteChocolate());
            }
        }
        public void MilkChocoProduction()
        {
            for (int i = 0; i < MilkChocoPerDay; i++)   
            {
                MilkChocolatesList.Add(new MilkChocolate());
            }
        }

        public double DailyRowMaterialsUsed(double blackWeight, double milkWeight, double whiteWeight)
        {
            return blackWeight * BlackChocoPerDay + milkWeight * MilkChocoPerDay + whiteWeight * WhiteChocoPerDay;
        }

        public void ChocolatesToProductionWarehouse()
        {
            ProductionWarehouse productionWarehouse = new ProductionWarehouse();
            for (int i = 0; i < BlackChocolateList.Count / 2; i++)
                productionWarehouse.WarehouseBlackChocolateList.Add(BlackChocolateList[i]);

            for (int i = 0; i < MilkChocolatesList.Count / 2; i++)
                productionWarehouse.WarehouseMilkChocolatesList.Add(MilkChocolatesList[i]);

            for (int i = 0; i < WhiteChocolatesList.Count / 2; i++)
                productionWarehouse.WarehouseWhiteChocolatesList.Add(WhiteChocolatesList[i]);

            //return productionWarehouse;
        }

        //public ProductionWarehouse ProductionWarehouseSupply()
        //{

        //    ProductionWarehouse productionWarehouse = new ProductionWarehouse();
        //    productionWarehouse.WarehouseBlackChocolateList = BlackChocolateList;
        //    productionWarehouse.WarehouseMilkChocolatesList = MilkChocolatesList;
        //    productionWarehouse.WarehouseWhiteChocolatesList = WhiteChocolatesList;

        //    return productionWarehouse;

        //}

    }
}
