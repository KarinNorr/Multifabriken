using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Order
    {
        List<Oatmilk> oatmilks = new List<Oatmilk>(); 
        List<Car> cars = new List<Car>(); 
        List<Candy> sweets = new List<Candy>(); 
        List<Pipe> pipes = new List<Pipe>(); 

        public Order(int orderNumber, string status)
        {   
                this.orderNumber = orderNumber;
                this.status = status;
        }   

        int orderNumber = 0;
        string status;

        public List<Oatmilk> GetOatmilk()
        {
            return oatmilks;
        }      
        
        public List<Car> GetCars()
        {
            return cars;
        }
        //Metod för att tömma listorna
        
        public List<Candy> GetCandy()
        {
            return sweets;
        }

        public List<Pipe> GetPipes()
        {
            return pipes;
        }
        public void AddCandy(string flavour, int weight)
        {
            Candy candy = new Candy(flavour, weight);
            sweets.Add(candy);
        }
        public void AddCar(string color, string model, bool fancy)
        {
            Car car = new Car(color, model, fancy);
            cars.Add(car);
        }
        public void AddPipe(int length, int diameter, string material)
        {
            Pipe pipe = new Pipe(length, diameter, material);
            pipes.Add(pipe);
        }
        public void AddOatmilk(int fatPercentage, int amountInLiters)
        {
            Oatmilk oatmilk = new Oatmilk(fatPercentage, amountInLiters);
            oatmilks.Add(oatmilk);
        }
        public void ClearList(Order order, int listSelect)
        {
             switch (listSelect)
             {
                 //Tömmer godislistan
                 case 1:
                 sweets.Clear();
                 break;

                 //Tömmer billistan
                 case 2:
                 cars.Clear(); 
                 break;

                 //Tömmer rörlistan
                 case 3:
                 pipes.Clear(); 
                 break;

                 //Tömmer havremjölkslistan
                 case 4:
                 oatmilks.Clear(); 
                 break;
                
                 //Tömmer alla listor
                 
                

                 default:
                 break;
             }
        }
    }
}

            

        


