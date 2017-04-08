Feature: Lesson07
	Simple feature to demonstrate user Login feature

@admin 
Scenario: Login for user portal as admin
	Given I have opened the application
	And I login to application
	Then I see last date logged in data is 5 days from current date
	#And I see the menu likes
	#| Menu_1 | Menu_2   | Menu_3 | Menu_4   |
	#| Login  | Settings | Logout | Advanced |
