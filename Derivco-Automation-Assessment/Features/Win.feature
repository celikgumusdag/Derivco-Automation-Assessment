Feature: Win
	This feature controlling for spin and win to the slot machine.
	This feature use test data for combinations.

Scenario Outline: Win With Combinations
	Given I open page
	When  I fill test data as "<TestData>"
	When  I spin
	Then  I see won "<Price>"

	Examples: 
	| TestData | Price |
	| 11100    | 60    |
	| 11110    | 80    |
	| 11111    | 100   |
	| 22200    | 120   |
	| 22220    | 160   |
	| 22222    | 200   |
	| 33300    | 180   |
	| 33330    | 240   |
	| 33333    | 300   |
	| 44400    | 240   |
	| 44440    | 320   |
	| 44444    | 400   |
	| 55500    | 300   |
	| 55550    | 400   |
	| 55555    | 500   |