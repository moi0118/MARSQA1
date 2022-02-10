Feature: MARS Profile Page - Skill Tab

Create, Edit, Delete of Skill Record


Scenario Outline: [Check if seller is able to add Skill Entry on Profile Page]
	Given [Seller is able to login on MARS Profile Skill Page.]
	When [Creating a new '<Skill>' and '<Skill-Level>' Entry]
	Then [the new '<Skill>' and '<Skill-Level>' Entry should be added successfully.]
	Then [Close the MARS Profile Skill Page.]
	Examples: 
	| Skill				  | Skill-Level |
	| Project Management  | Beginner    |



Scenario Outline: [Check if seller is able to update the Skill Entry on Profile Page]
	Given [Seller is able to login on MARS Profile Skill Page.]
	When [Updating a '<Skill>' and '<Skill-Level>' Entry.]
	Then [the '<Skill>' and '<Skill-Level>' Entry should be updated successfully.]
	Then [Close the MARS Profile Skill Page.]
	Examples:
	| Skill				  | Skill-Level		|
	| Project Management  | Intermediate    |


Scenario: [Check if seller is able to delete a Skill Entry on Profile Page]
	Given [Seller is able to login on MARS Profile Skill Page.]
	When [Deleting a Skill Entry.]
	Then [the Skill Entry should be deleted.]
	Then [Close the MARS Profile Skill Page.]

