using System;
using DesignPatterns.AbstractFactoryGenerics.Factory.Contracts.FactoryContracts;
using DesignPatterns.AbstractFactoryGenerics.Products.Contracts;

namespace DesignPatterns.AbstractFactoryGenerics.Products.BaseProducts
{
    /// <summary>
    /// Plane is a type of Factory.
    /// This is visible by the IFactory using the Generic of a Plane.
    /// It's definition states that it can Build any kind of product that derives from Plane.
    /// </summary>
    class Plane : IFactory<Plane>
    {
        public TProduct Build<TProduct>() where TProduct : IProduct<Plane>, new()
        {
            Console.WriteLine("Creating Plane: " + typeof(TProduct));
            return new TProduct();
        }
    }
}
