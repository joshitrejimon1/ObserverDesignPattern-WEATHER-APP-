using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Model
{
    internal interface IObserver
    {
        void Update(string temperature, string humidity);
    }
}
