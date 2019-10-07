using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Program
    {


        

        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>();
            bool createOrder = false;
            bool run = true;

            do
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
                    Order order = new Order(GenerateOrderNumber(), "active");
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

                            // Lägger till bil.
                            case 1:

                            Console.WriteLine("Lägger till bil i beställning:");
                            Console.WriteLine("Välj bilens egenskaper:");
                            Console.Write("Färg: ");
                            string color = Console.ReadLine();
                            Console.WriteLine("Tillgängliga modeller >");
                            Console.Write("Modell: ");
                            string model = Console.ReadLine();
                            Console.Write("Lyx [Ja/Nej]: ");
                            bool fancy = GetInputBool(Console.ReadLine());
                            
                            order.AddCar(color, model, fancy);

                            orders.Add(order);
                            
                            
                            break;

                            // Lägg till rör.
                            case 2:
                            Console.WriteLine("Lägger till rör beställning:");
                            Console.Write("Längd: ");
                            int length = GetInt();
                            Console.Write("Diameter: ");
                            int diameter = GetInt();
                            Console.Write("Material [Metall/Plast/Betong]: ");
                            string material = Console.ReadLine();

                            order.AddPipe(length, diameter, material);

                            break;

                            // Lägg till havremjölk.
                            case 3:
                            Console.WriteLine("Lägger till havremjölk i beställning:");
                            Console.Write("Fetthalt: ");
                            int fatPercentage = GetInt();
                            Console.Write("Mängd i liter: ");
                            int amountInLiters = GetInt();
                            order.AddOatMilk(fatPercentage, amountInLiters);
                            break;

                            // Lägger till godis.
                            case 4:
                            Console.WriteLine("Lägger till godis i beställning:");
                            Console.Write("Smak: ");
                            string flavour = Console.ReadLine();
                            Console.Write("Vikt i Hg: ");
                            int weight = GetInt();
                            order.AddCandy(flavour, weight);
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
                    Console.WriteLine("Programmet avslutas. Välkommen åter!");
                    Console.ReadKey();
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
        //Om användaren skriver in något annat än ett heltal får man försöka igen. 
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
