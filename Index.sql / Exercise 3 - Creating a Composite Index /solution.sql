USE OnlineRetailStore;
GO

SELECT *
FROM Products
WHERE Category = 'Electronics'
AND Price > 5000;

GO

CREATE NONCLUSTERED INDEX IX_Products_Category_Price
ON Products(Category, Price);

GO

SELECT *
FROM Products
WHERE Category = 'Electronics'
AND Price > 5000;

GO
