SELECT ContactName, City, * FROM Customers

SELECT * FROM Products where CategoryId = 3 

SELECT * FROM Products where CategoryID = 1 Order by ProductName

SELECT Count(*) FROM Products WHERE CategoryID = 2


-- Having use for count(*),sum,avg...
-- Where use for all data

SELECT Count(*),CategoryID FROM Products WHERE UnitPrice >20  GROUP BY CategoryID 


SELECT p.ProductID, p.ProductName, p.UnitPrice, c.CategoryName, * FROM Products p
JOIN Categories c on p.CategoryID = c.CategoryID
where p.UnitPrice > 10 order by p.ProductName

SELECT * FROM Products p 
LEFT JOIN [Order Details] od on p.ProductID = od.ProductID
LEFT JOIN Orders o on od.OrderID = o.OrderID

SELECT * FROM Customers c 
LEFT JOIN Orders o on c.CustomerID = o.CustomerID
WHERE o.CustomerID is null

-- DTO = Data Transformation Object - 