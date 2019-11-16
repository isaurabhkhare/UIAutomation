using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace PremierUIAutomation.Common_Actions
{
   public class CommonActions
    {
        public void check(ControlNameWrapper control, string controlName)
        {
            string s = control.browser.FindElement(control.Control).Text;

        }
    }
}
