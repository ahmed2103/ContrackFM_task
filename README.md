CompanyAPI – Technical Assessment

This project is an ASP.NET Core Web API that demonstrates database design, SQL scripts, and RESTful APIs for managing employees, departments, customers, orders, and products.

📌 Prerequisites

Before running the project, make sure you have:

.NET SDK 8.0

SQL Server (LocalDB or SQL Server Express is fine)

Visual Studio 2022 or any IDE that supports .NET

Git

🗄️ Database Setup

Open SQL Server Management Studio (SSMS).

Create a new database named:

CREATE DATABASE Company;


Navigate to the SQL_scripts folder in the repository.

Execute the SQL scripts in order to:

Create tables:

Departments

Employees

Customers

Products

Orders

Insert the required seed data.

⚠️ Make sure tables with foreign keys (e.g. Departments) are created before dependent tables (e.g. Employees).

🔧 Configuration

Open appsettings.json.

Update the connection string to match your SQL Server instance:

"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=Company;Trusted_Connection=True;TrustServerCertificate=True"
}

▶️ Run the Project

From the project root directory:

dotnet restore
dotnet run


Or simply run the project from Visual Studio using IIS Express or https.

🌐 Available APIs

Once the application is running, you can test the APIs using Swagger:

https://localhost:{port}/swagger

Endpoints

Get All Employees
GET /api/employees

Get All Customers with Orders
GET /api/customers

Get All Orders with Product Names
GET /api/orders

Sum of Employee Salaries by Department
GET /api/salary-sum
