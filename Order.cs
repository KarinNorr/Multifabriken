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

        public Order(int orderNumber, string status)
        {   
                this.orderNumber = orderNumber;
                this.status = status;
        }   

        int orderNumber = 0;
        string status;

        public List<Oatmilk> GetOatmilk()
        {
            return oatmilk;
        }      
        
        public List<Car> GetCars()
        {
            return cars;
        }
     

        public List<Candy> GetCandy()
        {
            return candy;
        }

        public List<Pipe> GetPipes()
        {
            return pipes;
        }
    }
}

            

        


