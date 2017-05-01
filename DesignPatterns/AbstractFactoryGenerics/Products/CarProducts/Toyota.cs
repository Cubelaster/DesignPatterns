using DesignPatterns.AbstractFactoryGenerics.Products.BaseProducts;
using DesignPatterns.AbstractFactoryGenerics.Products.Contracts;
using System;

namespace DesignPatterns.AbstractFactoryGenerics.Products.CarProducts
{
    class Toyota : IProduct<Car>
    {
        public void Operate()
        {
            Console.WriteLine("Driving Toyota." + Environment.NewLine);
        }

        public void ToyotaSpecificOperation()
        {
            Console.WriteLine("Performing Toyota-specific operation." + Environment.NewLine);
        }
    }
}
