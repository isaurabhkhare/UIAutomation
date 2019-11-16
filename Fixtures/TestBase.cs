using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PremierUIAutomation.Common_Actions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PremierUIAutomation.Fixtures
{
    [TestFixture]
   public class TestBase
    {
        protected CommonActions actions = new CommonActions();
        public static IWebDriver browser;


        [OneTimeSetUp]
        public void OneTimeSetup()
        {
           


        }


        [SetUp]
        public void Setup()
        {
        }

        [OneTimeTearDown]
        public void OneTimeTeardown()
        {
            browser.Quit();


        }


        [TearDown]
        public void TearDown()
        {
            browser.Close();
        }

    }
}
