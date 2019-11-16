/*
	51) Вывести список книг (поле Title_book), у которых количество страниц (поле Pages)
		больше среднего количества страниц всех книг в таблице. 
*/

USE DB_Books

SELECT Title_book FROM Books
WHERE Pages < (SELECT AVG(Pages) FROM Books)