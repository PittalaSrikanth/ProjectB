


Feature: Login and create new user in Tours web page



Scenario: Login scenario of Tours
Given user is at login page with title "Welcome: Mercury Tours"
And Title of the page should be "Welcome: Mercury Tours"
When i enter "8712282868" and "password" and click login button
Then user should be at Dashboard page with title "Welcome: Mercury Tours"
And Title of the page should be "Welcome: Mercury Tours"





Scenario: Login and Create a new user scenario
Given user is at login page

