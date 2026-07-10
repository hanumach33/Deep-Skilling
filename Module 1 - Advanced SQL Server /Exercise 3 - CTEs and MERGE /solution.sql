USE OnlineRetailStore;
GO
WITH CalendarCTE AS
(
    SELECT CAST('2025-01-01' AS DATE) AS CalendarDate

    UNION ALL

    SELECT DATEADD(DAY, 1, CalendarDate)
    FROM CalendarCTE
    WHERE CalendarDate < '2025-01-31'
)

SELECT CalendarDate
FROM CalendarCTE
OPTION (MAXRECURSION 31);

GO


CREATE TABLE StagingProducts
(
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);

GO



INSERT INTO StagingProducts
VALUES
(101,'Laptop Pro','Electronics',85000.00),
(102,'Wireless Mouse','Electronics',1200.00),
(205,'Office Chair','Furniture',6500.00);

GO


MERGE Products AS Target

USING StagingProducts AS Source

ON Target.ProductID = Source.ProductID

WHEN MATCHED THEN

UPDATE SET

    Target.ProductName = Source.ProductName,
    Target.Category = Source.Category,
    Target.Price = Source.Price

WHEN NOT MATCHED BY TARGET THEN

INSERT
(
    ProductID,
    ProductName,
    Category,
    Price
)

VALUES
(
    Source.ProductID,
    Source.ProductName,
    Source.Category,
    Source.Price
);

GO


SELECT *
FROM Products
ORDER BY ProductID;

GO


DROP TABLE StagingProducts;

GO
