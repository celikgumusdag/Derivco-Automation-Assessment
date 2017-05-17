Feature: ElementExistence
		 This feature controlling for existence of elements.

Scenario Outline: Control Existence of Elements
	Given I open page
	Then  I see element "<ElementList>"

	Examples: 
	| ElementList            |
	| #game>center>div>h3    |
	| #game                  |
	| #paytable              |
	| #slot                  |
	| .balance-label         |
	| #balance-value         |
	| #spinButton            |
	| #game>center>div>label |
	| #testdata              |