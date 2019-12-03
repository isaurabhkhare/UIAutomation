using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using PremierUIAutomation.Helpers;

namespace PremierUIAutomation.Common_Actions
{
    public class CommonActions
    {
        public IWebDriver Commdriver;
        public CommonActions(IWebDriver _driver)
        {
            Commdriver = _driver;

        }
        public void check(ControlNameWrapper control, string controlName)
        {
            string s = Commdriver.FindElement(control.Control).Text;
        }

        public string getTitle()
        {
            return Commdriver.Title;
        }

        public void launchBrowser(string url)
        {
            TestInitiator.driver.Url = url;
        }

        public void getBrowser(string browser, string url)
        {

            if (browser.ToLower() == "firefox")
            {

                Commdriver = new FirefoxDriver();
                Commdriver.Manage().Window.Maximize();
                Commdriver.Url = url;

            }
            else if (browser.ToLower() == "chrome")
            {

                Commdriver = new ChromeDriver();
                Commdriver.Manage().Window.Maximize();
                Commdriver.Url = url;

            }
            else if (browser.ToLower() == "edge")
            {
                var anaheimService = ChromeDriverService.CreateDefaultService(@"F:\\Documents C drive\\Visual Studio 2019\\Projects\\NUnitTestProject3\\bin\Debug\\netcoreapp3.0\\","msedgedriver.exe");
                var anaheimOptions = new ChromeOptions
                {
                    BinaryLocation = @"C:\\Program Files (x86)\\Microsoft\\Edge Beta\\Application\\msedge.exe"
                };

                Commdriver = new ChromeDriver(anaheimService, anaheimOptions);
                Commdriver.Manage().Window.Maximize();
                Commdriver.Url = url;
            }
        }
    }
}
