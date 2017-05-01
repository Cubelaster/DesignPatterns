using DesignPatterns.AbstractFactory.Herbivores;
using System;

namespace DesignPatterns.AbstractFactory.Carnivores
{
    class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }
}