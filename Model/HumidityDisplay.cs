using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Model
{
    internal class HumidityDisplay:IObserver
    {
        public void Update(string temperature, string humidity)
        {
            Console.WriteLine($"Humidity Display: Current Humidity is {humidity}%");
        }
    }
}
