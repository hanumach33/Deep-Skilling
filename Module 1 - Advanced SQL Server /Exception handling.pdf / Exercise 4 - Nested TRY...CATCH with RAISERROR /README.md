Exercise 4 - Nested TRY...CATCH with RAISERROR

Objective

Learn how to use nested TRY...CATCH blocks with RAISERROR in SQL Server.

Scenario

The Employee Management System requires a stored procedure to transfer an employee to another department. If the department does not exist, a custom error should be raised, logged, and re-thrown.

Topics Covered

- CREATE PROCEDURE
- Nested TRY...CATCH
- RAISERROR
- THROW
- UPDATE
- Error Logging

Tasks

- Create a stored procedure named TransferEmployee.
- Accept EmployeeID and DepartmentID as parameters.
- Validate the DepartmentID.
- Update the employee's department.
- Log any errors into AuditLog.
- Re-raise the error using THROW.

Files

- solution.sql
