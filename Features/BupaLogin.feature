Feature: bupaLogin

As a user I navigate to Bupa Insurnace Page validate the URl for Health Insurance 

@bupaloginTest
Scenario: Bupa login page
	Given navigate to Bupa Insurance page 'https://bupa.com.au/'
	When Click on health insurance 
	Then Validate the Url has 'health-insurance'
