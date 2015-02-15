Feature: LogInAndLogout
	I can login to WizNG
	And I can Logout

Background: 
	Given I am on WizNg landing page

@mytag
Scenario: UC:1 Log in to WizNG and Logout
	Given I click on log in link
	Then I provide my login credentials
	And I log in to WizNg and verify
	Then I click logout link
	And I verify I am logged out