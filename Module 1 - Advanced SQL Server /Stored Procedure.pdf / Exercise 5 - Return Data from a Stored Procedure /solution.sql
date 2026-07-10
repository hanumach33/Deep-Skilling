USE EmployeeManagementSystem;
GO

CREATE PROCEDURE sp_GetEmployeeCount
    @DepartmentID INT
AS
BEGIN
    SELECT
        COUNT(*) AS TotalEmployees
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;
GO

EXEC sp_GetEmployeeCount
    @DepartmentID = 1;
GO

EXEC sp_GetEmployeeCount
    @DepartmentID = 2;
GO

EXEC sp_GetEmployeeCount
    @DepartmentID = 3;
GO
