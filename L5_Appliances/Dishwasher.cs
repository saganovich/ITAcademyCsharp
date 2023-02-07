using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_Appliances
{
    internal class Dishwasher : Appliances
    {
        public Dishwasher(string brand, string model, double powerCons, decimal recomendedPrice, double capacity)
        {
            this.type = "Dishwasher";
            this.brand = brand;
            this.model = model;
            this.pwrCons = powerCons;
            this.recomendPrice = recomendedPrice;
            this.capacity = capacity;
            Random rnd = new Random();
            this.isBroken = rnd.Next(4) == 1;
        }
        public override void Work()
        {
            Console.WriteLine($"{type} machine washing dishes.");
        }
    }
}
