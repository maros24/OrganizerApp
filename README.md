# OrganizerApp
Repository for the Demo2 application

Dear Collaborators!

A bit of information about solution structure.

We have 4 Projects:

-"Organizer" project is the highest layer. There is a Run method. It refers to "Menu" project.

-"Menu" project is a 'UI' layer. There are classes with methods for displaying menu and some helpers. It refers to "BusinessLogic" project.

-"BusinessLogic" project is a layer for classes which we use to execute some actions. It refers to "Models" project.

-"Models" project is the lowest layer. There are basic classes for dataModel (eg class Weather for storage data from json)
