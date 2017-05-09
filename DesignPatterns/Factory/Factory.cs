using DesignPatterns.Factory.Creator.ConcreteCreator;
using DesignPatterns.Factory.Creator.ContractCreator;
using DesignPatterns.Factory.Product;
using System;

namespace DesignPatterns.Factory
{
    static class Factory
    {
        /// <summary>
        /// Define an interface for creating an object, but let subclasses decide 
        /// which class to instantiate. Factory Method lets a class defer instantiation to subclasses.
        /// </summary>
        public static void Run()
        {
            Document[] documents = new Document[2];

            // Document abstract class calls Create pages in Constructor
            // That's why all the child classes do the same
            documents[0] = new Resume();
            documents[1] = new Report();

            // Display document pages
            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }

            Console.WriteLine("");
        }
    }
}