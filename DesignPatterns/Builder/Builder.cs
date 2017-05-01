using DesignPatterns.Builder.ConcreteBuilders;
using DesignPatterns.Builder.Contract;
using System;

namespace DesignPatterns.Builder
{
    static class Builder
    {
        /// <summary>
        /// When we have an application that need to create an object which has to be constructed using 
        /// many different objects, we find our client code cluttered with the details of the various 
        /// Part objects that needs to be assembled together to create the resulting object.
        /// Separate the construction of a complex object from its representation so that the same 
        /// construction process can create different representations. 
        /// </summary>
        public static void Run()
        {
            Manufacturer manufacturer = new Manufacturer();
            IPhoneBuilder phoneBuilder = null;

            phoneBuilder = new AndroidPhoneBuilder();
            // Will Construct Android Phone
            manufacturer.Construct(phoneBuilder);
            Console.WriteLine("A new Phone is  built: " + phoneBuilder.Phone.ToString());

            phoneBuilder = new WindowsPhoneBuilder();
            manufacturer.Construct(phoneBuilder);
            Console.WriteLine("A new Phone is  built: " + phoneBuilder.Phone.ToString());
        }
    }
}
