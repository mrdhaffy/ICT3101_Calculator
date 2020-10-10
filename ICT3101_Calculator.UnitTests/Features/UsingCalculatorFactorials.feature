Feature: UsingCalculatorFactorials
	In order to conquer factorials
	As a factorial enthusiast
	I want to understand a variety of factorial operations

@Factorials
Scenario: Factorial postive number
Given I have a calculator
When I have entered "5" and "2" into the calculator and press factorial
Then the factorial result should be "120"

@Factorials
Scenario: Factorial negative number
Given I have a calculator
When I have entered "-5" and "2" into the calculator and press factorial
Then the factorial result should be an error