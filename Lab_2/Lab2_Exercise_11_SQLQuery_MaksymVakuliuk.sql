/*
	11) ������� �� ������� Authors �������, �����, �������� ������� (���� Name_ author), 
		�������� ������� ���������� � �������.
*/

USE DB_Books

SELECT Name_authors FROM Authors
WHERE Name_authors LIKE '������'
--WHERE Name_authors LIKE '�����%'