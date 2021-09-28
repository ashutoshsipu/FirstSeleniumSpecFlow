Feature: HomeControls
	Simple logins in HomeControls website

@scopeBinding
Scenario: HomeControls should be login with given username and Password
	Given I have navigated to HomeControls website
	And I have entered username and password
	When I click on submit button
	Then I should see the homepage