USE OnlineRetailStore;
GO

-- GROUPING SETS

SELECT
    c.Region,
    p.Category,
    SUM(od.Quantity) AS TotalQuantity
FROM Orders o
INNER JOIN OrderDetails od
    ON o.OrderID = od.OrderID
INNER JOIN Customers c
    ON o.CustomerID = c.CustomerID
INNER JOIN Products p
    ON od.ProductID = p.ProductID
GROUP BY GROUPING SETS
(
    (c.Region, p.Category),
    (c.Region),
    (p.Category),
    ()
)
ORDER BY
    c.Region,
    p.Category;
GO


-- ROLLUP

SELECT
    c.Region,
    p.Category,
    SUM(od.Quantity) AS TotalQuantity
FROM Orders o
INNER JOIN OrderDetails od
    ON o.OrderID = od.OrderID
INNER JOIN Customers c
    ON o.CustomerID = c.CustomerID
INNER JOIN Products p
    ON od.ProductID = p.ProductID
GROUP BY ROLLUP
(
    c.Region,
    p.Category
)
ORDER BY
    c.Region,
    p.Category;
GO


-- CUBE

SELECT
    c.Region,
    p.Category,
    SUM(od.Quantity) AS TotalQuantity
FROM Orders o
INNER JOIN OrderDetails od
    ON o.OrderID = od.OrderID
INNER JOIN Customers c
    ON o.CustomerID = c.CustomerID
INNER JOIN Products p
    ON od.ProductID = p.ProductID
GROUP BY CUBE
(
    c.Region,
    p.Category
)
ORDER BY
    c.Region,
    p.Category;
GO
