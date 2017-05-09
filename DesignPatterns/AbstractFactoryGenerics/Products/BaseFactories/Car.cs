using System;
using DesignPatterns.AbstractFactoryGenerics.Factory.Contracts.FactoryContracts;
using DesignPatterns.AbstractFactoryGenerics.Products.Contracts;

namespace DesignPatterns.AbstractFactoryGenerics.Products.BaseProducts
{
    class Car : IFactory<Car>
    {
        public TProduct Build<TProduct>() where TProduct : IProduct<Car>, new()
        {
            Console.WriteLine("Creating Car: " + typeof(TProduct));
            return new TProduct();
        }
    }
}
