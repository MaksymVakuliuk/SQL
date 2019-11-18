/*
Визначити змінну Date1 типу дата/час. Присвоїти їй значення дати 31.12.2006 в форматі dd.mm.yyyy.
*/

USE DB_Books

SET DATEFORMAT dmy
DECLARE @DATE1 Date
SET @DATE1= '31.12.2006'
PRINT @DATE1