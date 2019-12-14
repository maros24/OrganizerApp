# OrganizerApp


## Dear Collaborators!

A bit of information about solution structure and work with branch.

We have 4 Projects:

-"**Organizer**" project is the highest layer. There is a Run method. It refers to "Menu" project.

-"**Menu**" project is a 'UI' layer. There are classes with methods for displaying menu and some helpers. It refers to "BusinessLogic" project.

-"**BusinessLogic**" project is a layer for classes which we use to execute some actions. It refers to "Models" project.

-"**Models**" project is the lowest layer. There are basic classes for dataModel (eg class Weather for storage data from json)


### HELPER FOR GIT (recommendation)

1. When you cloned the repository and you are on master branch, execute:

> git checkout devBranch

2. Open **Visual Studio** (or **VsCode**) and you can see the project with base functional from **devBranch**

3. Then execute below command to create your branch

> git checkout -b myBranch

4. That command will create a new branch and checkout to this

5. So work on this branch. When you finish your development, execute:

> git add -A

> git commit -m "message of your commit"

> git status (for checking is everything okay)

> git push origin myBranch

6. Then go to GitHub and create a new pull request to **devBranch**. 

The URL of pull request send to others.



