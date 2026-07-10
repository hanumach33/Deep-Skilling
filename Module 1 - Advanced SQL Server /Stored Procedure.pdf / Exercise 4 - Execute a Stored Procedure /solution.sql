USE EmployeeManagementSystem;
GO

EXEC sp_GetEmployeesByDepartment
    @DepartmentID = 1;

GO

EXEC sp_GetEmployeesByDepartment
    @DepartmentID = 2;

GO

EXEC sp_GetEmployeesByDepartment
    @DepartmentID = 3;

GO
