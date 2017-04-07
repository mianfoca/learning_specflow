Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of three numbers

Scenario: Add three numbers
	Given I have entered 50 into the calculator
		And I have entered 70 into the calculator
		And I have entered 30 into the calculator
	When I press add
	Then the result should be 150 on the screen
