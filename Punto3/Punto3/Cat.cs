using System;
using System.Collections.Generic;
using System.Text;

namespace Punto3
{
    class Cat : Subject
    {
        public Cat(string name) : base(name)
        {

        }
        public void Speak(Cat cat)
        {
            Console.WriteLine("Miauuuuuuuuuuu");
            NotifyObs(cat);
        }
    }
}
