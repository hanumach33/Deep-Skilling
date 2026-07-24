# Exercise 1 - Testing Exception Handling

## Objective

Write NUnit test cases to verify that the `CreateUser` method throws the appropriate exceptions for invalid PAN card values and successfully creates a user for valid input.

## Prerequisites

- Visual Studio 2022
- .NET Framework
- NUnit
- NUnit3TestAdapter

## Projects

- UserManagerLib
- UserManagerLib.Tests

## Concepts Covered

- TestFixture
- Test
- Assert.That
- Throws
- Exception Testing
- Single Assertion Rule

## Outcome

Validate that the `CreateUser` method correctly handles `NullReferenceException`, `FormatException`, and successfully creates a user when valid PAN details are provided.
