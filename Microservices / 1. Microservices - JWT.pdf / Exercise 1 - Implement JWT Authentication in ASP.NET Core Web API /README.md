# Exercise 1 - Implement JWT Authentication in ASP.NET Core Web API

## Objective

Learn how to implement JWT (JSON Web Token) authentication in an ASP.NET Core Web API microservice.

---

## Scenario

You are building a secure microservice that authenticates users and issues JWT tokens after successful login. The generated token is then used to access protected API endpoints.

---

## Topics Covered

- ASP.NET Core Web API
- JWT Authentication
- Authentication Middleware
- Authorization
- Claims
- Token Generation

---

## Prerequisites

- .NET 8 SDK
- Visual Studio 2022 / VS Code
- Postman

---

## Install Required Package

```bash
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
```

---

## Project Structure

```
JwtAuthenticationAPI
│
├── Controllers
│     └── AuthController.cs
│
├── Models
│     ├── LoginModel.cs
│     └── User.cs
│
├── appsettings.json
├── Program.cs
└── JwtAuthenticationAPI.csproj
```

---

## Tasks

- Create ASP.NET Core Web API project.
- Configure JWT settings.
- Create LoginModel.
- Generate JWT token after successful login.
- Return JWT token to client.
- Use JWT authentication middleware.

---

## Files

- appsettings.json
- Program.cs
- Models/LoginModel.cs
- Models/User.cs
- Controllers/AuthController.cs
