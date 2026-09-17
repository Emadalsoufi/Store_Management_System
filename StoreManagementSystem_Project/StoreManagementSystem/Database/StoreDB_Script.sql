/* =====================================================
   Store Management System - Database Script
   Event Driven Programming - Part 6
   Safe to run more than once (does not drop existing data)
   ===================================================== */

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'StoreDB')
BEGIN
    CREATE DATABASE StoreDB;
END
GO

USE StoreDB;
GO

IF OBJECT_ID(N'dbo.Users', N'U') IS NULL
BEGIN
    CREATE TABLE Users (
        UserID INT PRIMARY KEY IDENTITY(1,1),
        FullName NVARCHAR(100) NOT NULL,
        Username NVARCHAR(50) NOT NULL UNIQUE,
        Password NVARCHAR(50) NOT NULL,
        UserType NVARCHAR(20) NOT NULL
    );
END
GO

IF OBJECT_ID(N'dbo.Categories', N'U') IS NULL
BEGIN
    CREATE TABLE Categories (
        CategoryID INT PRIMARY KEY IDENTITY(1,1),
        CategoryName NVARCHAR(50) NOT NULL
    );
END
GO

IF OBJECT_ID(N'dbo.Products', N'U') IS NULL
BEGIN
    CREATE TABLE Products (
        ProductID INT PRIMARY KEY IDENTITY(1,1),
        ProductName NVARCHAR(100) NOT NULL,
        CategoryID INT FOREIGN KEY REFERENCES Categories(CategoryID),
        Price MONEY NOT NULL,
        Quantity INT NOT NULL
    );
END
GO

IF OBJECT_ID(N'dbo.Sales', N'U') IS NULL
BEGIN
    CREATE TABLE Sales (
        SaleID INT PRIMARY KEY IDENTITY(1,1),
        ProductID INT FOREIGN KEY REFERENCES Products(ProductID),
        Quantity INT NOT NULL,
        Total MONEY NOT NULL,
        SaleDate DATETIME NOT NULL DEFAULT GETDATE(),
        UserName NVARCHAR(50)
    );
END
GO

IF NOT EXISTS (SELECT 1 FROM Users)
BEGIN
    INSERT INTO Users (FullName, Username, Password, UserType) VALUES
    ('Admin User', 'admin', '12345', 'Admin'),
    ('Employee One', 'emp1', '12345', 'Employee');
END
GO

IF NOT EXISTS (SELECT 1 FROM Categories)
BEGIN
    INSERT INTO Categories (CategoryName) VALUES
    ('Food'), ('Drinks'), ('Cleaning'), ('Electronics');
END
GO

IF NOT EXISTS (SELECT 1 FROM Products)
BEGIN
    INSERT INTO Products (ProductName, CategoryID, Price, Quantity) VALUES
    ('Rice 5kg', 1, 12.50, 50),
    ('Cola 1.5L', 2, 1.25, 100),
    ('Dish Soap', 3, 2.75, 40),
    ('LED Bulb', 4, 3.00, 60),
    ('Sugar 1kg', 1, 2.00, 8);
END
GO
