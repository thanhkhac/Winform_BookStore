USE master;


GO
IF EXISTS (SELECT name from master.dbo.sysdatabases WHERE name = 'BookStore')
BEGIN
ALTER DATABASE BookStore SET SINGLE_USER WITH ROLLBACK IMMEDIATE;

ALTER DATABASE BookStore SET MULTI_USER;
DROP DATABASE BookStore;
END;

GO
CREATE DATABASE BookStore;

GO
USE BookStore


CREATE TABLE Accounts (
	ID int IDENTITY PRIMARY KEY,
    Username varchar(50) not null UNIQUE,
    Password nvarchar(255) NOT NULL,
    IsActive bit DEFAULT 1,
	IsAdmin bit default 0
);

INSERT INTO Accounts (Username, Password, IsAdmin) VALUES (N'thanhcqb2048', N'1234567', 1);
INSERT INTO Accounts (Username, Password) VALUES (N'thanh', N'12345');
INSERT INTO Accounts (Username, Password, IsAdmin) VALUES (N'thanh23', N'12345', 1);

SELECT * FROM Accounts


CREATE TABLE BookTypes(
	ID int PRIMARY KEY IDENTITY(1,1),
	[Name] nvarchar(255)
);

CREATE TABLE Books(
	ID int IDENTITY(1,1) PRIMARY KEY,
	BarCode varchar(200),
	[Name] nvarchar(256) not null,
	[BookTypeID] int FOREIGN KEY REFERENCES BookTypes(ID) ON DELETE SET NULL,
	Author nvarchar(256),
	Quantity int not null,
	Price money not null,
	IsActive bit DEFAULT 1
);

CREATE UNIQUE NONCLUSTERED INDEX IX_Unique_BarCode
    ON Books (BarCode)
    WHERE BarCode IS NOT NULL;

CREATE TABLE BookImgs(
	BookID int FOREIGN KEY REFERENCES Books(ID),
	IMG VARBINARY(MAX),
	PRIMARY KEY (BookID)
)

CREATE TABLE Invoices(
	ID int IDENTITY(1,1) PRIMARY KEY,
	CreatedDate datetime,
	CustomerName nvarchar(max),
	CustomerPhone varchar(255)
);

CREATE TABLE InvoiceDetails(
	ID int FOREIGN KEY REFERENCES Invoices(ID) ON DELETE CASCADE,
	BookID int FOREIGN KEY REFERENCES Books(ID) ON DELETE CASCADE,
	Quantity int,
	EmployeeID int FOREIGN KEY REFERENCES Accounts(ID),
	PRIMARY KEY(ID, BookID)
);



-- Bảng BookTypes
INSERT INTO BookTypes ([Name]) VALUES
('Science Fiction'),
('Mystery'),
('Romance'),
('Fantasy'),
('Thriller');

-- Bảng Books
INSERT INTO Books ([Name], [BookTypeID], Author, Quantity, Price) VALUES
('The Hitchhiker''s Guide to the Galaxy', 1, 'Douglas Adams', 50, 15000.99),
('The Da Vinci Code', 2, 'Dan Brown', 30, 120000.99),
('Pride and Prejudice', 3, 'Jane Austen', 25, 90000.99),
('Harry Potter and the Sorcerer''s Stone', 4, 'J.K. Rowling', 40, 180000.99),
('The Girl with the Dragon Tattoo', 5, 'Stieg Larsson', 35, 14000.99),
('Dune', 4, 'Frank Herbert', 20, 220000.99),
('To Kill a Mockingbird', 3, 'Harper Lee', 28, 11000.99),
('The Lord of the Rings', 5, 'J.R.R. Tolkien', 22, 25000.99),
('The Shining', 1, 'Stephen King', 18, 17000.99),
('1984', 1, 'George Orwell', 15, 130000.99);


INSERT INTO Books ([Name], [BookTypeID], Author, Quantity, Price) VALUES
('The Hitchhiker''s Guide to the Galaxy', 1, 'Douglas Adams', 50, 15000.99),
('The Da Vinci Code', 2, 'Dan Brown', 30, 120000.99),
('Pride and Prejudice', 3, 'Jane Austen', 25, 90000.99),
('Harry Potter and the Sorcerer''s Stone', 4, 'J.K. Rowling', 40, 180000.99),
('The Girl with the Dragon Tattoo', 5, 'Stieg Larsson', 35, 14000.99),
('Dune', 4, 'Frank Herbert', 20, 220000.99),
('To Kill a Mockingbird', 3, 'Harper Lee', 28, 11000.99),
('The Lord of the Rings', 5, 'J.R.R. Tolkien', 22, 25000.99),
('The Shining', 1, 'Stephen King', 18, 17000.99),
('1984', 1, 'George Orwell', 15, 130000.99);


-- Bảng Invoices
INSERT INTO Invoices (CreatedDate, CustomerName, CustomerPhone) VALUES
('2024-03-02', 'John Doe', '123-456-7890'),
('2024-03-03', 'Jane Smith', '987-654-3210');

-- Bảng InvoiceDetails
INSERT INTO InvoiceDetails (ID, BookID, Quantity) VALUES
(1, 1, 2),
(1, 3, 1),
(2, 5, 3)



INSERT INTO Invoices (CreatedDate, CustomerName, CustomerPhone) VALUES
('2024-03-04', 'Alice Johnson', '111-222-3333'),
('2024-03-05', 'Bob Williams', '444-555-6666'),
('2024-03-06', 'Charlie Brown', '777-888-9999'),
('2024-03-07', 'David Davis', '123-456-7890'),
('2024-03-08', 'Emma Taylor', '234-567-8901'),
('2024-03-09', 'Frank Miller', '345-678-9012'),
('2024-03-10', 'Grace Wilson', '456-789-0123'),
('2024-03-11', 'Henry Martinez', '567-890-1234'),
('2024-03-12', 'Isabella Anderson', '678-901-2345'),
('2024-03-13', 'Jack Thomas', '789-012-3456'),
('2024-03-14', 'Karen Jackson', '890-123-4567'),
('2024-03-15', 'Liam White', '901-234-5678'),
('2024-03-16', 'Mia Harris', '012-345-6789'),
('2024-03-17', 'Noah Nelson', '321-432-5432'),
('2024-03-18', 'Olivia King', '432-543-6543'),
('2024-03-19', 'Patrick Scott', '543-654-7654'),
('2024-03-20', 'Quinn Green', '654-765-8765'),
('2024-03-21', 'Rachel Martinez', '765-876-9876'),
('2024-03-22', 'Samuel Carter', '876-987-0987'),
('2024-03-23', 'Taylor White', '987-098-1098');

INSERT INTO InvoiceDetails (ID, BookID, Quantity) VALUES
(3, 2, 3),
(3, 4, 1),
(4, 6, 2),
(4, 8, 1),
(5, 10, 4),
(5, 12, 2),
(6, 14, 3),
(6, 16, 1),
(7, 18, 2),
(7, 20, 1),
(8, 2, 1),
(8, 4, 1),
(9, 6, 1),
(9, 8, 1),
(10, 10, 2),
(10, 12, 1),
(11, 14, 1),
(11, 16, 1),
(12, 18, 3),
(12, 20, 2);












SELECT 
	BO.ID,
	BO.Name,
	BT.Name AS BookType,
	Author,
	Quantity,
	Price
FROM 
	Books BO
	LEFT JOIN BookTypes BT ON BO.BookTypeID = BT.ID
	SELECT * FROM BookTypes

	
UPDATE Books
SET 
	BookTypeID = null,
	Name = 'Nguyen Khac Thanh',
	Author = 'JK',
	Quantity = 1,
	Price = 5
WHERE 
	ID = 1 

SELECT * FROM Books
SELECT * FROM BookImgs
SELECT * FROM InvoiceDetails










