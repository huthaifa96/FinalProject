Feature: Books
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Adding books to my collection
	Given I am login page
	And I enter a valid <UserName> and <Password>
	And I click login
	And I click on the Book Store
	When I search a <book name> and click on it
	And add it to my collection 
	Then I should see it in my profile
Examples:
| UserName         | Password | book name        |
| SpartaGlobalTest | Test123$ | Git Pocket Guide |