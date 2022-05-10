using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject.Domains
{
    enum RowMatterialQuality
    {
        A = 1,
        B,
        C
    }
    class SupplyOffer
    {
        public double Quantity { get; set; }
        public double PricePerKilo { get; set; }
        public RowMatterialQuality RowMatterialQuality { get; set; }

        public SupplyOffer()
        {

        }

        public SupplyOffer(double quantity, double pricePerKilo, RowMatterialQuality rowMatterialQuality)
        {
            Quantity = quantity;
            PricePerKilo = pricePerKilo;
            RowMatterialQuality = rowMatterialQuality;
        }

        public override string ToString()
        {
            return ($"Season best offer: Quantity {Quantity} Price per kilo {PricePerKilo} and Quality {RowMatterialQuality}");
        }

    }
}
