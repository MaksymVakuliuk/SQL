USE Gifts_for_children_of_employees

--1.	Вивести список всіх працівників, у яких є хоча б одна дитина.
DROP PROCEDURE employeers_with_children

GO
CREATE PROCEDURE employeers_with_children AS
BEGIN
SELECT LastName FROM Employeers 
LEFT JOIN ChildrenOfEmployeers
ON Employeers.Employee_ID = ChildrenOfEmployeers.Employee_ID
END

EXEC employeers_with_children

--2.	Вивести список дітей, яким відали подарунки в вказаний період.
DROP PROCEDURE children_with_gifts

GO
CREATE PROCEDURE children_with_gifts AS
BEGIN
SELECT FirstName FROM ChildrenOfEmployeers  AS COF LEFT JOIN Gifts AS GFT
ON COF.Child_ID = GFT.Child_ID 
WHERE GFT.Date_of_issue IS NOT NULL
END

EXEC children_with_gifts 


--3.	Вивести список батьків, я яких є неповнолітні діти.
DROP PROCEDURE employeers_with_adult_cildren

GO
CREATE PROCEDURE employeers_with_adult_children AS
BEGIN
	SELECT Employeers.FirstName, Employeers.LastName FROM Employeers LEFT JOIN ChildrenOfEmployeers AS COE
	ON COE.Employee_ID = Employeers.Employee_ID
	WHERE DATEDIFF(YEAR, COE.Date_of_birth, GetDate()) > 18
END

EXEC employeers_with_adult_children

--4.	Вивести інформацію о подарунках з вартістю більше вказаного числа, відсортованих по даті.

DROP PROCEDURE gifts_value_more
GO
CREATE PROCEDURE gifts_value_more @Value AS INT AS
BEGIN
	SELECT * FROM Gifts 
	WHERE Gift_value > @Value ORDER BY Date_of_issue ASC
END

EXEC gifts_value_more 100