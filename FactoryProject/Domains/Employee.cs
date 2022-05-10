using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    enum WorkPosition
    {
        ShopWorker = 1,
        FactoryWorker
    }

    class Employee
    {
        public int WorkId { get; set; }
        public string Name { get; set; }
        public WorkPosition WorkPosition { get; set; }

        public Employee(int workId, string name, WorkPosition workPosition)
        {
            WorkId = workId;
            Name = name;
            WorkPosition = workPosition;
        }


        public override string ToString()
        {

            return ($"WorkID-{ WorkId }:\n\t Name: {Name}, Position: {WorkPosition}");
        }
    }
}
