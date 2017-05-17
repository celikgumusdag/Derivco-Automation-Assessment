Feature: Spin
		 This feature controlling for spin to the slot machine.

Scenario: Spin and check numbers are display
	Given I open page
	When  I spin
	Then  I see numbers are display

Scenario: Spin and check current balance is decreasing
	Given I open page
	When  I spin
	Then  I see current balance is decreasing