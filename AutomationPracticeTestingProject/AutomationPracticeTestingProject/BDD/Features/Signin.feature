Feature: AP_Signin
	Provides the user with the ability to sign in by entering their email and password



@Signin
Scenario Outline: Password too short
	Given I am on the signin page
	And I have entered an  <email> and a <password>
	When I click the sign in button
	Then I should see an alert containing the error message "Invalid password"
	Examples: 
	| email                  | password |
	| testingemail@gmail.com | 1234     |
	| testingemail@gmail.com | wiz      |
	| testingemail@gmail.com | sick     |


@Signin
Scenario Outline: Invalid email
	Given I am on the signin page
	And I have entered an  <email> and a <password>
	When I click the sign in button
	Then I should see an alert containing the error message "Invalid email address"
	Examples: 
	| email | password     |
	| hi    | Password123! |
	| bye   | Password123! |

@Signin
Scenario Outline: Access account page
	Given I am on the signin page
	And I have entered an  <email> and a <password>
	When I click the sign in button
	Then I should see a page with the title "My account - My Store"
	Examples: 
	| email                  | password     |
	| testingemail@gmail.com | Password123! |