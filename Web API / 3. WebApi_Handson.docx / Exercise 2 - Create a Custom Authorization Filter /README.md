# Exercise 2 - Create a Custom Authorization Filter

## Objective

Create a custom authorization filter to validate the Authorization header of incoming HTTP requests.

---

## Scenario

Intercept every incoming request to the Employee API and verify:

- Authorization header exists.
- Header contains the word "Bearer".

If validation fails, return an appropriate Bad Request response.

---

## Concepts Covered

- ActionFilterAttribute
- OnActionExecuting()
- Request Headers
- BadRequestObjectResult
- Custom Filters
- Authorization Header Validation

---

## Prerequisites

- ASP.NET Core Web API
- EmployeeController
- Filters Folder

---

## Files

- Filters/CustomAuthFilter.cs
- Controllers/EmployeeController.cs
