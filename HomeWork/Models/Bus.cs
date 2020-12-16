using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    public class Bus: Car, CarAction
    {
        public void Broke()
        {
            Console.WriteLine("Bus broken");
        }

        public void Ride()
        {
            Console.WriteLine("Bus ride");
        }
    }
}
