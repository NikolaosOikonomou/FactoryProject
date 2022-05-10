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
        public int RowMatterials { get; set; }
        public SupplyOffer[] SupplyOffer { get; set; }
        //public Warehouse(int rowMatterials, SupplyOffer[] supplyOffer)
        //{
        //    RowMatterials = rowMatterials;
        //    SupplyOffer = ;
        //}

        
        
        public void OfferChoice()
        {
            Random rand = new Random();
           // SupplyOffer.SupplyOffers();
            //SupplyService offer = new SupplyService();
           
        }


        public override string ToString()
        {
            return ($"{RowMatterials}");
        }
    }
}
