using OpenQA.Selenium;

namespace PremierUIAutomation.Common_Actions
{
    public class ControlNameWrapper
    {
        public By Control;
        public string controlname;
        public IWebDriver browser;

        public ControlNameWrapper(By Control, string name)
        {
            this.Control = Control;
            this.controlname = name;

        }

    }
}
