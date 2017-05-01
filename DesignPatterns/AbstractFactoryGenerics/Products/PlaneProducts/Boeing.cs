using DesignPatterns.AbstractFactoryGenerics.Products.BaseProducts;
using DesignPatterns.AbstractFactoryGenerics.Products.Contracts;
using System;

namespace DesignPatterns.AbstractFactoryGenerics.Products.PlaneProducts
{
    class Boeing : IProduct<Plane>
    {
        public void Operate()
        {
            Console.WriteLine("Flying Boeing." + Environment.NewLine);
        }

        public void BoeingSpecificOperation()
        {
            Console.WriteLine("Performing Boeing-specific operation." + Environment.NewLine);
        }
    }
}
