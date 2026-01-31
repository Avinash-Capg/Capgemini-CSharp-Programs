create Database Assess1DB

CREATE TABLE Sales_Raw
(
    OrderID INT,
    OrderDate VARCHAR(20),
    CustomerName VARCHAR(100),
    CustomerPhone VARCHAR(20),
    CustomerCity VARCHAR(50),
    ProductNames VARCHAR(200),  
    Quantities VARCHAR(100),    
    UnitPrices VARCHAR(100),     
    SalesPerson VARCHAR(100)
);


INSERT INTO Sales_Raw VALUES

(101, '2024-01-05', 'Ravi Kumar', '9876543210', 'Chennai',
 'Laptop,Mouse', '1,2', '55000,500', 'Anitha'),

(102, '2024-01-06', 'Priya Sharma', '9123456789', 'Bangalore',
 'Keyboard,Mouse', '1,1', '1500,500', 'Anitha'),

(103, '2024-01-10', 'Ravi Kumar', '9876543210', 'Chennai',
 'Laptop', '1', '54000', 'Suresh'),

(104, '2024-02-01', 'John Peter', '9988776655', 'Hyderabad',
 'Monitor,Mouse', '1,1', '12000,500', 'Anitha'),

(105, '2024-02-10', 'Priya Sharma', '9123456789', 'Bangalore',
 'Laptop,Keyboard', '1,1', '56000,1500', 'Suresh');


--1st Question
CREATE TABLE Customers (
    CustomerID INT IDENTITY PRIMARY KEY,
    CustomerName VARCHAR(100),
    CustomerPhone VARCHAR(20),
    CustomerCity VARCHAR(50)
);

CREATE TABLE SalesPersons (
    SalesPersonID INT IDENTITY PRIMARY KEY,
    SalesPersonName VARCHAR(100)
);

CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    OrderDate DATE,
    CustomerID INT,
    SalesPersonID INT,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    FOREIGN KEY (SalesPersonID) REFERENCES SalesPersons(SalesPersonID)
);

CREATE TABLE Products (
    ProductID INT IDENTITY PRIMARY KEY,
    ProductName VARCHAR(100),
    UnitPrice DECIMAL(10,2)
);

CREATE TABLE OrderDetails (
    OrderID INT,
    ProductID INT,
    Quantity INT,
    UnitPrice DECIMAL(10,2),
    PRIMARY KEY (OrderID, ProductID),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);





--2nd Question
WITH OrderTotals AS (
    SELECT
        OrderID,
        SUM(CAST(q.value AS INT) * CAST(p.value AS INT)) AS TotalSales
    FROM Sales_Raw
    CROSS APPLY STRING_SPLIT(Quantities, ',') q
    CROSS APPLY STRING_SPLIT(UnitPrices, ',') p
    GROUP BY OrderID
)
SELECT OrderID, TotalSales
FROM (
    SELECT *,
           DENSE_RANK() OVER (ORDER BY TotalSales DESC) AS rnk
    FROM OrderTotals
) t
WHERE rnk = 3;


--3rd Question
SELECT SalesPerson,
       SUM(CAST(q.value AS INT) * CAST(p.value AS INT)) AS TotalSales
FROM Sales_Raw
CROSS APPLY STRING_SPLIT(Quantities, ',') q
CROSS APPLY STRING_SPLIT(UnitPrices, ',') p
GROUP BY SalesPerson
HAVING SUM(CAST(q.value AS INT) * CAST(p.value AS INT)) > 60000;


--4th Question
WITH CustomerTotals AS (
    SELECT CustomerName,
           SUM(CAST(q.value AS INT) * CAST(p.value AS INT)) AS TotalSpent
    FROM Sales_Raw
    CROSS APPLY STRING_SPLIT(Quantities, ',') q
    CROSS APPLY STRING_SPLIT(UnitPrices, ',') p
    GROUP BY CustomerName
)
SELECT CustomerName, TotalSpent
FROM CustomerTotals
WHERE TotalSpent >
      (SELECT AVG(TotalSpent) FROM CustomerTotals);



--5th Question
SELECT
    UPPER(CustomerName) AS CustomerName,
    MONTH(CAST(OrderDate AS DATE)) AS OrderMonth
FROM Sales_Raw
WHERE CAST(OrderDate AS DATE)
      BETWEEN '2024-01-01' AND '2024-01-31';