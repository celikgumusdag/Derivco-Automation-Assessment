using System.Configuration;
using System.IO;

namespace Derivco_Automation_Assessment.Utilities
{
    public static class Constants
    {
        public static string Url = Directory.GetCurrentDirectory() + ConfigurationManager.AppSettings["url"];
        public static string Browser = ConfigurationManager.AppSettings["browser"];

        public static int Balance;
    }
}
