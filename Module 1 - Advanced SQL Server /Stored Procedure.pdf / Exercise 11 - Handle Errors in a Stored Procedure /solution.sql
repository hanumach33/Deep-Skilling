USE EmployeeManagementSystem;
GO

CREATE PROCEDURE sp_UpdateEmployeeSalaryWithErrorHandling
    @EmployeeID INT,
    @Salary DECIMAL(10,2)
AS
BEGIN
    BEGIN TRY

        UPDATE Employees
        SET Salary = @Salary
        WHERE EmployeeID = @EmployeeID;

        PRINT 'Employee salary updated successfully.';

    END TRY

    BEGIN CATCH

        RAISERROR
        (
            'Error occurred while updating employee salary.',
            16,
            1
        );

        PRINT ERROR_MESSAGE();

    END CATCH
END;
GO

EXEC sp_UpdateEmployeeSalaryWithErrorHandling
    @EmployeeID = 1,
    @Salary = 7000.00;

GO

SELECT *
FROM Employees
WHERE EmployeeID = 1;

GO
