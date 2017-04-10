Feature: Lesson11_1
	Check If login functionality works

Scenario: Login user as Administrator
	Given I navigate to application
	And I enter username and password
	| UserName | Password |
	| admin    | admin    |
	And I click login
	Then I should see user login in to the application
