using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Derivco_Automation_Assessment.Utilities
{
    public static class Driver
    {
        public const string Key = "driver";

        public static IWebDriver Current
        {
            get
            {
                if (!ScenarioContext.Current.ContainsKey(Key))
                {
                    IWebDriver driver = null;

                    if (Constants.Browser == "chrome")
                    {
                        ChromeOptions options = new ChromeOptions();
                        options.AddArguments("start-maximized");
                        driver = new ChromeDriver(options);

                        ScenarioContext.Current[Key] = driver;
                    }
                }

                return ScenarioContext.Current[Key] as IWebDriver;
            }
        }
    }
}
