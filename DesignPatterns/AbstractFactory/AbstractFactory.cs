using DesignPatterns.AbstractFactory.Factories;
using DesignPatterns.AbstractFactory.Implementation;
using System;

namespace DesignPatterns.AbstractFactory
{
    /// <summary>
    /// Abstract Factory is designed to create families of related or dependent objects by using interfaces and classes to defer the actual creation of concrete products in the concrete factory subclasses.
    /// </summary>
    static class AbstractFactory
    {
        public static void Run()
        {
            Console.WriteLine("First showcase is the AbstractFactory design pattern.");
            Console.WriteLine("The AbstractFactory is the entry point for creating entities." + Environment.NewLine
                + "This is an abstract class that only declares methods for creating entities.");
            Console.WriteLine("Abstract factory is implemented through a number of child factories which implement the " + Environment.NewLine
                + "specific methods for instantiating entities. In this case the African and American factories.");
            Console.WriteLine("Carnivore and Herbivore are abstract classes demanding specific implementations for animals. " + Environment.NewLine
                + "Carnivore also has a method that has to be implemented in child class and it uses herbivore from factory.");
            Console.WriteLine("All of that is used in AnimalWorld class. For an instance of the class the different animals are created." + Environment.NewLine);

            AnimalWorld animalsOfAfrica = new AnimalWorld(new AfricaFactory());
            AnimalWorld animalsOfAmerica = new AnimalWorld(new AmericaFactory());

            Console.WriteLine("African animals behave:");
            animalsOfAfrica.RunFoodChain();
            Console.WriteLine();

            Console.WriteLine("American animals behaver:");
            animalsOfAmerica.RunFoodChain();
            Console.WriteLine();
        }
    }
}
