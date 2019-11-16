/*
36)	Вывести среднюю стоимость (использовать поле Cost)
	и среднее количество экземпляров книг (использовать поле Amount) в одной поставке,
	где автором книги является ‘Акунин’ (условие по полю Name_author). 
*/

USE DB_Books

SELECT AVG(Purchases.Cost) AS 'Средняя стоимость', AVG(Purchases.Amount) AS 'Среднее количество екземляров' FROM Books 
INNER JOIN Purchases
ON Books.Code_book = Purchases.Code_book
INNER JOIN Authors
ON Authors.Code_author = Books.Code_author
WHERE Authors.Name_authors = 'Акунин'
--WHERE Authors.Name_authors = 'Джоан Роулинг'