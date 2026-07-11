Exercise 1 - Basic TRY...CATCH for Error Logging

Objective

Learn how to use TRY...CATCH blocks to handle exceptions and log errors in SQL Server.

Scenario

The Employee Management System requires a stored procedure to insert employee records. If an error occurs during insertion, the error should be logged into the AuditLog table.

Topics Covered

- CREATE PROCEDURE
- TRY...CATCH
- INSERT
- ERROR_MESSAGE()
- Error Logging

Tasks

- Create a stored procedure named AddEmployee.
- Insert a new employee record.
- Handle exceptions using TRY...CATCH.
- Log the error message into AuditLog.
- Execute the stored procedure.

Files

- solution.sql
