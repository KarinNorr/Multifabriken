using System;

namespace Multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej och välkommen till Multifabriken");
            Console.ReadKey();
            Console.WriteLine("Du får här 5 alternativ att välja mellan");
            Console.WriteLine("1: Se hela produktutbudet");
            Console.WriteLine("2: Gör en beställning");
            Console.WriteLine("3: Se hela din beställning");
            Console.WriteLine("4: Ta bort en produkt från din beställning");
            Console.WriteLine("5: Avsluta programmet");

            Console.WriteLine("Nu kan du göra ditt val:");
            int nr = Convert.ToInt32(Console.ReadLine());
            
            switch (nr)
            {
                case 1:
                break;

                case 2:
                break;
                
                case 3:
                break;
                
                case 4:
                break;
                
                case 5:
                break;

                default:
                break;
            }

            
        }
        public static int GetInt()
        {
                int number = 0;
                bool loop = true;
                do
                {
                    try
                    {
                        number = Convert.ToInt32(Console.ReadLine());
                        loop = false;
                    }
                    catch
                    {
                        Console.WriteLine("Du kan endast fylla i heltal.");
                    }

                }while(loop);
                return number;
        }
    }
}
