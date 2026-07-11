Exercise 6 - Dynamic RAISERROR with Severity and State

Objective

Learn how to use RAISERROR with different severity levels and states in SQL Server.

Scenario

The Employee Management System requires validating employee salaries before insertion. If the salary is less than 1000, display a warning. If the salary is negative, raise an error and stop execution.

Topics Covered

- ALTER PROCEDURE
- RAISERROR
- Severity Levels
- State
- TRY...CATCH
- Error Handling

Tasks

- Modify the AddEmployee stored procedure.
- Raise a warning when Salary is less than 1000.
- Raise an error when Salary is negative.
- Insert the employee only if the salary is valid.
- Test the stored procedure.

Files

- solution.sql
