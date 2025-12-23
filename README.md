# Company Database API - Setup Instructions

## Prerequisites
- SQL Server (or MySQL/PostgreSQL depending on your database choice)
- .NET 6.0 or later
- Git

## Database Setup

1. **Create the Database**
```sql
   -- Run the script in: /sql/01_create_database.sql
```

2. **Create Tables**
```sql
   -- Run the scripts in order:
   -- /sql/02_create_tables.sql
   -- /sql/03_insert_data.sql
```

3. **Update Connection String**
   - Open `appsettings.json`
   - Update the connection string with your database credentials:
```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost;Database=Company;User Id=your_username;Password=your_password;"
   }
```

## Running the API

1. **Clone the Repository**
```bash
   git clone <repository-url>
   cd <project-folder>
```

2. **Restore Dependencies**
```bash
   dotnet restore
```

3. **Run the Application**
```bash
   dotnet run
```

4. **Access the API via Swagger**
   - Open your browser and navigate to: `https://localhost:7068/swagger/index.html`
   - You will see the interactive Swagger UI with all available endpoints

## API Endpoints

Test all endpoints directly from Swagger UI:

- `GET /api/Employee` - Get all employees with department names
- `GET /api/Customer` - Get all customers with their orders
- `GET /api/Orders` - Get all orders with product names (descending order)
- `GET /api/salary-sum` - Get sum of salaries by department

## Using Swagger UI

1. Click on any endpoint to expand it
2. Click the "Try it out" button
3. Click "Execute" to test the API
4. View the response below with status code and data

## Alternative Testing Methods

