using DesignPatterns.AbstractFactoryGenerics.Products.Contracts;
using System;

namespace DesignPatterns.AbstractFactoryGenerics.Products.PartProducts
{
    class Engine<TFactory> : IProduct<TFactory>
    {
        public void Operate()
        {
            Console.WriteLine("Operating engine!" + Environment.NewLine);
        }

        public void EngineSpecificOperation()
        {
            Console.WriteLine("Performing engine-specific operation" + Environment.NewLine);
        }
    }
}
