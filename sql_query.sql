CREATE TABLE Products (
Id INT PRIMARY KEY,
"Name" TEXT
);

CREATE TABLE Categories (
Id INT PRIMARY KEY,
"Name" TEXT
);

CREATE TABLE ProductCategories (
ProductId INT FOREIGN KEY REFERENCES Products(Id),
CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO Products
VALUES
(1, 'Buckwheat'),
(2, 'Rice'),
(3, 'Apple'),
(4, 'Pear'),
(5, 'Chips'),
(6, 'Chocolate'),
(7, 'Avocado'),
(8, 'Bananas'),
(9, 'Beer');

INSERT INTO Categories
VALUES
(1, 'Cereals'),
(2, 'Low - calorie'),
(3, 'Sweets'),
(4, 'Fruits');

INSERT INTO ProductCategories
VALUES
(1, 2),
(2, 2),
(3, 2),
(4, 2),
(5, 3),
(6, 3),
(1, 1),
(2, 1),
(8, 4),
(8, 2),
(3, 4),
(4, 4),
(3, 3);

SELECT Pr."Name", Cat."Name"
FROM Products Pr
LEFT JOIN ProductCategories PrCat
ON Pr.Id = PrCat.ProductId
LEFT JOIN Categories Cat
ON PrCat.CategoryId = Cat.Id;