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
        public double ProductionRowMaterial { get; set; }  


        public DailyProduction()
        {
            BlackChocoPerDay = 300;
            WhiteChocoPerDay = 100;
            MilkChocoPerDay = 100;
            TotalProducationPerDay = BlackChocoPerDay + WhiteChocoPerDay + MilkChocoPerDay;
        }

    }
}
