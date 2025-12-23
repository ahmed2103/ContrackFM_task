-- Selecting the Database
USE Company;

-- Departments Insertion
INSERT INTO Departments (ID, Name) VALUES
(1, 'IT'),
(2, 'Operations'),
(3, 'Human resources'),
(4, 'Accounting and Finance'),
(5, 'Research and Development (R&D)');

-- Employees Insertion
INSERT INTO Employees (ID, Name, Salary, Department_Id) VALUES
(1, 'Ahmed',   5000, 3),
(2, 'Mohamed', 4000, 1),
(3, 'Peter',   3000, 2),
(4, 'Clara',   6000, 4),
(5, 'Beeshoy', 7000, 4),
(6, 'Menna',   5500, 2),
(7, 'Gina',    9400, 3);

-- Customers Insertion
INSERT INTO Customers (ID, Name, Address) VALUES
('CI-001', 'Customer 1', 'Cairo'),
('CI-002', 'Customer 2', 'Cairo'),
('CI-003', 'Customer 3', 'Giza'),
('CI-004', 'Customer 4', 'Banha'),
('CI-005', 'Customer 5', 'Alex');

-- Products Insertion
INSERT INTO Products (ID, Name, Cost) VALUES
(100, 'Product 1', 100.05),
(101, 'Product 2', 150.40),
(102, 'Product 3', 800.00),
(103, 'Product 4', 790.50),
(104, 'Product 5', 500.00),
(105, 'Product 6', 200.50);

-- Orders Insertion
INSERT INTO Orders (ID, Customer_Id, Product_Id, Amount) VALUES
('D-01', 'CI-002', 100, 5),
('D-02', 'CI-004', 101, 8),
('D-03', 'CI-004', 103, 4),
('D-04', 'CI-005', 105, 3);