Feature: Lesson10
	Check if the Login functionality is working
	as expected with different permutations and
	combinations of data

@smoke @positive
Scenario: Check Login with correct username and password
	Given I have navigate to the application
	And I click login link
	When I enter UserName and Password
	| UserName | Password |
	| admin    | password |
	And I click login button
	Then I should see the username with hello
	And I click logout
