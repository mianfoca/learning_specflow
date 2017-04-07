Feature: Calculator_Table
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of three numbers

Scenario Outline: Add three numbers from table
  Given I have entered <number_1> into the calculator
	And I have entered <number_2> into the calculator
	And I have entered <number_3> into the calculator
  When I press add
  Then the result should be <result> on the screen

  Examples:
    | number_1 | number_2 | number_3 | result |
    | 12       | 5        | 7        | 24     |
    | 20       | 5        | 15       | 40     |