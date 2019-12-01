Feature: Student
	In order to manage students
	As an administator
	I want to be able manage students

Scenario: Register a student
	Given I have entered personal information below
		| Name    | Family    |
		| Fatemeh | Montazeri |
	When I press add
	Then I should see new student's information in page