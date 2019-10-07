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
        public void AddCar(string color, string model, bool fancy)
        {
            Car car = new Car(color, model, fancy);
            cars.Add(car);
        }
        public void AddCandy(string flavour, int weight)
        {
            Candy candy = new Candy(flavour, weight);
            candy.Add(candy);
        }
        public void AddPipe(int length, int diameter, string material)
        {
            Pipe pipe = new Pipe(length, diameter, material);
            pipes.Add(pipe);
        }
        public void AddOatMilk(int fatPercentage, int amountInLiters)
        {
            Oatmilk oatmilk = new Oatmilk(fatPercentage, amountInLiters);
            oatmilk.Add(oatmilk);
        }


    }
}
