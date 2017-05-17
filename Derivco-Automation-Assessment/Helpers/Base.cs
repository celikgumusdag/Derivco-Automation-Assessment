using OpenQA.Selenium;
using Derivco_Automation_Assessment.Utilities;
using TechTalk.SpecFlow;

namespace Derivco_Automation_Assessment.Helpers
{
    public class Base
    {
        public IWebDriver WebDriver { get; set; }

        public Base()
        {
            if (WebDriver==null)
            {
              WebDriver = Driver.Current;  
            }
            
        }

        protected void Open()
        {
            WebDriver.Navigate().GoToUrl(Constants.Url);
        }

        [AfterScenario]
        protected void Dispose()
        {
            WebDriver.Dispose();
        }

        protected void Wait(int second)
        {
            System.Threading.Thread.Sleep(second * 1000);
        }

        protected IWebElement FindElement(string css)
        {
            IWebElement el = WebDriver.FindElement(By.CssSelector(css));
            return el;
        }

        protected void ClickElement(string css)
        {
            FindElement(css).Click();
        }

        protected void HighlightElement(string css)
        {
            IWebElement el = FindElement(css);
            IJavaScriptExecutor js = WebDriver as IJavaScriptExecutor;
            js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", el,
                " border: 3px solid red;");
        }

        protected string GetText(string css)
        {
            return FindElement(css).Text;
        }

        protected string GetValue(string css)
        {
            return FindElement(css).GetAttribute("value");
        }

        protected void SetValue(string css, string key)
        {
            ClearValue(css);
            FindElement(css).SendKeys(key);
        }

        protected void ClearValue(string css)
        {
            FindElement(css).Clear();
        }

    }
}
