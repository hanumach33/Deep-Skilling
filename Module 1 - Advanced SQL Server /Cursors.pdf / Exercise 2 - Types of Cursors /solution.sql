USE EmployeeManagementSystem;
GO

DECLARE
    @EmployeeID INT,
    @FirstName VARCHAR(50);

DECLARE StaticCursor CURSOR STATIC
FOR
SELECT
    EmployeeID,
    FirstName
FROM Employees;

OPEN StaticCursor;

FETCH NEXT FROM StaticCursor
INTO
    @EmployeeID,
    @FirstName;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT 'STATIC Cursor : '
        + CAST(@EmployeeID AS VARCHAR(10))
        + ' - '
        + @FirstName;

    FETCH NEXT FROM StaticCursor
    INTO
        @EmployeeID,
        @FirstName;
END;

CLOSE StaticCursor;
DEALLOCATE StaticCursor;

GO

DECLARE
    @EmployeeID INT,
    @FirstName VARCHAR(50);

DECLARE DynamicCursor CURSOR DYNAMIC
FOR
SELECT
    EmployeeID,
    FirstName
FROM Employees;

OPEN DynamicCursor;

FETCH NEXT FROM DynamicCursor
INTO
    @EmployeeID,
    @FirstName;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT 'DYNAMIC Cursor : '
        + CAST(@EmployeeID AS VARCHAR(10))
        + ' - '
        + @FirstName;

    FETCH NEXT FROM DynamicCursor
    INTO
        @EmployeeID,
        @FirstName;
END;

CLOSE DynamicCursor;
DEALLOCATE DynamicCursor;

GO

DECLARE
    @EmployeeID INT,
    @FirstName VARCHAR(50);

DECLARE ForwardOnlyCursor CURSOR FORWARD_ONLY
FOR
SELECT
    EmployeeID,
    FirstName
FROM Employees;

OPEN ForwardOnlyCursor;

FETCH NEXT FROM ForwardOnlyCursor
INTO
    @EmployeeID,
    @FirstName;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT 'FORWARD_ONLY Cursor : '
        + CAST(@EmployeeID AS VARCHAR(10))
        + ' - '
        + @FirstName;

    FETCH NEXT FROM ForwardOnlyCursor
    INTO
        @EmployeeID,
        @FirstName;
END;

CLOSE ForwardOnlyCursor;
DEALLOCATE ForwardOnlyCursor;

GO

DECLARE
    @EmployeeID INT,
    @FirstName VARCHAR(50);

DECLARE KeysetCursor CURSOR KEYSET
FOR
SELECT
    EmployeeID,
    FirstName
FROM Employees;

OPEN KeysetCursor;

FETCH NEXT FROM KeysetCursor
INTO
    @EmployeeID,
    @FirstName;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT 'KEYSET Cursor : '
        + CAST(@EmployeeID AS VARCHAR(10))
        + ' - '
        + @FirstName;

    FETCH NEXT FROM KeysetCursor
    INTO
        @EmployeeID,
        @FirstName;
END;

CLOSE KeysetCursor;
DEALLOCATE KeysetCursor;

GO
