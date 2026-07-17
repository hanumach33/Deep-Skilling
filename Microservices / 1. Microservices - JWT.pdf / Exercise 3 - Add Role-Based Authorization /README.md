# Exercise 3 - Add Role-Based Authorization

## Objective

Learn how to implement Role-Based Authorization in an ASP.NET Core Web API using JWT tokens.

---

## Scenario

You want to allow only users with the **Admin** role to access specific endpoints. The user's role is stored as a claim inside the JWT token, and the API validates that role before granting access.

---

## Topics Covered

- JWT Claims
- Role-Based Authorization
- ClaimTypes.Role
- Authorize Attribute
- Roles
- Protected Endpoints

---

## Prerequisites

- Exercise 1 completed
- Exercise 2 completed
- JWT Authentication configured

---

## Project Structure

```

JwtAuthenticationAPI
│
├── Controllers
│     ├── AuthController.cs
│     └── AdminController.cs
│
├── Program.cs
└── appsettings.json

```

---

## Tasks

- Add role claim while generating JWT.
- Create an Admin controller.
- Protect endpoint using `[Authorize(Roles = "Admin")]`.
- Test with Admin token.

---

## Files

- AuthController.cs
- AdminController.cs
