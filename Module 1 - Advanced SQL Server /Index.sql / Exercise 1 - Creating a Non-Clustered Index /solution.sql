USE OnlineRetailStore;
GO

SELECT *
FROM Products
WHERE ProductName = 'Laptop';

GO

CREATE NONCLUSTERED INDEX IX_Products_ProductName
ON Products(ProductName);

GO

SELECT *
FROM Products
WHERE ProductName = 'Laptop';

GO
