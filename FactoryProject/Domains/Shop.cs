using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject.Domains
{
    class Shop
    {
        public List<BlackChocolate> BlackChocolateList { get; set; }
        public List<WhiteChocolate> WhiteChocolateList { get; set; }
        public List<MilkChocolate> MilkChocolateList { get; set; }

        public Shop()
        {
            BlackChocolateList = new List<BlackChocolate>();
            WhiteChocolateList = new List<WhiteChocolate>();
            MilkChocolateList = new List<MilkChocolate>();
        }
    }
}
