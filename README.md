#Store Management System

A desktop application for managing a small store's daily operations, built with C# (Windows Forms) and SQL Server.

Features
Role-based login — Admin and Employee accounts with different permissions
Product management — add, update, delete, and search products by category
Sales processing — record sales with automatic stock deduction and out-of-stock protection
Reports — sales history with totals, and a low-stock report for restocking

#Tech Stack
C# / .NET (Windows Forms)
SQL Server (ADO.NET)

## Project Structure

| File | Description |
|---|---|
| `Program.cs` | Application entry point |
| `DbConn.cs` | Centralized database connection handling |
| `FormLogin.cs` | User authentication |
| `FormMain.cs` | Main dashboard / navigation |
| `FormProducts.cs` | Product CRUD and search |
| `FormSales.cs` | Sales entry and stock updates |
| `FormReports.cs` | Sales and low-stock reports |

#Getting Started
Clone the repository
Update the StoreDB connection string in App.config
Run the provided SQL script to create the database schema
Build and run the solution in Visual Studio
