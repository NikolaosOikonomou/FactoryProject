﻿using System;
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

        public static SupplyOffer[] SupplyOffers()
        {
            Random rand = new Random();
            SupplyOffer[] offers = new SupplyOffer[3];
            for (int i = 0; i < 3; i++)
            {
                offers[i] = new SupplyOffer(rand.Next(4500, 5000), rand.Next(1, 3), (RowMatterialQuality)rand.Next(1, 4));
            }
            return offers;
        }
    }
}