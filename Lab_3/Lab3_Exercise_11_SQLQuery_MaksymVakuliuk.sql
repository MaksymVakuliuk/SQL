/*
	��������� �������� ���� ���������� ������ � �������� ������,
	��������� �������� � �����, ������� �������� �� �����.
*/

USE DB_Books

DECLARE @minAgeOfAuthor Datetime
SELECT @minAgeOfAuthor= MIN(Birthday) FROM Authors
PRINT @minAgeOfAuthor
