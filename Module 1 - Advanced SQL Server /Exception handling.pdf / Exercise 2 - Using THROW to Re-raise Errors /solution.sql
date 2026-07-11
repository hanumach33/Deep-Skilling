USE EmployeeManagementSystem;
GO

ALTER PROCEDURE AddEmployee
    @EmployeeID INT,
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Email VARCHAR(100),
    @Salary DECIMAL(10,2),
    @DepartmentID INT
AS
BEGIN
    BEGIN TRY

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
            @EmployeeID,
            @FirstName,
            @LastName,
            @Email,
            @Salary,
            @DepartmentID
        );

    END TRY

    BEGIN CATCH

        INSERT INTO AuditLog
        (
            Action,
            ErrorMessage
        )
        VALUES
        (
            'Add Employee',
            ERROR_MESSAGE()
        );

        THROW;

    END CATCH
END;
GO

EXEC AddEmployee
    1,
    'John',
    'Doe',
    'john@example.com',
    5000.00,
    1;

GO

SELECT *
FROM AuditLog;

GO
