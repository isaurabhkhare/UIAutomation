using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace PremierUIAutomation.Helpers
{
    public class TestInitiator
    {
        public static IWebDriver driver;
        public static void getBrowser(string browser)
        {
            if(browser.ToLower() == "firefox"){

                driver = new FirefoxDriver();
                driver.Manage().Window.Maximize();

            }
            else if(browser.ToLower() == "chrome")
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();

            }

        }

        internal static void getBrowser()
        {
            throw new NotImplementedException();
        }
    }
}
