/*
	61. підрахувати значення формули y=(a∙cos⁡(x))/(b^2-a^2 )∙sin⁡(x), 
	змінні яких необхідно описати і присвоїти їм довільні значення.
*/

DECLARE @a float
DECLARE @b float
DECLARE @x float
DECLARE @y float

SET @a  = 10
SET @b =  2
SET @x = 60

SET @y = (@a*COS(@x))/(POWER(@a,2)-POWER(@b,2))*SIN(@x) 
PRINT @y
