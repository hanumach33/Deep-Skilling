USE OnlineRetailStore;
GO

WITH CustomerOrderCounts AS
(
    SELECT
        o.CustomerID,
        COUNT(o.OrderID) AS OrderCount
    FROM Orders o
    GROUP BY o.CustomerID
)

SELECT
    c.CustomerID,
    c.CustomerName,
    c.Email,
    c.Region,
    coc.OrderCount
FROM CustomerOrderCounts coc
INNER JOIN Customers c
    ON coc.CustomerID = c.CustomerID
WHERE coc.OrderCount > 3
ORDER BY
    coc.OrderCount DESC,
    c.CustomerName;

GO
