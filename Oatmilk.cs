using System;
namespace Multifabriken
{
    class Oatmilk
    {
        private int myVar;
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        
        private int fat;
        public int Fat
        {
            get { return fat; }
            set
            {
                if (value <= 80) { fat = value; }
            }
        }
        public int Amount { get; set; }

        public Oatmilk(int fat, int amount)
        {
            Fat = fat;
            Amount = amount;
        }

        public string Content()
        {
            string str = "Typ Oatmilk " + " | " + "smak: " + Fat + " | " + "mängd: " + Amount;
            return str;
        }
    }

}
