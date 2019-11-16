/*
	21)	Вывести список авторов (поле Name_author) из таблицы Authors, которые начинаются на букву ‘К’.  
*/

USE DB_Books

SELECT Name_authors FROM Authors
WHERE Name_authors LIKE 'К%'