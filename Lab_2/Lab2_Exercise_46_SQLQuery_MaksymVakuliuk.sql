/*
46) ������� ������ ������� (���� Name_author), ����� ������� ���� �������� � ������������� ����, ������ ����,
	������� (������� �� ���� Publish). 
*/

USE DB_Books

SELECT DISTINCT Authors.Name_authors FROM Books INNER JOIN Authors
ON Books.Code_author = Authors.Code_author
INNER JOIN Publishing_house
ON Books.Code_publish = Publishing_house.Code_publish
WHERE Publishing_house.Publish in ('���', '����� ����', '�����')
--WHERE Publishing_house.Publish in ('�-��-��-��-��-��-��', '������', '�����')