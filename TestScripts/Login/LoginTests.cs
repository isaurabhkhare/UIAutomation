using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using PremierUIAutomation.Common_Actions;
using PremierUIAutomation.Fixtures;
using ReportPortal.Serilog;
using Serilog;
using System;
using System.Collections.Generic;

namespace PremierUIAutomation.TestScripts.Login
{

    [TestFixture, TestFixtureSource("FindBrowser")]
    [Parallelizable(ParallelScope.Fixtures)]

    public class LoginTest : TestBase

    {
        protected static string browserType;
        public IWebDriver driver = null;

        public LoginTest(string obj)
        {
            browserType = obj;
        }
        #region Custom Fixture
        protected override void OneTimeSetup()
        {
            //Log.Logger = new LoggerConfiguration().WriteTo.ReportPortal().CreateLogger();
            actions = new CommonActions(driver);
            string url = TestContext.Parameters["url"];
            string browser = TestContext.Parameters["browser"];
            actions.getBrowser(browserType, url);

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

        [Test, TestCaseSource("LoginPositiveTests")]
        public void LoginPositive(string obj1, string obj2)
        {
            //var json = System.IO.File.ReadAllText("myjson.json");
            //var jo = JObject.Parse(json);
            //var LabelValues = new List<JsonValues>();
            //foreach (var item in jo )
            //{
            //    string v = item.Key;
            //    var j = jo[v];
            //    var Json = JsonConvert.DeserializeObject<JsonValues>(j.ToString());
            //    LabelValues.Add(Json);
            //}

            //Console.WriteLine(LabelValues);

            Assert.AreEqual("Facebook – log in or sign up", actions.getTitle());
            Log.Information("My log message");
            actions.Commdriver.FindElement(By.Id("email")).SendKeys(obj1.ToString());
            actions.Commdriver.FindElement(By.Id("pass")).SendKeys(obj2.ToString());
            string str = actions.Commdriver.FindElement(By.Id("pass")).GetAttribute("type");
            actions.Commdriver.FindElement(By.XPath("//input[@value = 'Log In']")).Click();
            actions.Commdriver.Manage().Cookies.DeleteAllCookies();
            actions.Commdriver.Navigate().Refresh();
            Log.Information("< span style = 'color: red' > text in red </ span >My log message");
            Log.Information("TEST");
            var position = new { Latitude = 25, Longitude = 134 };
            var elapsedMs = 34;
            Log.Information("Processed {@Position} in {Elapsed:000} ms.", position, elapsedMs);
        }


        [Test, TestCaseSource("LoginNegativeTests"), Parallelizable]
        public void LoginNegative(string obj1, string obj2)
        {
            try
            {
                Assert.AreEqual("Facebook – log in or up", actions.getTitle());
                actions.Commdriver.FindElement(By.Id("email")).Clear();
                actions.Commdriver.FindElement(By.Id("email")).SendKeys(obj1.ToString());
                actions.Commdriver.FindElement(By.Id("pass")).Clear();
                actions.Commdriver.FindElement(By.Id("pass")).SendKeys(obj2.ToString());
                string str = actions.Commdriver.FindElement(By.Id("pass")).GetAttribute("type");
                actions.Commdriver.FindElement(By.XPath("//input[@value = 'Log In']")).Click();
                bool pass = actions.Commdriver.FindElement(By.Id("pass")).Displayed;
                Assert.AreEqual(true, pass);
            }
            catch (Exception)
            {
                Log.Information("Following test failed on browser -> " + browserType + "  " + TestContext.CurrentContext.Test.FullName + browserType);
            }
        }

        public static IEnumerable<TestFixtureData> FindBrowser()
        {
            var BrowserList = new List<string>();
            string browser1 = TestContext.Parameters["browser"];
            if (browser1.ToLower() == "chrome" && browser1 != null)
            {
                BrowserList.Add(browser1);
            }
            else if (browser1.ToLower() == "firefox" && browser1 != null)
            {
                BrowserList.Add(browser1);
            }
            else if (browser1.ToLower() == "edge" && browser1 != null)
            {
                BrowserList.Add(browser1);
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

        public static IEnumerable<TestCaseData> LoginPositiveTests()
        {
            TestCaseData TestNamedata;
            string jsonFilePath = @"F:\Documents C drive\Visual Studio 2019\Projects\NUnitTestProject3\bin\Debug\netcoreapp3.0\Environment\Login.json";
            var data = System.IO.File.ReadAllText(jsonFilePath);
            var testdata = JsonConvert.DeserializeObject<LoginTestCollection>(data);
            foreach (var item in testdata.PositiveTests)
            {
                string[] str = { item.Username.ToString(), item.Password.ToString() };
                TestNamedata = new TestCaseData(str).SetName(TestContext.CurrentContext.Test.Name + "" + browserType);
                yield return TestNamedata;
            }
        }
        public static IEnumerable<TestCaseData> LoginNegativeTests()
        {
            string jsonFilePath = @"F:\Documents C drive\Visual Studio 2019\Projects\NUnitTestProject3\bin\Debug\netcoreapp3.0\Environment\Login.json";
            var data = System.IO.File.ReadAllText(jsonFilePath);
            var testdata = JsonConvert.DeserializeObject<LoginTestCollection>(data);
            var tests = new List<TestCaseData>();
            foreach (var item in testdata.NegativeTests)
            {
                string[] str = { item.Username.ToString(), item.Password.ToString() };
                yield return new TestCaseData(str).SetName(browserType);
            }
        }
    }
}