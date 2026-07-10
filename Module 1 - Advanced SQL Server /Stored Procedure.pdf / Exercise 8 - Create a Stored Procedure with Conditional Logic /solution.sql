USE EmployeeManagementSystem;
GO

CREATE PROCEDURE sp_GiveBonus
    @DepartmentID INT,
    @BonusAmount DECIMAL(10,2)
AS
BEGIN
    IF EXISTS
    (
        SELECT *
        FROM Employees
        WHERE DepartmentID = @DepartmentID
    )
    BEGIN
        UPDATE Employees
        SET Salary = Salary + @BonusAmount
        WHERE DepartmentID = @DepartmentID;
    END
END;
GO

EXEC sp_GiveBonus
    @DepartmentID = 1,
    @BonusAmount = 500.00;

GO

SELECT *
FROM Employees
WHERE DepartmentID = 1;

GO
