# Derivco-Automation-Assessment

Description
------------
Derivco Company Automation Assesment with Slot Machine of Specflow Example Automation by using Selenium with C#

Usage
------------
For compile this example you need to use Visual Studio 2012 or more. (Which is support .Net Framework version 4.5)

You can open project by double click solution file (Derivco-Automation-Assessment.sln) or Visual Studio -> File -> Open -> Project/Solution

For running the test cases you need to add "NUnit Test Adapter" extension from the menu Tools -> Extensions and Updates.

After the download this extension you can see Test Cases from the menu Test -> Windows -> Test Explorer



Example view of Test Explorer:

![alt text](http://oi63.tinypic.com/efrnh4.jpg)

Project Structure
------------
Under the solution "Derivco-Automation-Assesment" there are 5 types of packages they are:

![alt text](http://3.1m.yt/6Fsqp7q.png)

#### 1) Utilities

This includes critical classes for the automation such as Driver.cs and Constants.cs

In Driver.cs, project bringing the setting about Webdriver and implement it.

This settings are Browser type and options about the browser.

Also browser type is generic which can change from App.config file with "browser" attribute.

For example, CI Tool (such as Jenkins) can change this attribute as value="firefox" and create parallel executions with different browsers: 
```
<!-- Choose Expected Browser -->
<add key="browser" value="chrome" />
```

#### 2) Helpers

This include helping classes for the automation such as Base.cs and Actions.cs

In Base.cs, certain methods to interaction with current browsers as: Opening Page, Closing Page, Wait, Finding Element in Page, Click Element in Page, Highlight Element in Page, Getting Text of Element in Page, Getting Value of Element in Page, Setting Value of Element in Page, Clearing Value of Element in Page.

These methods are derive from Selenium Framework and uses functionalities of them.

In Actions.cs, there are several methods which include specifical activities of given assessment as: 
Getting Current Balance, Setting Current Balance,  Setting Test Data, Getting the All Numbers which are show in page after spinning.


#### 3) Features

This include files which is written in Gherking language. Type of file is ending with ".feature"

Main purpose of writing with Gherkin language is make the automation with an employee who has low know-how in software languages.

For Example of Gherking language in my assessment:

```gherkin
Feature: Spin
This feature controlling for spin to the slot machine.

Scenario: Spin and check numbers are display
	Given I open page
	When  I spin
	Then  I see numbers are display

Scenario: Spin and check current balance is decreasing
	Given I open page
	When  I spin
	Then  I see current balance is decreasing
```


#### 4) Steps

This include code-behind part of Gherkin language which is written C#

Assertions performing in this classes.

Example Assert:
```
Assert.AreEqual(GetNumbers().Count, 15);
```


#### 5) TestTask

Executing file(assessment itself): TestTask.html file


NuGet Packages
------------

##### What is NuGet?

NuGet is the package manager for the Microsoft development platform including .NET. The NuGet client tools provide the ability to produce and consume packages. The NuGet Gallery is the central package repository used by all package authors and consumers.

In this project there are only use 3 packages: Selenium, Specflow,NUnit

```xml
<?xml version="1.0" encoding="utf-8"?>
<packages>
  <package id="Selenium.WebDriver" version="3.4.0" targetFramework="net45" />
  <package id="SpecFlow" version="2.1.0" targetFramework="net45" />
  <package id="NUnit" version="3.6.1" targetFramework="net45" />
</packages>
```
##### Selenium
Selenium is a set of different software tools each with a different approach to supporting browser automation. These tools are highly flexible, allowing many options for locating and manipulating elements within a browser, and one of its key features is the support for automating multiple browser platforms. This package contains the .NET bindings for the newer, more concise and object-based Selenium WebDriver API, which uses native OS-level events to manipulate the browser, bypassing the JavaScript sandbox, and does not require the Selenium Server to automate the browser.

##### Specflow
SpecFlow aims at bridging the communication gap between domain experts and developers by binding business readable behavior specifications to the underlying implementation. Specflow mission is to provide a pragmatic and frictionless approach to Acceptance Test Driven Development (TDD) and Behavior Driven Development (BDD) for .NET projects today.

##### NUnit
NUnit is an evolving, open source framework designed for writing and running tests in Microsoft .NET programming languages. NUnit, like JUnit, is an aspect of Test Driven Development (TDD), which is part of a larger software design paradigm known as Extreme Programming (XP). NUnit features a fluent assert syntax, parameterized, generic and theory tests and is user-extensible.

About
------------
This example project helps you understand Specflow, Selenium, NUnit and C# language

You can find more information in this webpage: http://www.specflow.org/

You can find more example in this repository: https://github.com/techtalk/SpecFlow


Help
------------
If you got any questions don't hesitate to contact with me: [celikgumusdag@gmail.com](mailto:celikgumusdag@gmail.com)


About Company
------------
Derivco is an IT company that provides gaming and software development services. The company was founded in 1996 and is based in Durban, South Africa.

Currently it is an international company which has offices all around the world such as Australia, England, Estonia, Hong Kong, Isle of Man, South Africa, Sweden

You can find more information in this offical webpage: https://www.derivco.com or linkedin page : https://www.linkedin.com/company/derivco


License
------------
This repository is open source software provided under the Apache License 2.0. 

This documentation and other similar content use the Creative Commons Attribution 3.0 Unported license. 

Most libraries and tools in the ecosystem are also open source, but they may use different licenses.
