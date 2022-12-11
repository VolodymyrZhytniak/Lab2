using ObjectPages;
using OpenQA.Selenium;

namespace Web_Bank_Test
{
    public class ManagerPage : BasePage
    {
        public ManagerPage(IWebDriver webDriver) : base(webDriver)
        {

        }

        private IWebElement btnCustomers => driver.FindElement(By.XPath("//button[@ng-click='showCust()']"));

        public void ClickCustomers() => btnCustomers.Click();
    }
}