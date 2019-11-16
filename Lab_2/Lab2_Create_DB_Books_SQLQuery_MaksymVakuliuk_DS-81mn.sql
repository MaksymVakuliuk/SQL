CREATE DATABASE DB_Books 
ON 
(
	NAME = 'DB_Books',
	FILENAME = 'D:\Programming\MSSQL\Lab_2\DB_Books.mdf',
	SIZE = 10 MB,
	MAXSIZE = 100 MB,
	FILEGROWTH = 10 MB
)
LOG ON
(
	NAME = 'Log_DB_Books',
	FILENAME = 'D:\Programming\MSSQL\Lab_2\Log_DB_Books.Ldf',
	SIZE = 5 MB,
	MAXSIZE = 50 MB,
	FILEGROWTH = 5 MB
)

USE DB_Books

CREATE TABLE Authors
(
	Code_author INT PRIMARY KEY,
	Name_authors Char(30),
	Birthday DateTime --why is it not Date?
)

CREATE TABLE Publishing_house
(
	Code_publish Int PRIMARY KEY,
	Publish Char(30),
	City Char(20)
)

CREATE TABLE Books
(
	Code_book Int PRIMARY KEY,
	Title_book Char(40),
	Code_author Int FOREIGN KEY REFERENCES Authors(Code_author), 
	Pages Int,
	Code_publish Int FOREIGN KEY REFERENCES Publishing_house(Code_publish)
)

CREATE TABLE Deliveries
(
	Code_delivery Int PRIMARY KEY,
	Name_delivery Char(30),
	Name_company Char(20),
	Address Char(100),
	Phone BigInt, --why do we use BigInt?
	INN Char(13)
)

CREATE TABLE Purchases
(
	Code_book Int FOREIGN KEY REFERENCES Books(Code_book),
	Date_order Date,
	Code_delivery Int FOREIGN KEY REFERENCES Deliveries(Code_delivery),
	Type_purchase Bit,
	Cost Money,--(float)
	Amount Int,
	Code_purchase Int
)


