/*
	31. ��������� �������� ������� ������� ���� � ������� �������. ���� �������� ������� � ������� �� 200 �� 300, 
	�� ����� �� ����������, � ���������� ������� ������� ����������� �̳������� ������� ������� = �� 
	(�� ����  ����� ������� ����� �������).
*/

USE DB_Books

DECLARE @minCost money

SELECT @minCost=MIN(Cost) FROM Purchases
PRINT @minCost

IF (@minCost < 200) OR (@minCost > 300) 
	PRINT '̳������� ������� ������� = ' + CAST(@minCost AS NVarChar(10))