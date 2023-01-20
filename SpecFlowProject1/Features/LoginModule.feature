Feature: LoginModule

	Login to the application as user

@login
Scenario: log in to Apllication
	Given Navigate to login page
	When verify user is on logInPage
	Then Enter the username and password
	And Click on LogIn button
