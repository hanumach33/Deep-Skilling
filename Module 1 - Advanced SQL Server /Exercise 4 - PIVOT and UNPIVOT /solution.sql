USE OnlineRetailStore;
GO

SELECT *
INTO #MonthlySales
FROM
(
    SELECT
        p.ProductName,
        DATENAME(MONTH, o.OrderDate) AS SalesMonth,
        od.Quantity
    FROM Orders o
    INNER JOIN OrderDetails od
        ON o.OrderID = od.OrderID
    INNER JOIN Products p
        ON od.ProductID = p.ProductID
) AS SourceTable;

GO

SELECT
    ProductName,
    ISNULL([January],0) AS January,
    ISNULL([February],0) AS February,
    ISNULL([March],0) AS March,
    ISNULL([April],0) AS April,
    ISNULL([May],0) AS May,
    ISNULL([June],0) AS June,
    ISNULL([July],0) AS July,
    ISNULL([August],0) AS August,
    ISNULL([September],0) AS September,
    ISNULL([October],0) AS October,
    ISNULL([November],0) AS November,
    ISNULL([December],0) AS December
INTO #PivotSales
FROM
(
    SELECT
        ProductName,
        SalesMonth,
        Quantity
    FROM #MonthlySales
) AS SalesData
PIVOT
(
    SUM(Quantity)
    FOR SalesMonth IN
    (
        [January],
        [February],
        [March],
        [April],
        [May],
        [June],
        [July],
        [August],
        [September],
        [October],
        [November],
        [December]
    )
) AS PivotTable;

GO

SELECT *
FROM #PivotSales;

GO

SELECT
    ProductName,
    SalesMonth,
    Quantity
FROM #PivotSales
UNPIVOT
(
    Quantity FOR SalesMonth IN
    (
        [January],
        [February],
        [March],
        [April],
        [May],
        [June],
        [July],
        [August],
        [September],
        [October],
        [November],
        [December]
    )
) AS UnPivotTable;

GO

DROP TABLE #MonthlySales;

DROP TABLE #PivotSales;

GO
