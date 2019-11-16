using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using PremierUIAutomation.Fixtures;
using PremierUIAutomation.Helpers;

namespace NUnitTestProject3
{
    public class Tests : TestBase
    {

        [Test]
        public void Test1()
        {
            browser = new ChromeDriver();
            browser.Manage().Window.Maximize();
            browser.Url = "http:\\www.msn.com";
            actions.check(ObjectRepo.Searchbox, "");

            Assert.Pass();
        }
    }
}