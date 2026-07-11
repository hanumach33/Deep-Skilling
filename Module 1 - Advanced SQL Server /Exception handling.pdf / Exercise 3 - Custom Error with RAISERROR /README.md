Exercise 3 - Custom Error with RAISERROR

Objective

Learn how to use RAISERROR in SQL Server to enforce business rules.

Scenario

The Employee Management System requires that every employee must have a salary greater than zero. If the salary is less than or equal to zero, a custom error should be displayed.

Topics Covered

- ALTER PROCEDURE
- RAISERROR
- TRY...CATCH
- IF...ELSE
- Error Validation

Tasks

- Modify the AddEmployee stored procedure.
- Check if the salary is less than or equal to zero.
- Raise a custom error using RAISERROR.
- Insert the employee only if the salary is valid.
- Execute the stored procedure.

Files

- solution.sql
