using System;
namespace Multifabriken 
{
    class Candy
    {
        public string Flavor { get; set; }
        public int Amount { get; set; }

        public Candy(string flavour, int amount)
        {
            Flavor = flavour;
            Amount = amount;
        }

        public string Content()
        {
            string str = "Typ Candy " + " | " + "smak: "  +  Flavor + " | " + "mängd: " + Amount;
            return str;
        }
    }

}
