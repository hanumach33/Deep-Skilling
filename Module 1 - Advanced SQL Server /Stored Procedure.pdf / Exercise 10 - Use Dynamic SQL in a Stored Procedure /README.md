Exercise 10 - Use Dynamic SQL in a Stored Procedure

Objective

Learn how to create a Stored Procedure that uses Dynamic SQL to retrieve employee details based on flexible filter criteria.

Scenario

The Employee Management System requires a stored procedure that allows users to search employees using different columns such as EmployeeID, FirstName, LastName, DepartmentID, or Salary.

Topics Covered

- CREATE PROCEDURE
- Dynamic SQL
- sp_executesql
- Parameters
- EXEC

Tasks

- Create a stored procedure named sp_SearchEmployees.
- Accept FilterColumn and FilterValue as parameters.
- Build the SQL query dynamically.
- Execute the dynamic SQL statement.
- Retrieve matching employee records.

Files

- solution.sql
