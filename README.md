Задание2: В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

create table Products ( prod_id INT PRIMARY KEY AUTO_INCREMENT, productsName VARCHAR(30) );

INSERT INTO Products (productsName) VALUES ('сосиски'),('молоко'),('хлеб'),('йогурт'),('булочка'),('кекс'),('конфета');

select * FROM Products;

create table ProdCat ( prodCat_id INT PRIMARY KEY AUTO_INCREMENT, prod_id VARCHAR(30), cat_id VARCHAR(30) );

INSERT INTO ProdCat (prod_id,cat_id) VALUES (1,1),(2,2),(3,3),(4,2),(5,3),(6,3);

Select * FROM ProdCat;

create table Category ( cat_id INT PRIMARY KEY AUTO_INCREMENT, categoryName VARCHAR(30) );

INSERT INTO Category (categoryName) VALUES ('мясное'),('молочка'),('хлебобулочное'),('сладкое');

Select * FROM Category;

SELECT cat.categoryName as 'Имя категории', prod.productsName as 'Имя продукта' FROM Products prod LEFT JOIN ProdCat prodcat ON prod.prod_id = prodcat.prod_id LEFT JOIN Category cat ON cat.cat_id = prodcat.cat_id
