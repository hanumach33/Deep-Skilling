USE EmployeeManagementSystem;
GO

CREATE PROCEDURE sp_UpdateSalaryTransaction
    @EmployeeID INT,
    @Salary DECIMAL(10,2)
AS
BEGIN
    BEGIN TRY

        BEGIN TRANSACTION;

        UPDATE Employees
        SET Salary = @Salary
        WHERE EmployeeID = @EmployeeID;

        COMMIT TRANSACTION;

    END TRY

    BEGIN CATCH

        ROLLBACK TRANSACTION;

        THROW;

    END CATCH
END;
GO

EXEC sp_UpdateSalaryTransaction
    @EmployeeID = 2,
    @Salary = 6500.00;

GO

SELECT *
FROM Employees
WHERE EmployeeID = 2;

GO
