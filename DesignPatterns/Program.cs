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

            #region Factory

            Factory.Factory.Run();

            #endregion Factory

            // Holds the Console from closing in Debug mode
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.ReadLine();
            }
        }
    }
}