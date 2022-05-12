using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class MilkChocolate
    {
        public double KiloPerUnit { get; set; }
        public double PricePerUnit { get; set; }

        public MilkChocolate()
        {
            KiloPerUnit = 0.07;
            PricePerUnit = 1.2;
        }
    }
}
