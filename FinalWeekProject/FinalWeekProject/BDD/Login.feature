Feature: Login
	In order to keep a record of my purchased books
	As a user
	I want to have a profile which shows me my purchases

@mytag
Scenario: Navigating to the new user page

	When I click new user
	Then I should see 'Register to Book Store'

@mytag
Scenario: Creating new user
	Given that I am on the create new user page
	And I have filled in the prompted fields
	| FirstName | LastName | UserName     | Password |
	| Sparta    | Global   | SpartaGlobal23 | Test123$ |
	And clicked the I'm not a robot box
	When I click register
	Then I should have created a new user

@mytag
Scenario: Invalid password
	Given I am on the login page
	And I have entered the username 'SpartaGlobalTest'
	And I have entered the password <passwords>
	When I click the sign in button 
	Then I should see an alert containing the error message "Invalid username or password."
Examples: 
|passwords|
|four     |
|1234     |
|Test     |

