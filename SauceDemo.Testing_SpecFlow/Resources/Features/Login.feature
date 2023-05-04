@Regression
Feature: Login

@Positive
Scenario: Login Successful
	Given I navigate to the Login page
	And Type my <username> and my <password>	
	When I click on the login button
	Then I should navigate to the Home page
Examples: 
| username      | password     |
| standard_user | secret_sauce |

@Negative
Scenario: Login Unsuccessful
	Given I navigate to the Login page
	And Type my <username> and my <password>	
	When I click on the login button
	Then I should navigate to the Home page
Examples: 
| username | password |
| murillo  | senha    |

