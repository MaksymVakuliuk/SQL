/*
26)  ������� ������ ����������� (���� Publish) �� ������� Publishing_house, � ������� �������� �����,
�������� ������� (���� Title_book) ���������� �� ����� ������� � ����� ������� (���� City) � ������������.
*/

USE DB_Books

SELECT Publish FROM Publishing_house INNER JOIN Books
ON Books.Code_publish = Publishing_house.Code_publish
WHERE Books.Title_book LIKE '�����%' AND Publishing_house.City = '�����������'
