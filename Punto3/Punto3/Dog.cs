using System;
using System.Collections.Generic;
using System.Text;

namespace Punto3
{
    class Dog : Observer
    {
        public Dog(string name) : base(name)
        {

        }
        public void Smell(Dog dog, Cat cat)
        {
            cat.RegisterObs(cat, this);
            Console.WriteLine($"{dog.name} Acaba de oler {cat.name}");
        }
    }
}
