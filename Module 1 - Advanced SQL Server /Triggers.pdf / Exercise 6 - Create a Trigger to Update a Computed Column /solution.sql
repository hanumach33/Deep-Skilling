USE EmployeeManagementSystem;
GO

ALTER TABLE Employees
ADD AnnualSalary DECIMAL(10,2);

GO

CREATE TRIGGER trg_UpdateAnnualSalary
ON Employees
AFTER UPDATE
AS
BEGIN
    UPDATE e
    SET AnnualSalary = i.Salary * 12
    FROM Employees e
    INNER JOIN inserted i
        ON e.EmployeeID = i.EmployeeID;
END;

GO

UPDATE Employees
SET Salary = 6500.00
WHERE EmployeeID = 1;

GO

SELECT
    EmployeeID,
    FirstName,
    LastName,
    Salary,
    AnnualSalary
FROM Employees;

GO
