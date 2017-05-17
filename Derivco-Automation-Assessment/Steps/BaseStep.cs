using Derivco_Automation_Assessment.Helpers;
using Derivco_Automation_Assessment.Utilities;
using TechTalk.SpecFlow;

namespace Derivco_Automation_Assessment.Steps
{
    [Binding]
    public class BaseStep : Actions
    {
        [Given(@"I open page")]
        public void GivenIOpenPage()
        {
            Open();
        }

        [Then(@"I see element ""(.*)""")]
        public void ThenISeeElement(string element)
        {
            HighlightElement(element);
        }

        [When(@"I spin")]
        public void WhenISpin()
        {
            Constants.Balance = GetCurrentBalance();
            Spin();
        }

        [When(@"I spin until win")]
        public void WhenISpinUntilWin()
        {
            while (!FindElement("#winbox").Displayed)
            {
                Constants.Balance = GetCurrentBalance();
                Spin();
            }
            Wait(3);
        }

        [When(@"I click ""(.*)""")]
        public void WhenIClick(string element)
        {
            ClickElement(element);
        }
    }
}
