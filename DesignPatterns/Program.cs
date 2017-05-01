using DesignPatterns.AbstractFactory.Factories;
using DesignPatterns.AbstractFactory.Implementation;
using DesignPatterns.AbstractFactoryGenerics.Factory;
using DesignPatterns.AbstractFactoryGenerics.Products.BaseProducts;
using DesignPatterns.AbstractFactoryGenerics.Products.CarProducts;
using DesignPatterns.AbstractFactoryGenerics.Products.Contracts;
using DesignPatterns.AbstractFactoryGenerics.Products.PartProducts;
using DesignPatterns.AbstractFactoryGenerics.Products.PlaneProducts;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the design pattern demonstration!" + Environment.NewLine);

            #region AbstractFactory

            AbstractFactory.AbstractFactory.Run();

            #endregion AbstractFactory

            #region AbstractFactoryGeneric

            AbstractFactoryGenerics.AbstractFactoryGeneric.Run();

            #endregion AbstractFactoryGeneric

            #region Builder

            Builder.Builder.Run();
            
            #endregion Builder

            // Holds the Console from closing in Debug mode
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.ReadLine();
            }
        }
    }
}