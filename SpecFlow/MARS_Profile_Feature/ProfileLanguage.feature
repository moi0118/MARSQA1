Feature: MARS Profile Page - Language Tab

Create, Edit, Delete of Language Record


Scenario Outline: [Check if seller is able to add Language Entry on Profile Page]
	Given [Seller is able to login on MARS Profile Page]
	When [Creating a new '<Language>' and '<Language-Level>' Entry.]
	Then [the new new '<Language>' and '<Language-Level>' Entry.]
	Then [Close the browser]
	Examples: 
	| Language | Language-Level |
	| English  | Basic          |
	



Scenario: [Check if seller is able to update the Language Entry on Profile Page]
	Given [Seller is able to login on MARS Profile Page]
	When [Updating a '<Language>' and '<Language-Level>'.]
	Then [the '<Language>' and '<Language-Level>' should be updated successfully.]
	Then [Close the browser]
	Examples: 
	| Language | Language-Level |
	| English  | Fluent		    |


Scenario: [Check if seller is able to delete a Language Entry on Profile Page]
	Given [Seller is able to login on MARS Profile Page]
	When [Deleting a Language Entry.]
	Then [the Language Entry should be deleted.]
	Then [Close the browser]

