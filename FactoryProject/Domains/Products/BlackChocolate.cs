using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class BlackChocolate
    {
        public double KiloPerUnit { get; set; }
        public double PricePerUnit { get; set; }

        public BlackChocolate()
        {
            KiloPerUnit = 0.05;
            PricePerUnit = 1.1;
        }
    }
}
