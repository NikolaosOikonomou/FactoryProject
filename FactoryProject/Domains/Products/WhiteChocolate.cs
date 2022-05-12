using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    enum Type
    {
        White,
        WhiteWithAlmond,
        WhiteWithHazel
    }
    class WhiteChocolate
    {
        public double KiloPerUnit { get; set; }
        public double PricePerUnit { get; set; }
        public Type Type { get; set; }

        public WhiteChocolate()
        {
            KiloPerUnit = 1.1;
            PricePerUnit = 1.3;
        }
    }
}
