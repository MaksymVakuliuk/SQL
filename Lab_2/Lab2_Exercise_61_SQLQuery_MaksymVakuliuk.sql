/*
	61) Добавить в таблицу Books новую запись, причем вместо ключевого поля поставить код (поле Code_book),
		автоматически увеличенный на единицу от максимального кода в таблице,
		вместо названия книги (поле Title_book) написать ‘Наука. Техника. Инновации’. 
*/

USE DB_Books

DECLARE
	@Code_book INT,
	@Title_book char(40)

SET @Code_book = (SELECT MAX(Code_book) FROM Books)+1
SEt @Title_book = 'Наука. Техника. Инновации'
INSERT INTO Books
(Code_book, Title_book)
VALUES 
(@Code_book, @Title_book)