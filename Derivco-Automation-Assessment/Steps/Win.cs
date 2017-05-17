using Derivco_Automation_Assessment.Helpers;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Derivco_Automation_Assessment.Steps
{
    [Binding]
    public class Win : Actions
    {
        [When(@"I fill test data as ""(.*)""")]
        public void WhenIFillTestDataAs(string data)
        {
            SetTestData(data);
        }

        [Then(@"I see won ""(.*)""")]
        public void ThenISeeWon(int price)
        {
            Wait(1);
            Assert.AreEqual(GetText("#winbox"), "Win " + price + " coins");
        }

        [Then(@"I see won price")]
        public void ThenISeeWonPrice()
        {
            Wait(1);
            StringAssert.Contains(GetText("#winbox"), "Win");
        }
    }
}
