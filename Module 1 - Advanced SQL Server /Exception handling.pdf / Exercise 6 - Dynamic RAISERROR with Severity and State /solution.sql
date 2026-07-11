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

        IF @Salary < 0
        BEGIN
            RAISERROR
            (
                'Salary cannot be negative.',
                16,
                1
            );
        END

        IF @Salary < 1000
        BEGIN
            RAISERROR
            (
                'Warning: Salary is below the recommended minimum.',
                10,
                1
            );
        END

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
    20,
    'Alice',
    'Thomas',
    'alice@example.com',
    800.00,
    1;

GO

EXEC AddEmployee
    21,
    'Mark',
    'Wilson',
    'mark@example.com',
    -500.00,
    2;

GO

SELECT *
FROM AuditLog;

GO
