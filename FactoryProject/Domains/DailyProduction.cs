using FactoryProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject.Domains
{
    /// <summary>
    /// Produce the chocolates.Calculates the raw materials used and distributes the chocolates to the
    /// production warehouse and to the Shop.
    /// </summary>
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

        /// <summary>
        /// Chocolates production per day
        /// </summary>
        public void ChocolatesProduction()
        {
            for (int i = 0; i < BlackChocoPerDay; i++)  
                BlackChocolateList.Add(new BlackChocolate());

            for (int i = 0; i < WhiteChocoPerDay; i++)
                WhiteChocolatesList.Add(new WhiteChocolate());

            for (int i = 0; i < MilkChocoPerDay; i++)
                MilkChocolatesList.Add(new MilkChocolate());
        }
    

        /// <summary>
        /// Calculates the total raw materials used per day
        /// </summary>
        /// <param name="blackWeight"></param>
        /// <param name="milkWeight"></param>
        /// <param name="whiteWeight"></param>
        /// <returns></returns>
        public double DailyRowMaterialsUsed(double blackWeight, double milkWeight, double whiteWeight)
        {
            return blackWeight * BlackChocoPerDay + milkWeight * MilkChocoPerDay + whiteWeight * WhiteChocoPerDay;
        }

        /// <summary>
        /// The first day this method will be called.Destributes the chocolates to prodution warehouse
        /// and to the Shop
        /// </summary>
        /// <param name="productionWarehouse"></param>
        /// <param name="shopWarehouse"></param>
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


        /// <summary>
        /// After first day using this method.Distributes the chocolates to production warehouse
        /// </summary>
        /// <param name="productionWarehouse"></param>
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
