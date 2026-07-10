USE EmployeeManagementSystem;
GO

DROP PROCEDURE IF EXISTS sp_InsertEmployee;
GO

SELECT
    name
FROM sys.procedures
WHERE name = 'sp_InsertEmployee';

GO
