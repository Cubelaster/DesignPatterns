using DesignPatterns.Factory.Creator.ContractCreator;
using DesignPatterns.Factory.Product.ConcreteProducts;

namespace DesignPatterns.Factory.Creator.ConcreteCreator
{
    class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
}
