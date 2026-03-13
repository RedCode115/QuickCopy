Window white goal to register new users.
17 points of interest, 15 are input fields and 2 buttons.

15 input fields :
- First name
- Last name
- E-mail
- Username
- Password
- Password check
- Birthdate 
- Gender
- Country
- Language
- Hobby of Professional
	if professional :
	- Business
	- Sector
	- Position
- Main use

2 buttons :
- Sign in button
- Cancel button
# Why

- First and last name and also e-mail for contact with the user.
- Username and Password for validation of login via the database. 
- Gender (male, female, other) for addressing the user and for later development of design of the app. So we can focus the design and development of the UI to the right Gender group.
- Birthdate is for knowing our age-group so we can make sure not to over complicate application. 
- Country and language for language in the app and know what languages we need to focus on translation.
- Hobby or professional to know if it is useful in business for funding for later development.
- main use of the app se we know  what to focus development on
# Sign in button

Give error notice if any of the fields are not empty or put in incorrectly.
Send data to the [[Database]] if every field is answered correctly and login the user and open up the [[Login Window]]w and will have to login.
# Cancel button

If this button is pressed discard all data in input fields and return to [[Login Window]].