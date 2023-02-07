using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_Appliances
{
    abstract class Appliances
    {
        private protected string type;
        private protected string brand;
        private protected string model;
        private protected double pwrCons;
        private protected decimal recomendPrice;
        private protected bool isBroken;
        private protected bool isWorking;
        private protected double capacity;

        public string Brand => brand;
        public string Model => model;
        public double PowerCons => pwrCons;
        public decimal RecPrice => recomendPrice;
        public bool IsWorking => isWorking;
        public bool IsBroken => isBroken;
        public double Capacity => capacity;
        public string Type => type;
        public void TurnOn()
        {
            if (this.isBroken) { Console.WriteLine($"{type} is broken! Repair needed."); }
            else if (this.isWorking) { Console.WriteLine($"{type} is already running."); }
            else { Console.WriteLine($"{type} turned on."); isWorking = true; }
        }
        public void TurnOff()
        {
            if (this.isWorking) { Console.WriteLine($"{type} turned off."); }
            else { Console.WriteLine($"{type} is already off"); }
        }
        public void Repair()
        {
            if (!this.isBroken) { Console.WriteLine($"{type} is OK"); }
            else
            {
                Console.Write("Trying to repair..");
                Random rnd = new Random();
                bool repairResult = rnd.Next(3) == 1;
                if (repairResult) { Console.WriteLine("Success!"); isBroken = false; }
                else { Console.WriteLine("Fail! Please try again."); }
            }
        }
        public abstract void Work();
    }
}
