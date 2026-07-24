# AccountsManagerLib

## Objective

AccountsManagerLib is a .NET Class Library that validates user credentials.

The library validates whether the supplied User ID and Password are correct and returns an appropriate message. It also throws an exception when mandatory inputs are not provided.

## Project Type

Class Library (.NET Framework 4.7.2)

## Class

- AccountsManager

## Method

```csharp
string ValidateUser(string userId, string password)
```

## Features

- Validates mandatory inputs.
- Authenticates predefined users.
- Returns welcome message for valid users.
- Returns invalid credential message for incorrect credentials.
- Throws `FormatException` for null or empty inputs.

## Valid Users

| User ID | Password |
|----------|----------|
| user_11 | secret@user11 |
| user_22 | secret@user22 |
