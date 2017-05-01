using DesignPatterns.AbstractFactoryGenerics.Products.BaseProducts;
using DesignPatterns.AbstractFactoryGenerics.Products.Contracts;
using System;

namespace DesignPatterns.AbstractFactoryGenerics.Products.PartProducts
{
    class Frame<TFactory> : IProduct<Car>, IProduct<Plane>
    {
        public void Operate()
        {
            Console.WriteLine("Operating Frame." + Environment.NewLine);
        }

        public void FrameSpecificOperation()
        {
            Console.WriteLine("Performing Frame-specific operation." + Environment.NewLine);
        }
    }
}
