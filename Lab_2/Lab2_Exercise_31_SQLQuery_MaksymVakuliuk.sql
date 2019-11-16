/*
31) Вывести суммарную стоимость партии одноименных книг (использовать поля Amount и Cost)
		и название книги (поле Title_book) в каждой поставке.
*/

USE DB_Books

SELECT Books.Title_book, Purchases.Cost , Purchases.Amount, 
Purchases.Amount*Purchases.Cost AS 'Сумма заказа'  
FROM  Purchases INNER JOIN Books
ON Purchases.Code_book = Books.Code_book