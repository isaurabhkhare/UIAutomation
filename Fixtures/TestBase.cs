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
   [SetUpFixture]
   public abstract class TestBase 
    {
       protected CommonActions actions;

       public TestBase()
        {
           // actions = new CommonActions(_driver);
           
        }
       

        [OneTimeSetUp]
        protected abstract void OneTimeSetup();
        //{
        //    string url = TestContext.Parameters["url"];
        //    string browser = TestContext.Parameters["browser"];
        //    //TestInitiator.getBrowser(browser);
        //    //actions.launchBrowser(url);
        //}

        [SetUp]
        protected abstract void Setup();


        [OneTimeTearDown]
        protected abstract void OneTimeTeardown();
     


    [TearDown]
        protected abstract void TearDown();
      
    }
}
