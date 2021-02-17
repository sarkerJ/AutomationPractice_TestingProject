# AutomationPractice Web Testing Project
## Project Goal

The goal of this project was to create a testing framework to allow the use of automation testing for the **automationpractice.com** website. The framework used **Selenium**, **Specflow** and **Gherkin** language in order to create behaviour based tests. 

* **Selenium** a tool for automating browser interactions
* **Specflow** is used to create feature files that map to user stories
* **Gherkin** is a means to create human readable acceptance criteria's for user stories that represent the user steps on the website

## Framework

The framework was designed using the POM (page object model) to represent the individual webpages as an object so that particular elements could be hooked upon and provided with an action that simulates a user behaviour. By following this approach, tests could be created based on the user actions and check whether or not the website was able to respond in the correct manner. 

![POMs](https://github.com/sarkerJ/AutomationPractice_TestingProject/blob/main/Images/POMs.JPG)

Each POM (page object model) class was injected with a **IWebDriver** interface, so that the interaction between the elements could be reproduced. Once the webpages were created, **Specflow** features classes were written which mapped to the test cases (acceptance criteria's) for a given user story using Gherkin Syntax.  

![DependencyInjection](https://github.com/sarkerJ/AutomationPractice_TestingProject/blob/main/Images/Dependency%20injection.JPG)

![gherkinScenarios](https://github.com/sarkerJ/AutomationPractice_TestingProject/blob/main/Images/Gherkin%20scenarios.JPG)

Once the scenarios were created, Specflow was used to generate the step classes and methods that mapped onto the different parts of those Scenario lines using the GIVEN, WHEN, THEN syntax. An example of this can be seen below

![stepclass](https://github.com/sarkerJ/AutomationPractice_TestingProject/blob/main/Images/stepclass.JPG)

The overall class diagram shown below can be used to get an overview of the entire framework of this solution

![classdiagram](https://github.com/sarkerJ/AutomationPractice_TestingProject/blob/main/Images/classdiagram.JPG)

## Pickles

To provide a better overview of the Scenarios and the tests which pass a **pickle extension** and a test report in the format of VSTest were used to create a HTML page that displayed all of the required information.

* One of the main reason a VSTest format was used for the test report is because the Specflow Commandline extension does not support the a command that generates a report in the NUnit format

To find the index.html  you will have to navigate inside the **Visual Studio project folder** and Open the **Pickles** folder. 

Below you can see the landing page of the Index.html file and some of the information that it provides.

![pickleshomepage](https://github.com/sarkerJ/AutomationPractice_TestingProject/blob/main/Images/Pickles%20webpage.JPG)