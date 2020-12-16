using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    public class Truck: Car, CarAction
    {
        public void Broke()
        {
            Console.WriteLine("Truck broken");
        }

        public void Ride()
        {
            Console.WriteLine("Truck ride");
        }
    }
}
