using DesignPatterns.AbstractFactory.Herbivores;

namespace DesignPatterns.AbstractFactory.Carnivores
{
    abstract class Carnivore
    {
        public abstract void Eat(Herbivore h);
    }
}