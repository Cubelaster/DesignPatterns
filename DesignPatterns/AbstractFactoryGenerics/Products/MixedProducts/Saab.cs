using DesignPatterns.AbstractFactoryGenerics.Products.BaseProducts;
using DesignPatterns.AbstractFactoryGenerics.Products.Contracts;
using System;

namespace DesignPatterns.AbstractFactoryGenerics.Products.MixedProducts
{
    class Saab : IProduct<Car>, IProduct<Plane>
    {
        public void Operate()
        {
            Console.WriteLine("Operating Saab." + Environment.NewLine);
        }

        public void SaabSpecificOperation()
        {
            Console.WriteLine("Performing Saab-specific operation." + Environment.NewLine);
        }
    }
}
