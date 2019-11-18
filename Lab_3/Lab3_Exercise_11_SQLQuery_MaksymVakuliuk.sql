/*
	Визначити мінімальну дату народження автора в довіднику авторів,
	результат помістити в змінну, вивести значення на екран.
*/

USE DB_Books

DECLARE @minAgeOfAuthor Datetime
SELECT @minAgeOfAuthor= MIN(Birthday) FROM Authors
PRINT @minAgeOfAuthor
