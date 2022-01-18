Feature: EmployeeFeature
To Create ,Edit and Delete Employee Record

@tag1
Scenario: 1 [Creating Employee Record]
	Given [Logged in to turnup portal]
	And [Naviagte to Employee]
	When [I create the emplyee record]
	Then [Employee Record created successfully]

Scenario Outline: 2 [Editing Employee Record]
	Given [Logged in to turnup portal]
	And [Naviagte to Employee]
	When [I Edited the '<EmployeeName>' and '<EmployeeUsername>' and '<ContactDisplay>' and '<Password>' and '<RetypePassword>' record]
	Then [The record should have been updated '<EmployeeName>' and '<EmployeeUsername>' and '<ContactDisplay>' and '<Password>' and '<RetypePassword>']
Examples: 
| EmployeeName | EmployeeUsername | ContactDisplay | Password    | RetypePassword |
| FirstDora    | UserDora         | 11111111       | Dora-111111 | Dora-111111    |
| SecondDora   | SecondUserDora   | 22222222       | Dora-222222 | Dora-222222    |
| EditDora     | EditUserDora     | 12312312       | Dora-123412 | Dora-123412    |



Scenario: 3 [Deleting Employee Record]
	Given [Logged in to turnup portal]
	And [Naviagte to Employee]
	When [I delete the employee record ]
	Then [Employee Record with deleted successfully]


