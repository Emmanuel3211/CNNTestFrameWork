Feature: SignIn

As a user on CNN Website
I want to Register
So that I can be able to sign in

@tag1
Scenario: Registration
	Given I navigate to CNN website
	And I click accept cookies
	When I click on the login button
	And I click on the signup link
	And I entered my email address "abcde@yahoo.com"
	And I entered my password "1kf54n!l"
	And I click on create account button
	Then I am registered and redirected to the CNN website "https://edition.cnn.com/"
