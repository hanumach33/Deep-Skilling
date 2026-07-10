USE EmployeeManagementSystem;
GO

CREATE PROCEDURE sp_GetTotalSalary
    @DepartmentID INT,
    @TotalSalary DECIMAL(10,2) OUTPUT
AS
BEGIN
    SELECT
        @TotalSalary = SUM(Salary)
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;
GO

DECLARE @Salary DECIMAL(10,2);

EXEC sp_GetTotalSalary
    @DepartmentID = 1,
    @TotalSalary = @Salary OUTPUT;

SELECT @Salary AS TotalSalary;

GO
