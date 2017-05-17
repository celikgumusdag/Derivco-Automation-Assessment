using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Derivco_Automation_Assessment.Helpers;
using Derivco_Automation_Assessment.Utilities;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Derivco_Automation_Assessment.Steps
{
    [Binding]
    public class SpinStep : Actions
    {
        [Then(@"I see numbers are display")]
        public void ThenISeeNumbersAreDisplay()
        {
            Assert.AreEqual(GetNumbers().Count, 15);
        }

        [Then(@"I see current balance is decreasing")]
        public void ThenISeeCurrentBalanceIsDecreasing()
        {
            Assert.AreEqual(Constants.Balance, GetCurrentBalance() + 1);
        }

        [Then(@"I see current balance is increasing")]
        public void ThenISeeCurrentBalanceIsIncreasing()
        {
            string input = Regex.Replace(GetText("#winbox"), "[^0-9]+", string.Empty);
            int price = Convert.ToInt32(input);

            Assert.AreEqual(Constants.Balance + price, GetCurrentBalance() + 1);
        }

    }
}
