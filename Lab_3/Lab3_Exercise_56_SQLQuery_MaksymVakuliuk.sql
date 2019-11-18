/*
	56.	Підрахувати значення формули y=∑_(n=1)^10[I_n∙a], змінні якої необхідно писати і присвоїти довільні значення.
*/

USE DB_Books

DECLARE @a int set @a = 2
DECLARE @MyTable TABLE(n int NOT NULL IDENTITY(1, 1), 
						I int NOT NULL) 
DECLARE @y int

INSERT @MyTable(I) VALUES
(2),(12),(24),(34),(32),(24),(1),(3),(4),(5)

SELECT @y = SUM(I*@a) FROM @MyTable
PRINT @y
