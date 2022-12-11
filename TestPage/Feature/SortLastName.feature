Feature: SortLastNames
		Sort customers

@smoke
Scenario: Perform sorting customers by their last names
	Given I launch the application
	And I click on the Bank Manager Login link
	And I click on the Customers menu item
	When I click on the Last Name link
	Then I should see customers list sorted by their last names
