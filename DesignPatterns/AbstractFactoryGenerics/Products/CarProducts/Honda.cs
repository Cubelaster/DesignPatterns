using DesignPatterns.AbstractFactoryGenerics.Products.BaseProducts;
using DesignPatterns.AbstractFactoryGenerics.Products.Contracts;
using System;

namespace DesignPatterns.AbstractFactoryGenerics.Products.CarProducts
{
    class Honda : IProduct<Car>
    {
        public void Operate()
        {
            Console.WriteLine("Driving Honda." + Environment.NewLine);
        }

        public void HondaSpecificOperation()
        {
            Console.WriteLine("Performing Honda-specific operation." + Environment.NewLine);
        }
    }
}
