using System;
using System.Collections.Generic;
using System.Text;

namespace Punto3
{
    class Canary : Observer
    {
        public Canary(string name) : base(name)
        {

        }
        public void See(Canary canary, Cat cat)
        {
            cat.RegisterObs(cat, this);
            Console.WriteLine($"{canary.name} Acaba de ver a { cat.name}");
        }
    }
}