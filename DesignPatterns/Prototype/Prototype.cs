using DesignPatterns.Prototype.ConcretePrototype;
using DesignPatterns.Prototype.Manager;
using System;

namespace DesignPatterns.Prototype
{
    static class Prototype
    {
        /// <summary>
        /// Specify the kind of objects to create using a prototypical instance, 
        /// and create new objects by copying this prototype.
        /// </summary>
        public static void Run()
        {
            ColorManager colormanager = new ColorManager();

            // Initialize with standard colors
            colormanager["red"] = new Color(255, 0, 0);
            colormanager["green"] = new Color(0, 255, 0);
            colormanager["blue"] = new Color(0, 0, 255);

            // User adds personalized colors
            colormanager["angry"] = new Color(255, 54, 0);
            colormanager["peace"] = new Color(128, 211, 128);
            colormanager["flame"] = new Color(211, 34, 20);

            // User clones selected colors
            Color color1 = colormanager["red"].Clone() as Color;
            Color color2 = colormanager["peace"].Clone() as Color;
            Color color3 = colormanager["flame"].Clone() as Color;

            Console.WriteLine("");
        }
    }
}
