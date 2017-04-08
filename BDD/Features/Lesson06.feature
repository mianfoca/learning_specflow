Feature: Lesson06_1
	Simple feature to demonstrate customer Login feature

@customer 
Scenario: Login for customer portal
	Given I have opened the application
	And I login to application
	Then I see customer portal

@user 
Scenario: Login for user portal
	Given I have opened the application
	And I login to application
	Then I see user portal