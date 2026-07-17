# Exercise 3 - Custom Exception Filter

## Objective

Learn how to create a custom exception filter in ASP.NET Core Web API to handle unhandled exceptions globally.

---

## Scenario

Create a custom exception filter that:

- Implements `IExceptionFilter`
- Logs exception details into a file
- Returns a custom error response
- Tests the filter using Swagger

---

## Concepts Covered

- IExceptionFilter
- ExceptionContext
- ExceptionResult
- File Logging
- Internal Server Error (500)
- ProducesResponseType

---

## Prerequisites

- ASP.NET Core Web API
- Microsoft.AspNetCore.Mvc.WebApiCompatShim NuGet Package

Install Package

```bash
dotnet add package Microsoft.AspNetCore.Mvc.WebApiCompatShim
```

---

## Files

- Filters/CustomExceptionFilter.cs
- Controllers/EmployeeController.cs
