using ObjectPages;
using OpenQA.Selenium;

namespace Web_Bank_Test
{
	public class CustomersPage : BasePage
	{
		public CustomersPage(IWebDriver webDriver) : base(webDriver)
		{

		}

		private IWebElement sortLastNameCustomer => driver.FindElement(By.XPath("//tr/td[2]/a"));

		private List<IWebElement> lastNameElements => driver.FindElements(By.XPath("//tr/td[2][@class='ng-binding']")).ToList<IWebElement>();


		public void ClickSortLastNameCustomer() => sortLastNameCustomer.Click();
		public List<string> GetLastNames() => lastNameElements.Select(el => el.Text).ToList<string>();
	}
}