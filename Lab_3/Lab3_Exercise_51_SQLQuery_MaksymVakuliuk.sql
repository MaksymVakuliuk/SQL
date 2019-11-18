/*
	51.	Вставити в базовий текст замість букв «е» і «о» - «ББ».
*/

USE DB_Books
 
DECLARE @Text NVarChar(1024)
SET @Text = 'Текст предназначеный?  для  исправления ! Набор    :разных ,слов и . знаков;припенания.'

PRINT @Text
SET @Text = REPLACE(REPLACE(@Text, 'а', 'ББ'), 'е', 'ББ')

 PRINT @Text