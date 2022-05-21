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
        public ProductionWarehouse ProductionWarehouse { get; set; }
        public List<BlackChocolate> BlackChocolateList { get; set; }
        public List<WhiteChocolate> WhiteChocolatesList { get; set; }
        public List<MilkChocolate> MilkChocolatesList { get; set; }
        

        public DailyProduction()
        {
            BlackChocoPerDay = 300;
            WhiteChocoPerDay = 100;
            MilkChocoPerDay = 100;
            ProductionWarehouse = new ProductionWarehouse();
            BlackChocolateList = new List<BlackChocolate>();
            WhiteChocolatesList = new List<WhiteChocolate>();
            MilkChocolatesList = new List<MilkChocolate>();
            TotalProducationPerDay = BlackChocoPerDay + WhiteChocoPerDay + MilkChocoPerDay;
        }

        public void ChocolatesProduction()
        {
            for (int i = 0; i < BlackChocoPerDay; i++)  
                BlackChocolateList.Add(new BlackChocolate());

            for (int i = 0; i < WhiteChocoPerDay; i++)
                WhiteChocolatesList.Add(new WhiteChocolate());

            for (int i = 0; i < MilkChocoPerDay; i++)
                MilkChocolatesList.Add(new MilkChocolate());
        }
    
        public double DailyRowMaterialsUsed(double blackWeight, double milkWeight, double whiteWeight)
        {
            return blackWeight * BlackChocoPerDay + milkWeight * MilkChocoPerDay + whiteWeight * WhiteChocoPerDay;
        }

        public void ChocolatesToProductionWarehouseAndShop(ProductionWarehouse productionWarehouse, ShopWarehouse shopWarehouse)
        {
            
            for (int i = 0; i < BlackChocolateList.Count ; i++)
            {
                if (i <= (BlackChocolateList.Count / 2) - 1)
                    productionWarehouse.WarehouseBlackChocolateList.Add(BlackChocolateList[i]);
                else
                    shopWarehouse.ShopBlackChocolateList.Add(BlackChocolateList[i]);
            }
            for (int i = 0; i < MilkChocolatesList.Count; i++)
            {
                if (i <= (MilkChocolatesList.Count / 2) - 1)
                    productionWarehouse.WarehouseMilkChocolatesList.Add(MilkChocolatesList[i]);
                else
                    shopWarehouse.ShopMilkChocolateList.Add(MilkChocolatesList[i]);
            }
            for (int i = 0; i < WhiteChocolatesList.Count; i++)
            {
                if (i <= (WhiteChocolatesList.Count / 2) - 1)
                    productionWarehouse.WarehouseWhiteChocolatesList.Add(WhiteChocolatesList[i]);
                else
                    shopWarehouse.ShopWhiteChocolateList.Add(WhiteChocolatesList[i]);
            }
          
        }

        public void ChocolatesToProductionWarehouse(ProductionWarehouse productionWarehouse)
        {
            for (int i = 0; i < BlackChocolateList.Count; i++)
                productionWarehouse.WarehouseBlackChocolateList.Add(BlackChocolateList[i]);
            
            for (int i = 0; i < WhiteChocolatesList.Count; i++)
                productionWarehouse.WarehouseWhiteChocolatesList.Add(WhiteChocolatesList[i]);
            
            for (int i = 0; i < MilkChocolatesList.Count; i++)
                productionWarehouse.WarehouseMilkChocolatesList.Add(MilkChocolatesList[i]);
        }
    }
}
