USE EmployeeManagementSystem;
GO

CREATE VIEW vw_EmployeeFullName
AS
SELECT
    e.EmployeeID,
    e.FirstName + ' ' + e.LastName AS FullName,
    d.DepartmentName
FROM Employees e
INNER JOIN Departments d
    ON e.DepartmentID = d.DepartmentID;

GO

SELECT *
FROM vw_EmployeeFullName;

GO
