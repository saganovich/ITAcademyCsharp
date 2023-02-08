using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_Appliances
{
    internal class WashMachine : Appliance
    {
        public WashMachine(string brand, string model, double powerCons, decimal recomendedPrice,double capacity)
        {
            this.Type = "Washing machine";
            this.Brand = brand;
            this.Model = model;
            this.PowerCons = powerCons;
            this.RecPrice = recomendedPrice;
            this.Capacity= capacity;
            Random rnd = new Random();
            this.IsBroken = rnd.Next(2) == 1;
        }
        public override void Work()
        {
            Console.WriteLine($"{this.Type} washing clothes.");
        }
    }
}
