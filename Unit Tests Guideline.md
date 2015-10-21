# Unit Tests Guideline

## Assembly naming

The unit tests for the `Microsoft.Fruit` assembly live in the `Microsoft.Fruit.Tests` assembly.

In general there should be exactly one unit test assembly for each product runtime assembly. 

## Unit test class naming

Test class names end with Tests and live in the same namespace as the class being tested. 
For example, the unit tests for the `Microsoft.Fruit.Banana` class would be in a `Microsoft.Fruit.Tests.BananaTests` class 
in the test assembly.

## Unit test method naming

Unit test method names must be descriptive about what is being tested, under what conditions, and what the expectations are. Pascal casing and underscores can be used to improve readability. 
The following test names are correct:

```
ParseLanguage_CorrectCulture_ParsesSupportedLanguage
Public_api_arguments_should_have_not_null_annotation
```

The following test names are incorrect:
```
Test1
Constructor
FormatString
GetData
```

## Unit test structure

The contents of every unit test should be split into three distinct stages, optionally separated by these comments:

```
// Arrange  
// Act  
// Assert 
```

The crucial thing here is that the Act stage is exactly one statement. That one statement is nothing more than a call to the one method that you are trying to test. Keeping that one statement as simple as possible is also very important. For example, this is not ideal:

```
var result = myObj.CallSomeMethod(GetComplexParam1(), GetComplexParam2(), GetComplexParam3());
```

This style is not recommended because way too many things can go wrong in this one statement. All the `GetComplexParamN()` calls can throw for a variety of reasons unrelated to the test itself. It is thus unclear to someone running into a problem why the failure occurred.

The ideal pattern is to move the complex parameter building into the Arrange section:
```
// Arrange
var p1 = GetComplexParam1();
var p2 = GetComplexParam2();
var p3 = GetComplexParam3();

// Act
var result = myObj.CallSomeMethod(p1, p2, p3);

// Assert
Assert.AreEqual(1234, result);
```

Now the only reason the line with `CallSomeMethod()` can fail is if the method itself blew up. 
