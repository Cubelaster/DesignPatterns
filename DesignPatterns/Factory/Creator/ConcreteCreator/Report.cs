using System;
using DesignPatterns.Factory.Creator.ContractCreator;
using DesignPatterns.Factory.Product.ConcreteProducts;

namespace DesignPatterns.Factory.Creator.ConcreteCreator
{
    class Report : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}
