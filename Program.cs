using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Program
    {


        

        static void Main(string[] args)
        {
            Order order = new Order(GenerateOrderNumber(), "active");
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
                    Console.WriteLine("Följande beställning har du gjort:");
                    
                    // Går igenom och listar oatmilk 
                    // Hämtar en kopia av listan från klassen order
                    // Det gör att vi slipper gå via orderobjektet och komprimerar koden. 
                    // Riskerar heller inte att ändra något i beställningen
                    List<Oatmilk> oatmilk = order.GetOatmilk();

                    //loopar igenom listan oatmilk. 
                    // Indexerar listan och kör metoden content på varje element i listan. 
                    // Metoden content ligger i varje klass.  
                    for (int i = 0; i < oatmilk.Count; i++)
                    {
                        Console.WriteLine(oatmilk[i].Content());
                    }

                    
                    // Går igenom och listar rör 
                    
                    List<Pipe> pipe = order.GetPipes();

                    for (int i = 0; i < pipe.Count; i++)
                    {
                        Console.WriteLine(pipe[i].Content());

                    }
                    

                    // Går igenom och listar godis 
                    
                    List<Candy> candy = order.GetCandy();
                    
                    for (int i = 0; i < candy.Count; i++)
                    {
                        Console.WriteLine(candy[i].Content());
                    }
                    
                    // Går igenom och listar bilar 
                    
                    List<Car> car = order.GetCars();
                    
                    for (int i = 0; i < car.Count; i++)
                    {
                        Console.WriteLine(car);
                    }

                    break;
                    
                    case 4:
                    //Detta alternativ tar bort en inmatad beställning
                    break;
                    
                    case 5:
                    //Detta alternativ avslutar programmet
                    run = false;
                    Console.Clear();
                    Console.WriteLine("Programmet avslutas. Välkommen åter!");
                    Console.ReadKey();
                    return;

                    default:
                    break;
                }
            }while(run);

            
        }

        public static bool GetInputBool(string input)
        //Metoden tar in en string och gör om den från gemener till versaler.
        //Om första bokstaven är ett "j" returneras boolen false.
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
