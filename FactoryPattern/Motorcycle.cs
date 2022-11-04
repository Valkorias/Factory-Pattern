using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
            Console.WriteLine("Building a new Motorcycle...");
        }

        public void Drive()
        {
            Console.WriteLine("This motorcycle is now driving!");
        }
    }
}
