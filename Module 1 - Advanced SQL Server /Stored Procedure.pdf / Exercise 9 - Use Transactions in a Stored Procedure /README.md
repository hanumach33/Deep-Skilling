Exercise 9 - Use Transactions in a Stored Procedure

 Objective

Learn how to use transactions in a Stored Procedure to ensure data integrity during database operations.

Scenario

The Employee Management System requires a stored procedure to update an employee's salary using a transaction. If the update is successful, the transaction is committed; otherwise, it is rolled back.

Topics Covered

- CREATE PROCEDURE
- BEGIN TRANSACTION
- COMMIT TRANSACTION
- ROLLBACK TRANSACTION
- UPDATE
- TRY...CATCH

Tasks

- Create a stored procedure named sp_UpdateSalaryTransaction.
- Accept EmployeeID and Salary as parameters.
- Update the employee salary inside a transaction.
- Commit the transaction if successful.
- Roll back the transaction if an error occurs.

## Files

- solution.sql
