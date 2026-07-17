# Exercise 2 - Secure an API Endpoint Using JWT

## Objective

Learn how to secure an ASP.NET Core Web API endpoint using JWT Authentication and the `[Authorize]` attribute.

---

## Scenario

You have already implemented JWT authentication. Now, you need to protect sensitive API endpoints so that only authenticated users with a valid JWT token can access them.

---

## Topics Covered

- JWT Authentication
- Authorization
- Authorize Attribute
- Protected APIs
- Bearer Token
- HTTP Status Codes

---

## Prerequisites

- Exercise 1 completed
- JWT configured in Program.cs
- Valid login endpoint

---

## Project Structure

```
JwtAuthenticationAPI
│
├── Controllers
│      ├── AuthController.cs
│      └── SecureController.cs
│
├── Program.cs
└── appsettings.json
```

---

## Tasks

- Create a protected controller.
- Secure an endpoint using `[Authorize]`.
- Generate a JWT token.
- Access the protected endpoint using the token.
- Verify unauthorized access without a token.

---

## Files

- SecureController.cs
