using TechTalk.SpecFlow;
using Web_Bank_Test;

namespace Tests.Steps
{
	[Binding]
	public class ManagerStepDefinitions : BaseSteps
	{
		private ManagerPage managerPage;

		[Given(@"I click on the Customers menu item")]
		public void GivenIClickOnTheCustomersMenuItem()
		{
			managerPage = new ManagerPage(driver);
			Thread.Sleep(1000);
			managerPage.ClickCustomers();
		}
	}
}