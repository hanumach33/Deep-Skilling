USE EmployeeManagementSystem;
GO

DROP TRIGGER IF EXISTS trg_AfterSalaryUpdate;

GO

SELECT
    name
FROM sys.triggers
WHERE name = 'trg_AfterSalaryUpdate';

GO
