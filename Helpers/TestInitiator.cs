using NUnit.Framework;
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
