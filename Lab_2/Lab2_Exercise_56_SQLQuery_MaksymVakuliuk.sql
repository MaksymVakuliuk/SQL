/*
	56) Вывести список книг (поле Title_book), которые были поставлены поставщиком ‘ЗАО Квантор’
		(условие по полю Name_company). 
*/

USE DB_Books

SELECT Books.Title_book FROM Books 
INNER JOIN Purchases
ON Books.Code_book = Purchases.Code_book
INNER JOIN Deliveries
ON Deliveries.Code_delivery = Purchases.Code_delivery
WHERE Deliveries.Name_company = 'ЗАО Квантор'
--WHERE Deliveries.Name_company = 'Glovo incorporate'