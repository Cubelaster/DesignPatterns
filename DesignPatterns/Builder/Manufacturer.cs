using DesignPatterns.Builder.Contract;

namespace DesignPatterns.Builder
{
    // This is the "Director" class
    /// <summary>
    /// The class that is in charge of binding everything together.
    /// Depending on the PhoneBuilder used, such phone gets built.
    /// </summary>
    class Manufacturer
    {
        public void Construct(IPhoneBuilder phoneBuilder)
        {
            phoneBuilder.BuildBattery();
            phoneBuilder.BuildOS();
            phoneBuilder.BuildScreen();
            phoneBuilder.BuildStylus();
        }
    }
}
