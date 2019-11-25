using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using PremierUIAutomation.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

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
            TestInitiator.driver.Url =url;
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
            else if (browser.ToLower() == "ie")
            {

                Commdriver = new InternetExplorerDriver();
                Commdriver.Manage().Window.Maximize();
                Commdriver.Url = url;

            }

        }
    }
}
