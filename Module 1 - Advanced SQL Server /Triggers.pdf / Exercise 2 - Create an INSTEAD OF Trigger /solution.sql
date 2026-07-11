USE EmployeeManagementSystem;
GO

CREATE TRIGGER trg_PreventEmployeeDelete
ON Employees
INSTEAD OF DELETE
AS
BEGIN
    RAISERROR
    (
        'Employee records cannot be deleted.',
        16,
        1
    );
END;

GO

DELETE
FROM Employees
WHERE EmployeeID = 1;

GO

SELECT *
FROM Employees;

GO
