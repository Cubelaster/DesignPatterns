namespace DesignPatterns.AbstractFactoryGenerics.Products.Contracts
{
    interface IProduct<TFactory>
    {
        void Operate();
    }
}
