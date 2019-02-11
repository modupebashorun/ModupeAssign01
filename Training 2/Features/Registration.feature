Feature: Registration
	So that I can use the site
	I need to register
	

@mytag
Scenario: Valid Regitration
	Given I navigate to the site
	When Click on the register link
    And I enter first name
	And I enter last name
	And I enter email "emailaddress"
	And I enter mobile number
	And I enter password
	And I confirm password
	And the click on signup
	Then I should be registered
