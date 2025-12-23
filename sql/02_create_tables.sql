-- Selecting the Database
USE Company;


--2. Tables Creation:
-- Departments table
CREATE TABLE Departments(
	ID INT PRIMARY KEY,
	NAME VARCHAR(50) NOT NULL
)
-- Employees Table
CREATE TABLE Employees(
	ID INT PRIMARY KEY,
	Name VARCHAR(50) NOT NULL,
	Salary INT NOT NULL,
	Department_Id INT NOT NULL REFERENCES Departments(ID)
);

--Customers Table
CREATE TABLE Customers(
	ID VARCHAR(10) PRIMARY KEY,
	Name VARCHAR(50) NOT NULL,
	Address VARCHAR(50) NOT NULL
)

--Products Table
CREATE TABLE Products(
	ID INT PRIMARY KEY,
	Name VARCHAR(50) NOT NULL,
	Cost DECIMAL(10,2) NOT NULL
);

--Orders Table

CREATE TABLE Orders(
	ID VARCHAR(10) PRIMARY KEY,
	Customer_Id VARCHAR(10) NOT NULL REFERENCES Customers(id),
	Product_Id INT NOT NULL REFERENCES Products(ID),
	Amount INT NOT NULL
)
