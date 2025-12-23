Company Database API - Setup Instructions
Prerequisites

SQL Server (or MySQL/PostgreSQL depending on your database choice)
.NET 6.0 or later
Git

Database Setup

Create the Database

sql   -- Run the script in: /sql/01_create_database.sql

Create Tables

sql   -- Run the scripts in order:
   -- /sql/02_create_tables.sql
   -- /sql/03_insert_data.sql

Update Connection String

Open appsettings.json
Update the connection string with your database credentials:



json   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost;Database=Company;User Id=your_username;Password=your_password;"
   }
Running the API

Clone the Repository

bash   git clone <repository-url>
   cd <project-folder>

Restore Dependencies

bash   dotnet restore

Run the Application

bash   dotnet run

Access the API via Swagger

Open your browser and navigate to: https://localhost:7068/swagger/index.html
You will see the interactive Swagger UI with all available endpoints



API Endpoints
Test all endpoints directly from Swagger UI:

GET /api/employees - Get all employees with department names
GET /api/customers - Get all customers with their orders
GET /api/orders - Get all orders with product names (descending order)
GET /api/salary-sum - Get sum of salaries by department

Using Swagger UI

Click on any endpoint to expand it
Click the "Try it out" button
Click "Execute" to test the API
View the response below with status code and data
