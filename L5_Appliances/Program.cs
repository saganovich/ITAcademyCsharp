namespace L5_Appliances
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WashMachine washMachine = new WashMachine("Samsung", "WW70A6S23AE/LP", 1500, 800, 42);
            Dishwasher dishwasher = new Dishwasher("Bosch", "SPV4XMX28E", 1000, 500, 10);
            Appliance[] appliances = { washMachine, dishwasher };
            foreach (Appliance appliance in appliances)
            {
                appliance.TurnOn();
                if (appliance.IsBroken)
                {
                    while (appliance.IsBroken)
                    {
                        appliance.Repair();
                    }
                    appliance.TurnOn();
                }
                appliance.Work();
                appliance.TurnOff();
            }

        }
    }
}