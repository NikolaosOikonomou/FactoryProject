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
            Console.WriteLine(company);
            
        }
    }
}
