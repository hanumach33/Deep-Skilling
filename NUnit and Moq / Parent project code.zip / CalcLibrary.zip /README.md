# CalcLibrary

## Objective

CalcLibrary is a .NET Standard Class Library that implements a simple calculator.

It supports the four basic arithmetic operations and maintains the result of the latest calculation.

## Project Type

.NET Standard 2.0 Class Library

## Classes

- SimpleCalculator

## Features

- Addition
- Subtraction
- Multiplication
- Division
- Clear previous result
- Retrieve last calculated result

## Methods

- Addition(double,double)
- Subtraction(double,double)
- Multiplication(double,double)
- Division(double,double)
- AllClear()

## Property

- GetResult

## Exception

Division throws an `ArgumentException` when the divisor is zero.
