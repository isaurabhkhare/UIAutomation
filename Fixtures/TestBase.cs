using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PremierUIAutomation.Common_Actions;
using PremierUIAutomation.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace PremierUIAutomation.Fixtures
{
    [TestFixture]
   public abstract partial class TestBase
    {
        protected CommonActions actions = new CommonActions();
        protected static IWebDriver driver;


        [OneTimeSetUp]
        protected virtual void OneTimeSetup()
        {
            string url = TestContext.Parameters["url"];
            string browser = TestContext.Parameters["browser"];
            TestInitiator.getBrowser(browser);
            actions.launchBrowser(url);
        }


        [SetUp]
        protected virtual void Setup()
        {
        }

        [OneTimeTearDown]
        protected virtual void OneTimeTeardown()
        {
            TestInitiator.driver.Quit();
        }


        [TearDown]
        protected virtual void TearDown()
        {
           TestInitiator.driver.Close();
        }

    }
}
