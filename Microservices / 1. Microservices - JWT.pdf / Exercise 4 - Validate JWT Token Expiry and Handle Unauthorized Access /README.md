# Exercise 4 - Validate JWT Token Expiry and Handle Unauthorized Access

## Objective

Learn how to detect expired JWT tokens and return custom responses when authentication fails.

---

## Scenario

Your ASP.NET Core Web API should identify expired or invalid JWT tokens and respond gracefully by adding custom response headers or messages.

---

## Topics Covered

- JWT Bearer Events
- Token Expiry Validation
- Unauthorized Access
- SecurityTokenExpiredException
- Custom Response Headers
- Authentication Middleware

---

## Prerequisites

- Exercise 1 completed
- Exercise 2 completed
- Exercise 3 completed
- JWT Authentication configured

---

## Project Structure

JwtAuthenticationAPI
│
├── Controllers
│     ├── AuthController.cs
│     ├── SecureController.cs
│     └── AdminController.cs
│
├── Program.cs
└── appsettings.json

---

## Tasks

- Configure JWT Bearer Events.
- Detect expired JWT tokens.
- Return custom response headers.
- Test expired and invalid tokens.
- Verify unauthorized responses.

---

## Files

- Program.cs
