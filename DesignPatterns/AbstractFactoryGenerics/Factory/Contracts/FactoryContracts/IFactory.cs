using DesignPatterns.AbstractFactoryGenerics.Products.Contracts;

namespace DesignPatterns.AbstractFactoryGenerics.Factory.Contracts.FactoryContracts
{
    /// <summary>
    /// Base Factory class defining the method for product creation.
    /// That will be a Generic Build method where the Generic is a child of IProduct
    /// Product can be of the same class as the Factory.
    /// Factory is of type that produces Cars, so the Product is of a type designed for Car
    /// </summary>
    /// <typeparam name="TFactory"></typeparam>
    interface IFactory<TFactory>
    {
        TProduct Build<TProduct>() where TProduct : IProduct<TFactory>, new();
    }
}