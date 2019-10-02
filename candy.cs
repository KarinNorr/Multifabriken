using System;
namespace Multifabriken 
{
    class Candy
    {
        public int Flavor { get; set; }
        public int Amount { get; set; }

        public string Content()
        {
            string str = "Typ Candy " + " | " + "smak: "  +  Flavor + " | " + "mängd: " + Amount;
            return str;
        }
    }

}