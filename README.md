# EventManager
Test application I created to practice coding it's unfinished. It creates an XML file and saves events to it. The program parses out the XML file back into a list to make it easy to make changes. There is a login setup and two roles admin and normal users.


If you're pulling this directly the first thing you'll want to do is create an Admin. 
It is assumed that the first user created will be the admin if the Data.xml file does not exist.

The next user you create will be a normal user and will have a different form show after you login. 

Admin can create events and they will populate in the event list.
When filling in a new event the event rank should be numerical but I didn't add any validation so it can crash there. 

If ever you forget any passwords you'll have to start over by deleting the Data.xml file because the passwords are hashed. 

