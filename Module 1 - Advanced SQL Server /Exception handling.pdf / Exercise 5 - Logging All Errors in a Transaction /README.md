Exercise 5 - Logging All Errors in a Transaction

Objective

Learn how to use transactions with TRY...CATCH blocks to ensure data integrity and log errors.

Scenario

The Employee Management System requires inserting multiple employee records as a single transaction. If any insert fails, all changes should be rolled back and the error should be logged.

Topics Covered

- CREATE PROCEDURE
- BEGIN TRANSACTION
- COMMIT TRANSACTION
- ROLLBACK TRANSACTION
- TRY...CATCH
- Error Logging

Tasks

- Create a stored procedure named BatchInsertEmployees.
- Insert multiple employee records.
- Wrap the inserts inside a transaction.
- Roll back the transaction if an error occurs.
- Log the error into the AuditLog table.

Files

- solution.sql
