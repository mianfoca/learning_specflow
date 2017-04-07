Feature: Lesson04
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: Create a new employee with mandatary details option 2
	#Given I have opened my application
	#Then I should see employee details page
	When I fill all the mandatory details in form option 2
	| Name    | Age | Phone      | Email                         |
	| karthik | 28  | 9098022312 | karthik@executeautomation.com |
	| John    | 30  | 2134234    | john@executeautomation.com    |
	| Sam     | 28  | 2342348902 | sam@executeautomation.com     |
	#And I click the save button
	#Then I should see all the details saved in my application and DB
