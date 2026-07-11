USE EmployeeManagementSystem;
GO

CREATE TABLE EmployeeChanges
(
    ChangeID INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeID INT,
    OldSalary DECIMAL(10,2),
    NewSalary DECIMAL(10,2),
    ChangeDate DATETIME
);

GO

CREATE TRIGGER trg_AfterSalaryUpdate
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
END;

GO

UPDATE Employees
SET Salary = 7500.00
WHERE EmployeeID = 1;

GO

SELECT *
FROM EmployeeChanges;

GOUSE EmployeeManagementSystem;
GO

CREATE TABLE EmployeeChanges
(
    ChangeID INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeID INT,
    OldSalary DECIMAL(10,2),
    NewSalary DECIMAL(10,2),
    ChangeDate DATETIME
);

GO

CREATE TRIGGER trg_AfterSalaryUpdate
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
END;

GO

UPDATE Employees
SET Salary = 7500.00
WHERE EmployeeID = 1;

GO

SELECT *
FROM EmployeeChanges;

GO
