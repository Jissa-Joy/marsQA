Feature: login
	login feature mars QA

@mytag
Scenario: Sign In
	Given Launch Url
	And Click on sign in button
	When i enter valid email and password
	And click on login button
	Then login should be successful