Lab 13 - Query Caching and Tracking Behavior

Objective

Learn how to optimize read-only queries in Entity Framework Core 8.0 using AsNoTracking() and Compiled Queries.

Scenario

The Retail Inventory System generates frequent read-only reports. To improve performance, the application should disable change tracking and use compiled queries for repeated operations.

Topics Covered

- AsNoTracking()
- Compiled Queries
- EF.CompileAsyncQuery()
- LINQ
- Query Optimization

Tasks

- Retrieve products using AsNoTracking().
- Create a compiled query.
- Execute the compiled query.
- Display the results.

Files

- Program.cs
