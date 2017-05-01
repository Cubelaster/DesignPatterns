using DesignPatterns.AbstractFactory.Carnivores;
using DesignPatterns.AbstractFactory.Factories;
using DesignPatterns.AbstractFactory.Herbivores;

namespace DesignPatterns.AbstractFactory.Implementation
{
    /// <summary>
    /// This class serves as an implementation of the Factory logic.
    /// Depending on the Factory the use-case is using, the preset Carnivore and Herbivore are
    /// selected and the food chain is run.
    /// </summary>
    class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        public AnimalWorld(ContinentFactory factory)
        {
            _carnivore = factory.CreateCarnivore();
            _herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}
