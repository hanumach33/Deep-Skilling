USE EmployeeManagementSystem;
GO

CREATE PROCEDURE BatchInsertEmployees
AS
BEGIN
    BEGIN TRY

        BEGIN TRANSACTION;

        INSERT INTO Employees
        (
            EmployeeID,
            FirstName,
            LastName,
            Email,
            Salary,
            DepartmentID
        )
        VALUES
        (
            10,
            'Rahul',
            'Sharma',
            'rahul@example.com',
            5000.00,
            1
        );

        INSERT INTO Employees
        (
            EmployeeID,
            FirstName,
            LastName,
            Email,
            Salary,
            DepartmentID
        )
        VALUES
        (
            11,
            'Priya',
            'Verma',
            'priya@example.com',
            6000.00,
            2
        );

        COMMIT TRANSACTION;

    END TRY

    BEGIN CATCH

        ROLLBACK TRANSACTION;

        INSERT INTO AuditLog
        (
            Action,
            ErrorMessage
        )
        VALUES
        (
            'Batch Insert Employees',
            ERROR_MESSAGE()
        );

        THROW;

    END CATCH
END;
GO

EXEC BatchInsertEmployees;

GO

SELECT *
FROM Employees;

GO

SELECT *
FROM AuditLog;

GO
