USE master;
GO;

IF DB_ID (N'Shop') IS NOT NULL
    DROP DATABASE [Shop];
GO;
CREATE DATABASE [Shop] COLLATE Cyrillic_General_CI_AS;
GO;

USE [Shop]
GO;

CREATE TABLE [Products] (
    [Id_product] INTEGER IDENTITY,
    [Name] NVARCHAR(64) NOT NULL,
    CONSTRAINT [PK_Product_Id] PRIMARY KEY ([Id_product]),
    CONSTRAINT [UQ_Product_Name] UNIQUE ([Name])
);
GO;

CREATE TABLE [Categories] (
    [Id_сategory] INTEGER IDENTITY,
    [Name] NVARCHAR(64) NOT NULL,
    CONSTRAINT [PK_Category_Id] PRIMARY KEY ([Id_сategory]),
    CONSTRAINT [UQ_Category_Name] UNIQUE ([Name])
);
GO;

CREATE TABLE [Categories_Products] (
    [Id_product] INTEGER NOT NULL,
    [Id_сategory] INTEGER NOT NULL,
    PRIMARY KEY ([Id_product], [Id_сategory]),
    CONSTRAINT [FK_Products_To_Categories] FOREIGN KEY ([Id_product]) REFERENCES [Products]([Id_product]),
    CONSTRAINT [FK_Categories_To_Products] FOREIGN KEY ([Id_сategory]) REFERENCES [Categories]([Id_сategory])
);
GO;

INSERT INTO [Categories] (Name)
VALUES
    (N'Категория 1'),
    (N'Категория 2'),
    (N'Категория 3'),
    (N'Категория 4'),
    (N'Категория 5');
GO;

INSERT INTO [Products] (Name)
VALUES
    (N'Товар 1'),
    (N'Товар 2'),
    (N'Товар 3'),
    (N'Товар 4'),
    (N'Товар 5'),
    (N'Товар 6'),
    (N'Товар 7'),
    (N'Товар 8'),
    (N'Товар 9'),
    (N'Товар 10'),
    (N'Товар 11'),
    (N'Товар 12'),
    (N'Товар 13');
GO;

INSERT INTO [Categories_Products]
VALUES
    (1, 1),
    (1, 2),
    (1, 3),
    (2, 4),
    (2, 5),
    (3, 1),
    (3, 3),
    (4, 1),
    (5, 2),
    (6, 5);
GO;

-- Вариант 1
SELECT (P.Name + ' - ' + ISNULL(C.Name, N'Без категории')) AS 'Product - Category'
FROM Products AS P
    LEFT JOIN Categories_Products AS CP ON P.Id_product = CP.Id_product
    LEFT JOIN Categories C on C.Id_сategory = CP.Id_сategory;

-- Вариант 2
SELECT (P.Name + ISNULL(' - ' + C.Name, '')) AS 'Product - Category'
FROM Products AS P
    LEFT JOIN Categories_Products AS CP ON P.Id_product = CP.Id_product
    LEFT JOIN Categories C on C.Id_сategory = CP.Id_сategory;
