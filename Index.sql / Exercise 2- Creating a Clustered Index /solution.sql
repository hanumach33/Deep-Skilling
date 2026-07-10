USE OnlineRetailStore;
GO

SELECT *
FROM Products
WHERE ProductID = 101;

GO

CREATE CLUSTERED INDEX IX_Products_ProductID
ON Products(ProductID);

GO

SELECT *
FROM Products
WHERE ProductID = 101;

GO
