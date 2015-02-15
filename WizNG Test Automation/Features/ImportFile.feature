Feature: ImportFile
	User can import file
	And verify imported file is shown on data files

Background: 
	Given I am on WizNg landing page

@mytag
Scenario: UC:2 Import .txt file and verify
	Given I click on log in link
	Then I provide my login credentials
	And I log in to WizNg and verify
	Then I click on import wizard
	And I select .txt file and file name
	Then I click on next
	Then I check first row column checkbox
	And I click on next of step two
	Then I check dont auto geocode checkbox
	And I click on next of step two
	Then I AutoMap my files
	And I click on finish
	Then I verify my file is saved

Scenario: UC:3 Import .csv file and verify
	Given I click on log in link
	Then I provide my login credentials
	And I log in to WizNg and verify
	Then I click on import wizard
	And I select .csv file and file name
	Then I click on next
	Then I check first row column checkbox
	And I click on next
	Then I check dont auto geocode checkbox
	And I click on next
	Then I AutoMap my files
	And I click on finish
	Then I verify my file is saved
