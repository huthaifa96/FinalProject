Feature: Homepage
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@homepage
Scenario: Book description
	Given I am on the homepage
	When I enter a <book name> into the search bar
	And click on the searched book's name
	Then I should see the 'Description' of the book
Examples:
| book name           |
| Git Pocket Guide    |
| Speaking JavaScript |
| You Don't Know JS   |

@homepage
Scenario: Profile without logging in
	Given I am on the homepage
	When I click Profile without logging in
	Then I should see the 'Currently you are not logged into the Book Store' message

@homepage
Scenario: Login page
	Given I am on the homepage
	When I click Login
	Then The 'Welcome, Login in Book Store' message should be seen
