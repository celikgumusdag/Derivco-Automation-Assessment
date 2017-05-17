# Derivco-Automation-Assessment

Description
------------
Derivco Company Automation Assesment with Slot Machine of Specflow Example Automation by using Selenium with C#

Usage
------------
For compile this example you need to use Visual Studio 2012 or more. (Which is support .Net Framework version 4.5)

For running the test cases you need to add "NUnit Test Adapter" from the menu Tools -> Extensions and Updates.

After the download this extension you can see Test Cases from the menu Test -> Windows -> Test Explorer

Example view of Test Explorer:

![alt text](http://oi63.tinypic.com/efrnh4.jpg)

Project Structure
------------
Under the solution "Derivco-Automation-Assesment" there are 5 types of packages they are:


#### 1) Utilities

This includes critical classes for the automation such as Driver.cs and Constants.cs

In Driver.cs, project bringing the setting about Webdriver and implement it.

This settings are Browser type and options about the browser.

Also browser type is generic which can change from App.config file with "browser" attribute.


#### 2) Helpers

This include helping classes for the automation such as Base.cs and Actions.cs

In Base.cs, certain methods to interaction with current browsers as: Opening Page, Closing Page, Wait, Finding Element in Page, Click Element in Page, Highlight Element in Page, Getting Text of Element in Page, Getting Value of Element in Page, Setting Value of Element in Page, Clearing Value of Element in Page.

In Actions.cs, there are several methods which include specifical activities of given assessment as: Getting Current Balance, Setting Current Balance,  Setting Test Data, Getting the All Numbers which are show in page after spinning.


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

In this project there are only use 3 packages: Selenium, Specflow,NUnit

```csharp
<?xml version="1.0" encoding="utf-8"?>
<packages>
  <package id="NUnit" version="3.6.1" targetFramework="net45" />
  <package id="Selenium.WebDriver" version="3.4.0" targetFramework="net45" />
  <package id="SpecFlow" version="2.1.0" targetFramework="net45" />
</packages>
```


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
