Feature: SpinAndWin
	This feature controlling for spin and win to the slot machine.
	This feature spin until win.

Scenario: Spin Until Win
	Given I open page
	When  I spin until win
	Then  I see won price

Scenario: Spin Until Win Balance Increasing
	Given I open page
	When  I spin until win
	Then  I see current balance is increasing
