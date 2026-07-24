# UserManagerLib

## Objective

UserManagerLib is a .NET Class Library used to validate a user's PAN Card number during user creation.

The PAN Card number is mandatory and must contain exactly 10 characters.

## Project Type

Class Library (.NET Framework)

## Class

- UserManager

## Method

```csharp
bool CreateUser(string panCardNo)
```

## Validation Rules

- PAN Card number cannot be null.
- PAN Card number cannot be empty.
- PAN Card number must contain exactly 10 characters.

## Exceptions

| Exception | Condition |
|-----------|-----------|
| NullReferenceException | PAN Card number is null or empty |
| FormatException | PAN Card number length is not 10 |

## Features

- PAN validation
- Exception handling
- User creation
