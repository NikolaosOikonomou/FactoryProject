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
        public int KiloPerUnit { get; set; }
        public float PricePerUnit { get; set; }
        public Type Type { get; set; }
    }
}
