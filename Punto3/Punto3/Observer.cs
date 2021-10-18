using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Punto3
{
    class Observer
    {
        public string name;
        public Observer(string name)
        {
            this.name = name;
        }
        public void Notify(Observer observer, Subject subject)
        {
            Console.WriteLine($"{observer.name}  Acaba de escuchar a {subject.name}");
        }
    }
}

