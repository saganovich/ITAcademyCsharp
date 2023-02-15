using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_Appliances
{
    abstract class Appliance
    {
        private string type;
        private string brand;
        private string model;
        private double pwrCons;
        private decimal recomendPrice;
        private bool isBroken;
        private bool isWorking;
        private double capacity;

        public string Brand
        {
            get => brand;
            private protected set => brand = value;
        }
        public string Model
        {
            get => model;
            private protected set => model = value;
        }
        public double PowerCons
        {
            get => pwrCons;
            private protected set => pwrCons = value;
        }
        public decimal RecPrice
        {
            get => recomendPrice;
            private protected set => recomendPrice = value;
        }
        public bool IsWorking
        {
            get => isWorking;
            private set => isWorking = value;
        }
        public bool IsBroken
        {
            get => isBroken;
            private protected set => isBroken = value;
        }
        public double Capacity
        {
            get => capacity;
            private protected set => capacity = value;
        }
        public string Type
        {
            get => this.type;
            private protected set => this.type = value;
        }
        public void TurnOn()
        {
            if (this.isBroken) { Console.WriteLine($"{type} is broken! Repair needed."); }
            else if (this.IsWorking) { Console.WriteLine($"{type} is already running."); }
            else { Console.WriteLine($"{type} turned on."); IsWorking = true; }
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
                bool repairResult = RandomBool.Get(3);
                if (repairResult) { Console.WriteLine("Success!"); IsBroken = false; }
                else { Console.WriteLine("Fail! Please try again."); }
            }
        }
        public abstract void Work();
    }
}
