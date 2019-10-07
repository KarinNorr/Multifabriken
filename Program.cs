using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Program
    {

        List<Customer> customers = new List<Customer>();

        

        static void Main(string[] args)
        {
            bool createOrder = false;
            bool run = true;

            do
            {   
                Console.Clear();
                //Välkomsttext
                Console.WriteLine("Hej och välkommen till Multifabriken\n");
                //Console.ReadKey();
                Console.WriteLine("Du får här 5 alternativ att välja mellan");
                Console.WriteLine("1: Se hela produktutbudet");
                Console.WriteLine("2: Gör en beställning");
                Console.WriteLine("3: Se hela din beställning");
                Console.WriteLine("4: Ta bort en produkt från din beställning");
                Console.WriteLine("5: Avsluta programmet");

                Console.Write("Nu kan du göra ditt val: ");
                //Tar emot användarens menyval.
                int nr = Convert.ToInt32(Console.ReadLine());
                
                //Switch över huvudmenyn
                switch (nr)
                {
                    case 1:
                    //Här ska hela sortimentet skrivas ut
                    Console.Clear();
                    Console.WriteLine("Multifabriken producerar bilar, rör, havremjölk och godis,");
                
                    Console.WriteLine("Bilar i X olika färger, X modeller. Du kan addera lyxpaket till alla varianter.");
                    Console.WriteLine("Rör finns i valfri diameter och i X antal material. Du väljer själv längden.");
                    Console.WriteLine("Havremjölk med valfri fetthalt och mängd.\n");
                    Console.Write("Tryck på valfri tangent för att återgå till huvudmenyn.");
                    Console.ReadKey();
                    break;

                    case 2:
                    //Här ska kunden kunna göra sin beställning
                    createOrder = true;
                    Console.WriteLine("Skriv in din beställning här genom att välja produkt:");
                    Console.WriteLine("[1] Bil");
                    Console.WriteLine("[2] Rör");
                    Console.WriteLine("[3] Havremjölk");
                    Console.WriteLine("[4] Godis");
                    Console.Write(">>");

                    do
                    {
                        int productSelected = GetInt();
                        
                        switch (productSelected)
                        {
                            case 1:
                            Console.WriteLine("Välj bilens egenskaper:");
                            Console.Write("Färg: ");
                            string color = Console.ReadLine();
                            Console.WriteLine("Tillgängliga modeller >");
                            Console.Write("Modell: ");
                            string model = Console.ReadLine();
                            Console.Write("Lyx [Ja/Nej]: ");
                            bool fancy = GetInputBool(Console.ReadLine());
                            
                            break;
                            case 2:

                            break;
                            case 3:
                            break;
                            case 4:
                            break;
                            default:
                            Console.WriteLine("Fel vid inmatning");
                            break;
                        }

                    }while(createOrder);


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
                    run = false;
                    Console.Clear();
                    Console.WriteLine("Programmet avslutas. Välkommen åter!");
                    return;

                    default:
                    break;
                }
            }while(run);

            
        }

        public static bool GetInputBool(string input)
        {
            string lowerCaseInput = input.ToLower();
            if (lowerCaseInput[0] == 'j') { return true; }
            
            else { return false; }
        }

        
        
        public static int GetInt()
        //Funktion som tar in en string, konverterar den till en int och returnerar den.
        //Innehåller en do-while-loop som kör en try/catch.
        //Om användaren skriver in något annat än ett heltal får man försöka. 
        {
            int number = 0;
            bool loopOne = true;
            do
            {
                try
                    {
                        number = Convert.ToInt32(Console.ReadLine());
                        loopOne = false;
                    }
                    catch
                    {
                        Console.WriteLine("Du kan endast fylla i heltal.");
                    }

            }while(loopOne);
            return number;
        }
        
    }
}
