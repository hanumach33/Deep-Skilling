Lab 9 - Seeding Data During Migrations

Objective

Learn how to seed initial data into the database using Entity Framework Core 8.0 during migrations.

Scenario

The Retail Inventory System requires default categories and products to be inserted automatically when the database is created.

Topics Covered

- OnModelCreating()
- HasData()
- Data Seeding
- EF Core Migrations

Tasks

- Override OnModelCreating().
- Seed Categories.
- Seed Products.
- Create a new migration.
- Apply the migration.
- Verify the seeded data.

Files

- AppDbContext.cs
- MigrationCommands.txt
