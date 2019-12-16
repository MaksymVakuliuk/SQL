USE Gifts_for_children_of_employees

ALTER TABLE ChildrenOfEmployeers ALTER COLUMN FirstName NVarChar(20) NOT NULL

ALTER TABLE Employeers ALTER COLUMN LastName NVarChar(20) NOT NULL
ALTER TABLE Employeers ALTER COLUMN FirstName NVarChar(20) NOT NULL
ALTER TABLE Employeers ALTER COLUMN Patronymic NVarChar(20) NOT NULL
ALTER TABLE Employeers ALTER COLUMN Department NVarChar(20) NOT NULL

ALTER DATABASE Gifts_for_children_of_employees
COLLATE Cyrillic_General_CI_AS

USE master
