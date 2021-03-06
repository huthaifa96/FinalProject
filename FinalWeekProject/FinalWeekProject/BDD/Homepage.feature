﻿Feature: Homepage
	In order to navigate around the website
	As a user
	I want see a homepage which gives me an option to click on the different sections

@homepage
Scenario: Book description
	Given I am on the homepage
	When I enter a <book name> into the search bar
	And click on the searched book's name
	Then I should see the right description of the book
	Examples:
	| book name           |
	| Git Pocket Guide    |

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
