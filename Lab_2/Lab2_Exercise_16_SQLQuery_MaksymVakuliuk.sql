/*
	16) Вывести список названий книг (поле Title_book) и количество страниц (поле Pages) из таблицы Books,
		у которых объем в страницах укладывается в диапазон 200 – 300 (условие по полю Pages).
*/

USE DB_Books
SELECT Title_book, Pages FROM Books
WHERE Pages BETWEEN 200 AND 300