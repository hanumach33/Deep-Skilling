USE EmployeeManagementSystem;
GO

DROP FUNCTION IF EXISTS fn_CalculateBonus;

GO

SELECT
    name
FROM sys.objects
WHERE
    type = 'FN'
    AND name = 'fn_CalculateBonus';

GO
