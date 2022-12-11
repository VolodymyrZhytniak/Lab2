using TechTalk.SpecFlow;
using Web_Bank_Test;

namespace Tests.Steps
{
	[Binding]
	public class CustomersStepDefinitions : BaseSteps
	{
		private CustomersPage customersPage;
		List<string> actualLastNames = new List<string>();
		List<string> expectedLastNames = new List<string>();

		[When(@"I click on the Last Name link")]
		public void WhenIClickOnTheLastNameLink()
		{
			customersPage = new CustomersPage(driver);
			Thread.Sleep(1000);
			expectedLastNames = customersPage.GetLastNames();
			expectedLastNames.Sort();
			expectedLastNames.Reverse();
            customersPage.ClickSortLastNameCustomer();
			Thread.Sleep(1000);
			actualLastNames = customersPage.GetLastNames();
		}

		[Then(@"I should see customers list sorted by their last names")]
		public void ThenIShouldSeeCustomersListSortedByLastNames()
		{
			Assert.AreEqual(actualLastNames, expectedLastNames);
		}
	}
}