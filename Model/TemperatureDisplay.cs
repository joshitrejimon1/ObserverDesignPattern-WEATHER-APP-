using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Model
{
    internal class TemperatureDisplay:IObserver
    {
        public void Update(string temperature, string humidity)
        {
            Console.WriteLine($"Temperature Display: Current Temperature is {temperature}°C");
        }
    }
}
