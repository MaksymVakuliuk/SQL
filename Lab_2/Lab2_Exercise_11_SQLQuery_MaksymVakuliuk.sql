/*
	11) Выбрать из таблицы Authors фамилии, имена, отчества авторов (поле Name_ author), 
		значения которых начинаются с ‘Иванов’.
*/

USE DB_Books

SELECT Name_authors FROM Authors
WHERE Name_authors LIKE 'Иванов'
--WHERE Name_authors LIKE 'Джоан%'