using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PremierUIAutomation.Fixtures;
using PremierUIAutomation.Helpers;
using ReportPortal.Serilog;
using Serilog;
using System;
using System.Collections;
using System.Collections.Generic;

namespace PremierUIAutomation.TestScripts.Login
{

   [TestFixture,TestFixtureSource("FindBrowser")]
   [Parallelizable(ParallelScope.Fixtures)]
   
    public class Tests : TestBase 

    {
        protected string browserType;
        [ThreadStatic]
        public static IWebDriver driver;
        public Tests(string obj) : base(driver) {
            browserType = obj;
        }
        // [ThreadStatic]
        #region Custom Fixture
        protected override void OneTimeSetup()
        {
            Log.Logger = new LoggerConfiguration().WriteTo.ReportPortal().CreateLogger();
            string url = "http://www.google.com";
            string browser = TestContext.Parameters["browser"];
            actions.getBrowser(browserType,url);
        }
        protected override void Setup()
        {
        
        }
        protected override void OneTimeTeardown()
        {
            actions.Commdriver.Quit();
        }
        protected override void TearDown()
        {
            
        }
        #endregion

        [Test]
        public void Test1()
        {
           // TestInitiator.driver = new ChromeDriver();
           // TestInitiator.driver.Url = "http:\\www.facebook.com";
            Assert.AreEqual("Google", actions.getTitle());
            Log.Information("My log message");

            
            
            Log.Information("< span style = 'color: red' > text in red </ span >My log message");
            Log.Information("TEST");
            var position = new { Latitude = 25, Longitude = 134 };
            var elapsedMs = 34;

            Log.Information("Processed {@Position} in {Elapsed:000} ms.", position, elapsedMs);
        }


        [Test]
        public void Test2()
        {
          //  Log.Information(str);
            // TestInitiator.driver = new ChromeDriver();
            // TestInitiator.driver.Url = "http:\\www.facebook.com";
            Assert.AreEqual(true, true);
        }

        [Test]
        public void Test3()
        {
            // TestInitiator.driver = new ChromeDriver();
            // TestInitiator.driver.Url = "http:\\www.facebook.com";
            Assert.AreEqual(true, true);
        }

        public static IEnumerable<string> testcases(object[] obj)
        {
            return null;
        }

        public static IEnumerable<TestFixtureData> FindBrowser()
        {
            
            var BrowserList = new List<string>();
            
            string browser1 = TestContext.Parameters["browser"];
            if (browser1.ToLower() == "chrome" && browser1 != null)
            {
                BrowserList.Add("chrome");
            }
            else if (browser1.ToLower() == "firefox" && browser1 != null)
            {
                BrowserList.Add("firefox");

            }
            else if (browser1.ToLower() == "all" && browser1 != null)
            {
                BrowserList.Add("chrome");
                BrowserList.Add("firefox");
                BrowserList.Add("ie");

            }

            foreach (var item in BrowserList)
            {
                yield return new TestFixtureData(item);
            }
           
        }


    }
}