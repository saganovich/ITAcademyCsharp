using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_Appliances
{
    internal class WashMachine : Appliances
    {
        public WashMachine(string brand, string model, double powerCons, decimal recomendedPrice,double capacity)
        {
            this.type = "Washing machine";
            this.brand = brand;
            this.model = model;
            this.pwrCons = powerCons;
            this.recomendPrice = recomendedPrice;
            this.capacity = capacity;
            Random rnd = new Random();
            this.isBroken = rnd.Next(2) == 1;
        }
        public override void Work()
        {
            Console.WriteLine($"{type} washing clothes.");
        }
    }
}
