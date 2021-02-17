Feature: AP_Dresses
	As a user I want to be able to visit the dresses page so that I can view or buy my preferred clothes


@Dresses
Scenario Outline: PopUp Visible
	Given I am on the dresses page
	When I add 1 product to cart
	Then I should see a PopUp confirmation 

@Dresses
Scenario Outline: Continue shopping
	Given I am on the dresses page
	When I add 1 product to cart
	And I click continue shopping on the PopUp
	Then I should see the dressespage with the title "Dresses - My Store"
	#Then I should see a page with the title "Dresses - My Store"

@Dresses
Scenario Outline: Buy 1 products 
	Given I am on the dresses page
	When I add 1 product to cart
	And I click proceed to checkout on the PopUp
	Then I should see the total price "$52.99"