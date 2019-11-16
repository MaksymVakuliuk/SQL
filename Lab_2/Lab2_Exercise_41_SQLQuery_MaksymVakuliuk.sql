/*
41)	Вывести общую сумму поставок книг (использовать поле Cost) и поместить результат в поле с названием Sum_cost,
		выполненных ‘ОАО Луч’ (условие по полю Name_company).
*/


USE DB_Books

SELECT SUM(Purchases.Cost) AS 'Sum_cost' FROM Purchases INNER JOIN Deliveries
ON Deliveries.Code_delivery = Deliveries.Code_delivery 
WHERE Deliveries.Name_company LIKE 'ОАО Луч'
--'Glovo%'