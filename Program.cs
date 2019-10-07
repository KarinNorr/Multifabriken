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
                //Här ska hela sortimentet skrivas ut
                Console.WriteLine("Multifabriken producerar bilar, rör, havremjölk och godis,");              
                Console.WriteLine("Bilar i X olika färger, X modeller. Du kan addera lyxpaket till alla varianter.");
                Console.WriteLine("Rör finns i valfri diameter och i X antal material. Du väljer själv längden.");
                Console.WriteLine("Havremjölk med valfri fetthalt och mängd.");
                break;

                case 2:
                //Här ska kunden kunna göra sin beställning
                Console.WriteLine("Skriv in din beställning här:");
                Console.ReadKey();
                //vi ska spara in beställningen som ett objekt ur sin klass och in i korrekt lista
                break;

                
                case 3:
                //Här kan kunden få hela sin beställning utskriven
                break;
                
                case 4:
                //Detta alternativ tar bort en inmatad beställning
                break;
                
                case 5:
                //Detta alternativ avslutar programmet
                Console.WriteLine("Programmet avslutas. Välkommen åter!");
                return;

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
