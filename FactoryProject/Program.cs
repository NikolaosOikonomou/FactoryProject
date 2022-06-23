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

            Company company = new Company();
            company.Start();
           

            //The Company will be  created
            //Three random raw material offers will be created
            //The Factory's warehouse will choose the best offer
            //The next steps representing a production day :
            //1.Chocolate will be created and distributes to the Factory's shop's warehouse
            //2.Checking the raw material quntity.Order more if needed
            //3.Shop will sell the products,checks for resupplies
            //4.Checks if a new shop can be creted based on the stored products(refering to blackchocolates)
            
        }
    }
}
