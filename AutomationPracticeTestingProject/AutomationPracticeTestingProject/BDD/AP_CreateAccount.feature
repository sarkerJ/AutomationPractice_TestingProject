Feature: AP_AccountCreate
	As a user I want to be able to create an account so that I can view my account information



@CreateAccount
Scenario Outline: Invalid email address
	Given I am on the SigninPage
	When I enter an email "test"
	Then the result I should see an alert with a message "Invalid email address."

@CreateAccount
Scenario Outline: Create account page
	Given I am on the SigninPage
	When I enter an email
	Then I should see "CREATE AN ACCOUNT" page 

@CreateAccount
Scenario Outline: My account page
	Given I am on the SigninPage
	When I enter an email
	And I populate the required fields
	And I click register
	Then I should see "MY ACCOUNT" page 