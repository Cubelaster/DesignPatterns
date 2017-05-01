using DesignPatterns.AbstractFactoryGenerics.Factory.Contracts.FactoryContracts;
using DesignPatterns.AbstractFactoryGenerics.Products.Contracts;

namespace DesignPatterns.AbstractFactoryGenerics.Factory
{
    /// <summary>
    /// Factory is a class that defines the Create method.
    /// Create is in charge of instantiating all of the product types.
    /// Create actually calls the Build method of Factory Type from the Generic.
    /// </summary>
    /// <typeparam name="FactoryType"></typeparam>
    class Factory<FactoryType> where FactoryType : IFactory<FactoryType>, new()
    {
        public TProduct Create<TProduct>() where TProduct : IProduct<FactoryType>, new()
        {
            return new FactoryType().Build<TProduct>();
        }
    }
}
