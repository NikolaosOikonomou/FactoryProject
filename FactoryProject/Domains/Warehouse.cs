using FactoryProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject.Domains
{
    class Warehouse
    {
        public double RowMatterialsQuantity { get; set; }
        public RowMatterialQuality RowMatterialQuality { get; set; }
       
        public static SupplyOffer BestOffer()
        {
            SupplyOffer[] offers = SupplyOfferService.SupplyOffers();
            SupplyOffer bestOffer = offers[0];
            for (int i = 1; i < 3; i++)
            {
                if (offers[i].PricePerKilo <= bestOffer.PricePerKilo)
                {
                    if (offers[i].OfferQuantity > bestOffer.OfferQuantity)
                    {
                        bestOffer = offers[i];
                    }
                }  
            }
            return bestOffer;
        }



        public override string ToString()
        {
            return ($"{RowMatterialsQuantity}");
        }
    }
}
