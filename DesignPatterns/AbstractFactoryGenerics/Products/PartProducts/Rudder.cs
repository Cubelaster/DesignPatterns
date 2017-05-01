using DesignPatterns.AbstractFactoryGenerics.Products.BaseProducts;
using DesignPatterns.AbstractFactoryGenerics.Products.Contracts;
using System;

namespace DesignPatterns.AbstractFactoryGenerics.Products.PartProducts
{
    class Rudder : IProduct<Plane>
    {
        public void Operate()
        {
            Console.WriteLine("Operating Rudder." + Environment.NewLine);
        }

        public void RudderSpecificOperation()
        {
            Console.WriteLine("Performing Rudder-specific operation." + Environment.NewLine);
        }
    }
}
