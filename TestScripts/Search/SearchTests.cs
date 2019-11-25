using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PremierUIAutomation.Fixtures;
using PremierUIAutomation.Helpers;
using Serilog;
using System;
using System.Collections.Generic;

namespace PremierUIAutomation.TestScripts.Search
{
    [TestFixture]
    [Parallelizable]
    public class SearchTest : TestBase
    {
        string str;
      /// [ThreadStatic]
        public static IWebDriver driver=null;
        #region Custom Fixture
        protected override void OneTimeSetup()
        {
              
               string url = "http:\\www.github.com";
            string browser = TestContext.Parameters["browser"];
             //  var driver1 = new TestInitiator(ref driver);
               TestInitiator.getBrowser(browser,driver);
            TestInitiator.driver.Url = url;
            str = TestInitiator.driver.Title;
            Log.Information(str);
            //TestInitiator.getBrowser(browser);
            //actions.launchBrowser(url);
        }
        protected override void Setup()
        {

        }
        protected void OneTimeTeardown()
        {
            TestInitiator.driver.Quit();
        }
        protected override void TearDown()
        {

        }
        #endregion

        [Test,Category("Search Tests")]
        public void TestSearch()
        {
            //driver = new ChromeDriver();
            //driver.Url = "http:\\www.GoIbibo.com";
            Assert.AreEqual(true, true);
            Log.Information(str);
        }

      

    }
}
