USE EmployeeManagementSystem;
GO

CREATE PROCEDURE sp_SearchEmployees
    @FilterColumn VARCHAR(50),
    @FilterValue VARCHAR(100)
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX);

    SET @SQL =
    'SELECT *
     FROM Employees
     WHERE ' + QUOTENAME(@FilterColumn) + ' = @Value';

    EXEC sp_executesql
        @SQL,
        N'@Value VARCHAR(100)',
        @Value = @FilterValue;
END;
GO

EXEC sp_SearchEmployees
    @FilterColumn = 'DepartmentID',
    @FilterValue = '3';

GO

EXEC sp_SearchEmployees
    @FilterColumn = 'FirstName',
    @FilterValue = 'John';

GO
