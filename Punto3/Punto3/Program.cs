using System;

namespace Punto3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat hopkins = new Cat("Hopkins");
            Dog alfred = new Dog("Alfred");
            Canary Tweety = new Canary("Tweety");
            Tweety.See(Tweety, hopkins);
            alfred.Smell(alfred, hopkins);
            hopkins.Speak(hopkins);
        }
    }
}
