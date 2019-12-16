CREATE DATABASE Gifts_for_children_of_employees
ON
(
	NAME = 'Gifts_for_children_of_employees',
	FILENAME = 'C:\MSSQL\Lab_1\ProgramingGifts_for_children_of_employees.mdf',
	SIZE = 10 MB,
	MAXSIZE = 100 MB,
	FILEGROWTH = 10 MB
)
LOG ON
(
	NAME = 'Log_Gifts_for_children_of_employees',
	FILENAME = 'C:\MSSQL\Lab_1\Log_Gifts_for_children_of_employees.ldf',
	SIZE = 5 MB,
	MAXSIZE = 50 MB,
	FILEGROWTH = 5 MB
)

USE Gifts_for_children_of_employees

CREATE TABLE Employeers
(
	Employee_ID SmallInt IDENTITY PRIMARY KEY,
	LastName VarChar(20) NOT NULL, 
	FirstName VarChar(20) NOT NULL,
	Patronymic VarChar(20) NOT NULL,
	Position  VarChar(20) NOT NULL,
	Department VarChar(20) NOT NULL,
	Hiring_date Date NOT NULL
)

CREATE TABLE ChildrenOfEmployeers
(
	Employee_ID SmallInt FOREIGN KEY REFERENCES Employeers(Employee_ID) NOT NULL,
	FirstName VarChar(20) NOT NULL,
	Date_of_birth Date NOT NULL,
	Child_ID SmallInt IDENTITY PRIMARY KEY NOT NULL
)

CREATE TABLE Gifts
(
	Child_ID SmallInt FOREIGN KEY REFERENCES ChildrenOfEmployeers(Child_ID) NOT NULL,
	Gift_value Int NOT NULL,
	Date_of_issue Date,
	Number_of_issue SmallInt 
)
USE Gifts_for_children_of_employees
ALTER TABLE Gifts ALTER COLUMN Date_of_issue date
ALTER TABLE Gifts ALTER COLUMN Number_of_issue smallint