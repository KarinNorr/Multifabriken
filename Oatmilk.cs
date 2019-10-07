using System;
namespace Multifabriken 
{
    class Oatmilk
    {
        public int Fat { get; set; }
        public int Amount { get; set; }

        public Oatmilk(int fat, int amount)
        {
            Fat = fat;
            Amount = amount;
        }

        public string Content()
        {
            string str = "Typ Oatmilk " + " | " + "smak: "  +  Fat + " | " + "mängd: " + Amount;
            return str;
        }
    }

}
