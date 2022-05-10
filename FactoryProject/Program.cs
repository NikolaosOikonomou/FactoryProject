using FactoryProject.Domains;
using FactoryProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dictionary = CreateEmployee.EmployeeList();

            //foreach (var emp in dictionary)
            //{
            //    Console.WriteLine(emp);
            //}
            FactoryService.Start();
            Console.WriteLine(CreateFactory.Factory());
            //var supplyOffer = SupplyOfferService.SupplyOffers();
            //foreach (var offer in supplyOffer)
            //{
            //    Console.WriteLine(offer);
            //}
            //Console.WriteLine("BEST OFFER LOL------------------------");
            //SupplyOffer bestOffer = Warehouse.BestOffer();
            //Console.WriteLine(bestOffer);


            
        }
    }
}
