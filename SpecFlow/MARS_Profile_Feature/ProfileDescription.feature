Feature: MARS Profile Page - Description Tab

Create, Edit, Delete of Description Record


Scenario: [Check if seller is able to add Description Entry on Profile Page]
	Given [Seller is able to login on MARS Profile Page.]
	When [Creating a new Description Entry.]
	Then [the new Description Entry should be added successfully.]
	Then [Close the browser.]


Scenario: [Check if seller is able to update the Description Entry on Profile Page]
	Given [Seller is able to login on MARS Profile Page.]
	When [Updating a Description Entry.]
	Then [the Description Entry should be updated successfully.]
	Then [Close the browser.]

Scenario: [Check if seller is not able to delete the Description Entry on Profile Page]
	Given [Seller is able to login on MARS Profile Page.]
	When [Deleting a Description Entry.]
	Then [the Description Entry should not be deleted.]
	Then [Close the browser.]

