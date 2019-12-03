using OpenQA.Selenium;
using System;

namespace PremierUIAutomation.Helpers
{
    public class TestInitiator
    {
        [ThreadStatic]
        public static IWebDriver driver;
        // public TestInitiator(ref IWebDriver _driver)
        //{
        //    driver = _driver;

        //}



        internal static void getBrowser()
        {
            throw new NotImplementedException();
        }
    }
}
