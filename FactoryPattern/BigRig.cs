using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class BigRig : IVehicle
    {
        public BigRig()
        {
            Console.WriteLine("Building a new Big Rig...");
        }

        public void Drive()
        {
            Console.WriteLine("This Big Rig is hauling food!");
        }
    }

}
