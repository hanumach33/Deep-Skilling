Exercise 2 - Using THROW to Re-raise Errors

Objective

Learn how to use THROW in SQL Server to re-raise an exception after logging the error.

Scenario

The Employee Management System requires a stored procedure that logs any error into the AuditLog table and then re-throws the exception so that the calling application is notified.

Topics Covered

- CREATE PROCEDURE
- TRY...CATCH
- THROW
- ERROR_MESSAGE()
- Error Logging

Tasks

- Modify the AddEmployee stored procedure.
- Log the error into the AuditLog table.
- Re-raise the exception using THROW.
- Execute the stored procedure.
- Verify the AuditLog entries.

Files

- solution.sql
