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


    }
}