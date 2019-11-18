/*
	Об’явити змінні типу NUMERIC, VARCHAR, DATETIME.
	Присвоїти значення, відповідними типам. Виконати перетворення змінних типу NUMERIC, 
	VARCHAR, DATETIME в FLOAT, CHAR, BIGINT відповідно і вивести результати на екран.
*/

USE DB_Books

SET DATEFORMAT dmy
DECLARE @Numeric Numeric
DECLARE @Text Varchar(20)
DECLARE @Date Datetime

SET @Numeric = 45
SET @Text = 'Just text'
SET @Date = '21.11.2019'

PRINT CAST(@Numeric AS Float)
PRINT CAST(@Text AS Char)
PRINT CAST(@Date AS BigInt)
