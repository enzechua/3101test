Feature: UsingCalculatorBasicReliability
    In order to calculate the basic Musa model's failures/intensities 
    As a software quality metric enthusiast
    I want to use my calculator to do this

@Availability
Scenario: Calculating current failure intensity
	Given I have a calculator
    When I have entered "?" and "?" into the calculator and press realiability
    Then the current failure intensity is "?"

