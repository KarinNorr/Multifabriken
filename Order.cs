using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Order
    {
        List<Oatmilk> oatmilk = new List<Oatmilk>(); 
        List<Car> cars = new List<Car>(); 
        List<Candy> candy = new List<Candy>(); 
        List<Pipe> pipes = new List<Pipe>(); 

        Customer customer = new Customer();

        int orderNumber = 0;
        string status;

        public Order(int orderNumber, string status)
        {
            this.orderNumber = orderNumber;
            this.status = status;
        }
        //Metod för att tömma listorna
        public void ClearList(Order order)
        {
             switch (listSelect)
             {
                 //Tömmer godislistan
                 case 1:
                 candy.Clear();
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
                 oatmilk.Clear(); 
                 break;
                
                 //Tömmer alla listor
                 case 5:
                 for (int i =)
                 break;

                 default:
                 break;
             }




        }
        


    }
}
