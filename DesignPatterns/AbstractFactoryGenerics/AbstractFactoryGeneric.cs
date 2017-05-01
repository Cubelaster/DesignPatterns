using DesignPatterns.AbstractFactoryGenerics.Factory;
using DesignPatterns.AbstractFactoryGenerics.Products.BaseProducts;
using DesignPatterns.AbstractFactoryGenerics.Products.CarProducts;
using DesignPatterns.AbstractFactoryGenerics.Products.Contracts;
using DesignPatterns.AbstractFactoryGenerics.Products.PartProducts;
using DesignPatterns.AbstractFactoryGenerics.Products.PlaneProducts;
using System;

namespace DesignPatterns.AbstractFactoryGenerics
{
    static class AbstractFactoryGeneric
    {
        public static void Run()
        {
            Console.WriteLine("Second showcase is the AbstractFactoryGeneric design pattern.");
            Console.WriteLine("The Factory is the entry point for creating entities." + Environment.NewLine
                + "This is an interface/class declares and implements the generic methods for creating entities.");
            Console.WriteLine("Since it's generic, other classes can implement the original interface according to " + Environment.NewLine
                + "specific needs. These new factories are then called by providing the right type of generic.");
            Console.WriteLine("These sub-factories have generics which are meant to recoignise which entity to create. " + Environment.NewLine
                + "Creating the entities is then done by calling the Create method with desired generic type." + Environment.NewLine);

            // Create instances of factrories for types of products
            Factory<Car> carFactory = new Factory<Car>();
            Factory<Plane> planeFactory = new Factory<Plane>();

            // Create products through factories meant for those kinds of products
            IProduct<Car> carProduct = carFactory.Create<Toyota>();
            carProduct.Operate();

            // Depending on the type of defined variable, different methods are available on object
            // Instantiating the product in a variable of interface type hides methods defined in class type
            Boeing planeProduct = planeFactory.Create<Boeing>();
            planeProduct.Operate();
            planeProduct.BoeingSpecificOperation();

            IProduct<Car> carPartProduct = carFactory.Create<Engine<Car>>();
            carPartProduct.Operate();

            Frame<Car> carFrame = carFactory.Create<Frame<Car>>();
            carFrame.FrameSpecificOperation();
            carFrame.Operate();

            IProduct<Plane> planePartProduct = planeFactory.Create<Rudder>();
            planePartProduct.Operate();
        }
    }
}
