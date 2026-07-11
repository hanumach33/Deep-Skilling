Lab 12 - Navigating Circular References

Objective

Learn how to prevent circular reference issues when returning related data using Entity Framework Core 8.0.

Scenario

The Retail Inventory System exposes product data through an API. Since Product and Category reference each other, serialization can cause circular reference errors. This lab demonstrates using DTOs and JsonIgnore to solve the problem.

Topics Covered

- DTO Pattern
- LINQ Projection
- Select()
- JsonIgnore
- Navigation Properties

Tasks

- Create a ProductDTO class.
- Project entities into DTOs.
- Retrieve data using LINQ.
- Prevent circular references using JsonIgnore.

Files

- ProductDTO.cs
- Category.cs
- Product.cs
- Program.cs
