/*
	41. Об’явити статичний курсор по даним таблиць Authors і Books.
	Вивести данні 5-ого запису.
*/

USE DB_Books

DECLARE MyCursor INSENSITIVE SCROLL CURSOR FOR 
(SELECT Authors.Code_author, Authors.Name_authors, Authors.Birthday, Books.Code_book, Books.Title_book, Books.Pages, Books.Code_publish
FROM Authors ,  Books 
WHERE Authors.Code_author = Books.Code_author) 
DECLARE @Code_author int, @Name_authors char(30), @Birthday datetime, @Code_book int, @Title_book char(40), @Pages int, @Code_publish int
OPEN MyCursor
	FETCH ABSOLUTE 5 FROM MyCursor 
	INTO @Code_author, @Name_authors, @Birthday, @Code_book, @Title_book, @Pages, @Code_publish
	PRINT 'Код автора ' + CAST(@Code_author AS NVarChar(20))
	PRINT 'Назва автора' + CAST(@Name_authors AS NVarChar(20))
	PRINT 'день народження автора' + CAST(@Birthday AS NVarChar(20))
	PRINT 'Код книжки ' + CAST(@Code_book AS NVarChar(20))
	PRINT 'Назва книжки ' + CAST(@Title_book AS NVarChar(20))
	PRINT 'Кылькысть сторынок ' + CAST( @Pages AS NVarChar(20))
	PRINT 'Код видавництва ' + CAST(@Code_publish AS NVarChar(20))
CLOSE MyCursor
DEALLOCATE MyCursor