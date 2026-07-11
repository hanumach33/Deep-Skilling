USE EmployeeManagementSystem;
GO

ALTER TRIGGER trg_AfterSalaryUpdate
ON Employees
AFTER UPDATE
AS
BEGIN
    INSERT INTO EmployeeChanges
    (
        EmployeeID,
        OldSalary,
        NewSalary,
        ChangeDate
    )
    SELECT
        d.EmployeeID,
        d.Salary,
        i.Salary,
        GETDATE()
    FROM deleted d
    INNER JOIN inserted i
        ON d.EmployeeID = i.EmployeeID
    WHERE d.Salary <> i.Salary;

    PRINT 'Employee salary updated successfully.';
END;

GO

UPDATE Employees
SET Salary = 8000.00
WHERE EmployeeID = 2;

GO

SELECT *
FROM EmployeeChanges;

GO
