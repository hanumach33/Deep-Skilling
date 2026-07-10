Exercise 11 - Handle Errors in a Stored Procedure

Objective

Learn how to handle runtime errors in a Stored Procedure using TRY...CATCH and return a custom error message.

Scenario

The Employee Management System requires a stored procedure to update an employee's salary. If an error occurs during execution, the procedure should catch the error and return a meaningful message.

Topics Covered

- CREATE PROCEDURE
- TRY...CATCH
- UPDATE
- ERROR_MESSAGE()
- RAISERROR

Tasks

- Create a stored procedure named sp_UpdateEmployeeSalaryWithErrorHandling.
- Accept EmployeeID and Salary as parameters.
- Update the employee salary.
- Handle runtime errors using TRY...CATCH.
- Return a custom error message.
- Execute the stored procedure.

Files

- solution.sql
