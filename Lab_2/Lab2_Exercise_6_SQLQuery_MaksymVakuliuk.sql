/*
	6) Выбрать из таблицы Books  названия книг и количество страниц (поля Title_book и Pages),
	   а из таблицы Authors выбрать имя соответствующего автора книги (поле Name_ author). 
*/

USE DB_Books

SELECT Books.Title_book, Books.Pages, Authors.Name_authors FROM Books, Authors
WHERE Books.Code_author = Authors.Code_author