using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using PremierUIAutomation.Fixtures;
using PremierUIAutomation.Helpers;
using System.Collections.Generic;

namespace NUnitTestProject3
{
    public class Tests : TestBase
    {

        protected override void OneTimeSetup()
        {
            string url = "http:\\www.GoIbibo.com";
            string browser = TestContext.Parameters["browser"];
            TestInitiator.getBrowser(browser);
            actions.launchBrowser(url);
        }


        [Test]
        public void Test1()
        {
            
        }

        public static IEnumerable<string> testcases(object[] obj)
        {

            return null;
        }

    }
}