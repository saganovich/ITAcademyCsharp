using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_Appliances
{
    internal class Dishwasher : Appliance
    {
        public Dishwasher(string brand, string model, double powerCons, decimal recomendedPrice, double capacity)
        {
            this.Type = "Dishwasher";
            this.Brand = brand;
            this.Model = model;
            this.PowerCons = powerCons;
            this.RecPrice = recomendedPrice;
            this.Capacity = capacity;
            this.IsBroken = RandomBool.Get(4);
        }
        public override void Work()
        {
            Console.WriteLine($"{this.Type} machine washing dishes.");
        }
    }
}
