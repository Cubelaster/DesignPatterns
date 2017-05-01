using DesignPatterns.Builder.Product;

namespace DesignPatterns.Builder.Contract
{
    interface IPhoneBuilder
    {
        void BuildScreen();
        void BuildBattery();
        void BuildOS();
        void BuildStylus();
        MobilePhone Phone { get; }
    }
}
