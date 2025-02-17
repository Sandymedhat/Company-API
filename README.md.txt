# Company API

This repository contains the implementation of the Company API with the required endpoints, along with SQL files for creating the database and tables.

## Setup Instructions

**Clone the repository**:
   ```bash
   git clone https://github.com/sandymedhat/Company-API.git
   cd Company-API

-Create the database and tables
 1- Open your SQL Server Management Studio (SSMS) or any SQL client.
 2- Execute the SQL files provided in the sql/ directory to create the database and tables.

-Set up the project:
 1- Open the project in your preferred IDE (e.g., Visual Studio Code).
 2- Update the connection string in appsettings.json to match your database configuration.
 3- Restore the NuGet packages.

-Run the API:
 1- Start the API project.
 2- Test the endpoints using tools like Postman or Swagger.

**Endpoints**

-Get All Employees:
 1- Endpoint: GET /api/employees
 2- Output: List of all employees with their ID, name, and department name.

-Get All Customers with Orders
 1- Endpoint: GET /api/customers
 2- Output: List of all customers with their ID, name, all associated orders (ID, Amount), product names, and total costs.

-Get All Orders with Product Names
 1- Endpoint: GET /api/orders
 2- Output: List of all orders with product names, ordered by order ID in descending order.

-Sum of Employee Salaries by Department
  *Endpoint: GET /api/salary-sum
  *Output: Sum of employees’ salaries for each department.