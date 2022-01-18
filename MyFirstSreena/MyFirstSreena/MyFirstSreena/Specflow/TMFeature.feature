Feature: TMFeature
To Create Edit and Delete TM Record on Turnup Portal

@tag1
Scenario: 1 [Create TM Record]
	Given [logged in to Turnup Portal]
	And [Navigate to TM]
	When [I create TM Record]
	Then [Record created Successfully]

Scenario: 2 [Edit TM Record]
	Given [logged in to Turnup Portal]
	And [Navigate to TM]
	When [I edit TM Record]
	Then [Record edited Successfully]

Scenario: 3 [Delete TM Record]
	Given [logged in to Turnup Portal]
	And [Navigate to TM]
	When [I delete TM Record]
	Then [Record deleted Successfully]
