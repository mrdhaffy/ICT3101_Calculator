Feature: UsingCalculatorBasicReliability
	In order to calculate the Basic Musa model's failures/intensities
	As a Software Quality Metric enthusiast
	I want to use my calculator to do this

@Musa
Scenario: Calculate current failure intensity
	Given I have a calculator
	When I have entered "10" and "50" into the calculator and press current failure intensity
	Then the current failure intensity result should be "5"

@Musa
Scenario: Calculate average current failure intensity
	Given I have a calculator
	When I have entered "10" and "100" into the calculator and press average current failure intensity
	Then the average current failure intensity result should be "100"